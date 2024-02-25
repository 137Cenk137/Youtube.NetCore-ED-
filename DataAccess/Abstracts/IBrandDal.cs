

using System.ComponentModel;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IBrandDal//bunu IbrandDal olarak Dao ,Repository, Data görebiliriz
{

    void Add(Brand brand);
    List<Brand> GetAll();

}