

using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class BrandDal : IBrandDal
{

    List<Brand> _brands;
    public BrandDal()
    {
        _brands = new List<Brand>();
        _brands.Add(new Brand(){Id = 12,Name = "BWM",CreatedDate = DateTime.Now});
        _brands.Add(new Brand(){Id = 12,Name = "Volvo",CreatedDate = DateTime.Now});
        _brands.Add(new Brand(){Id = 12,Name = "Mercedes",CreatedDate = DateTime.Now});
        _brands.Add(new Brand(){Id = 12,Name = "Opel",CreatedDate = DateTime.Now});
    }
    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }
}