using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;

namespace Business.Abstract;

public interface IUserService
{
    IResult Add(User user);
    IResult Update(User user);
    IResult Delete(int userId);
    IDataResult<User> GetById(int userId);
}
