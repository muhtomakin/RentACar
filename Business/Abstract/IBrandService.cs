using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}