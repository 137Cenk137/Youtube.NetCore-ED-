
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts;
// veri tabani nesnelerimizi api veya son kullaniciya tasimiyoruz
public interface IBrandService{
    CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest);

    List<GetAllBrandResponse> GetAll();

}