using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using Api.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/discount")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public DiscountController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var data = await _unitOfWork.DiscountRepository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet]
        [Route("get/{Id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _unitOfWork.DiscountRepository.GetSingleByIdAsync(id);
            if (data == null) return BadRequest(new string[] { "Could not find category!" });
            return Ok(data);
        }

        [HttpGet]
        [Route("get/{eventDate}")]
        public async Task<IActionResult> Get(DateTime eventDate)
        {
            var data = await _unitOfWork.DiscountRepository.GetMulti(c => c.StartDate >= eventDate && c.EndDate <= eventDate);
            if (data == null) return BadRequest(new string[] { "Could not find category!" });
            return Ok(data);
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Post([FromBody]DiscountIViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var discount = _mapper.Map<Discount>(model);
            discount.CreatedAt = DateTime.Now;
            discount.CreatedBy = "administrator";
            var data = _unitOfWork.DiscountRepository.Add(discount);
            if (data == null) return BadRequest(new string[] { "Insert fail!" });
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Put([FromBody]DiscountUViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var discount = await _unitOfWork.DiscountRepository.GetSingleByIdAsync(model.Id);
            if (discount == null) return BadRequest(new string[] { "Could not find discount!" });

            discount.Barcode = model.Barcode;
            discount.CategoryId = model.CategoryId;
            discount.Type = model.Type;
            discount.UpdatedAt = DateTime.Now;
            discount.UpdatedBy = "administrator";
            _unitOfWork.DiscountRepository.Update(discount);
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody]DiscountDViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var discount = await _unitOfWork.DiscountRepository.GetSingleByIdAsync(model.Id);
            if (discount == null) return BadRequest(new string[] { "Could not find discount!" });

            _unitOfWork.DiscountRepository.Delete(discount);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}