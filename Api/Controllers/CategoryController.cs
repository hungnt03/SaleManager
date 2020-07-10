﻿using Api.Entities;
using Api.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var data = await _unitOfWork.CategoryRepository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet]
        [Route("get/{Id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _unitOfWork.CategoryRepository.GetSingleByIdAsync(id);
            if (data == null) return BadRequest(new string[] { "Could not find category!" });
            return Ok(data);
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Post([FromBody]CategoryIViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var category = _mapper.Map<Category>(model);
            category.CreatedAt = DateTime.Now;
            category.CreatedBy = "administrator";
            var data = _unitOfWork.CategoryRepository.Add(category);
            if (data == null) return BadRequest(new string[] { "Insert fail!" });
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Put([FromBody]CategoryUViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var category = await _unitOfWork.CategoryRepository.GetSingleByIdAsync(model.Id);
            if (category == null) return BadRequest(new string[] { "Could not find category!" });

            category.Name = model.Name;
            category.Description = model.Description;
            category.UpdatedAt = DateTime.Now;
            category.UpdatedBy = "administrator";
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody]CategoryDViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

            var category = await _unitOfWork.CategoryRepository.GetSingleByIdAsync(model.Id);
            if (category == null) return BadRequest(new string[] { "Could not find category!" });

            _unitOfWork.CategoryRepository.Delete(category);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}