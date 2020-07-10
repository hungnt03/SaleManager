using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Api.Entities;
using Api.Entities.Inflastructor;
using Api.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ProductController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("get")]
        public async Task<IActionResult> Get([FromBody]ProductSViewModel model)
        {
            var pageSize = 5;
            if (!string.IsNullOrEmpty(model.Name) || model.CategoryId != null)
                model.PageNumber = 1;
            var data =  _unitOfWork.ProductRepository.GetMultiQueryable(x => x.Enable 
                && (model.CategoryId == null || x.CategoryId == model.CategoryId) 
                && (string.IsNullOrEmpty(model.Name) || x.Name.Contains(model.Name)));
            return Ok(await PaginatedList<Product>.CreateAsync(data, model.PageNumber ?? 1, pageSize));
        }

        [HttpGet]
        [Route("get/{Barcode}")]
        public async Task<IActionResult> Get(string barcode)
        {
            var data = await _unitOfWork.ProductRepository.GetSingleByCondition(x => x.Barcode.Equals(barcode));
            if (data == null) return BadRequest(new string[] { "Could not find product!" });
            return Ok(data);
        }

        //https://code-maze.com/upload-files-dot-net-core-angular/
        //https://github.com/CodeMazeBlog/dotnet-core-file-upload/blob/end-project/FinishedProject/UploadFilesServer/UploadFilesServer/Controllers/UploadController.cs
        [HttpPost, DisableRequestSizeLimit]
        [Route("get/upload")]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("StaticFiles", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}