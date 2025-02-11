using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Kullanıcı başarıyla eklendi.");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Kullanıcı bilgileri güncellendi.");
        }

        public IResult Delete(int userId)
        {
            var user = _userDal.Get(u => u.Id == userId);
            if (user == null)
                return new ErrorResult("Kullanıcı bulunamadı.");
            
            _userDal.Delete(user);
            return new SuccessResult("Kullanıcı silindi.");
        }

        public IDataResult<User> GetById(int userId)
        {
            var user = _userDal.Get(u => u.Id == userId);
            if (user == null)
            {
                return new ErrorDataResult<User>("Kullanıcı bulunamadı.");
            }

            return new SuccessDataResult<User>(user, "Kullanıcı bulundu.");
        }
    }
}