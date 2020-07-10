using System;
using Api.Entities;
using Api.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public CustomerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var data = await _unitOfWork.CustomerRepository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet]
        [Route("get/{Id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _unitOfWork.CustomerRepository.GetSingleByIdAsync(id);
            if (data == null) return BadRequest(new string[] { "Could not find customer!" });
            return Ok(data);
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Post([FromBody]CustomerIViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var customer = _mapper.Map<Customer>(model);
            customer.CreatedAt = DateTime.Now;
            customer.CreatedBy = "administrator";
            var data = _unitOfWork.CustomerRepository.Add(customer);
            if (data == null) return BadRequest(new string[] { "Insert fail!" });
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Put([FromBody]CustomerUViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var customer = await _unitOfWork.CustomerRepository.GetSingleByIdAsync(model.Id);
            if (customer == null) return BadRequest(new string[] { "Could not find customer!" });

            customer.Name = model.Name;
            customer.Address = model.Address;
            customer.Contact = model.Contact;
            customer.UpdatedAt = DateTime.Now;
            customer.UpdatedBy = "administrator";
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody]CustomerDViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var customer = await _unitOfWork.CustomerRepository.GetSingleByIdAsync(model.Id);
            if (customer == null) return BadRequest(new string[] { "Could not find customer!" });

            _unitOfWork.CustomerRepository.Delete(customer);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}