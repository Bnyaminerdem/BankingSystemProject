using Core.DependencyResolvers.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract;

public interface IUserDal: IEntityRepository<User>
{
    List<OperationClaim> GetClaims(User user);
}