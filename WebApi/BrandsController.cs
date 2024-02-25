using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace;

    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }   

        [HttpPost]
        public IActionResult Add(CreatedBrandRequest createdBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse= _brandService.Add(createdBrandRequest);
            return Ok(createdBrandResponse);
        }

        public IActionResult GetAll()
        {
                return Ok(_brandService.GetAll());
        }

    }

