using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICardService
    {
        IDataResult<List<Card>> GetAll();
        IDataResult<List<Card>> GetCardsByCustomerId(int id);
        IResult Add(Card card);
        IResult Update(Card card);
        IResult Delete(Card card);
    }
}