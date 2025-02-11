using Core.DependencyResolvers.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFrameWork;


public class EfUserDal : EfEntityRepositoryBase<User, BankingDBContext>, IUserDal
{
    private readonly BankingDBContext _context;

    
    public EfUserDal(BankingDBContext context) : base(context)
    {
        _context = context;
    }

    public List<OperationClaim> GetClaims(User user)
    {
        var result = from operationClaim in _context.OperationClaims
            join userOperationClaim in _context.UserOperationClaims
                on operationClaim.Id equals userOperationClaim.OperationClaimId
            where userOperationClaim.UserId == user.Id
            select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

        return result.ToList();
    }
}

