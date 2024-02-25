

using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes;

public class BrandManager:IBrandService
{

    private readonly IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }
    public CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest)
    {
        // business rule

        //Mapping
        Brand ghostBrand = new Brand(){
            Name = createdBrandRequest.Name,
            CreatedDate = DateTime.Now,
        };
        _brandDal.Add(ghostBrand);

         //Mapping
         CreatedBrandResponse createdBrandResponse= new CreatedBrandResponse(){
           Name = ghostBrand.Name,
           Id = 4,
           CreatedDate = ghostBrand.CreatedDate,
        };
        return createdBrandResponse;

    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();

        List<GetAllBrandResponse> brandsList = new();
        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.CreatedDate= brand.CreatedDate;
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.Name = brand.Name;

            brandsList.Add(getAllBrandResponse);
        }

        return brandsList;
    }
}