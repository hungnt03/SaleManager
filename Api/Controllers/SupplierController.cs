using Api.Entities;
using Api.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private string _userId;
        public SupplierController(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var data = await _unitOfWork.SupplierRepository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet]
        [Route("get/{Id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _unitOfWork.SupplierRepository.GetSingleByIdAsync(id);
            if (data == null) return BadRequest(new string[] { "Could not find supplier!" });
            return Ok(data);
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Post([FromBody]SupplierIViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var supplier = _mapper.Map<Supplier>(model);
            supplier.CreatedAt = DateTime.Now;
            supplier.CreatedBy = _userId;
            var data = _unitOfWork.SupplierRepository.Add(supplier);
            if (data == null) return BadRequest(new string[] { "Insert fail!" });
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Put([FromBody]SupplierUViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var supplier = await _unitOfWork.SupplierRepository.GetSingleByIdAsync(model.Id);
            if (supplier == null) return BadRequest(new string[] { "Could not find supplier!" });

            supplier.Name = model.Name;
            supplier.Address = model.Address;
            supplier.Contact1 = model.Contact1;
            supplier.Contact2 = model.Contact2;
            supplier.UpdatedAt = DateTime.Now;
            supplier.UpdatedBy = _userId;
            _unitOfWork.SupplierRepository.Update(supplier);
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody]SupplierDViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var supplier = await _unitOfWork.SupplierRepository.GetSingleByIdAsync(model.Id);
            if (supplier == null) return BadRequest(new string[] { "Could not find supplier!" });

            _unitOfWork.SupplierRepository.Delete(supplier);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}