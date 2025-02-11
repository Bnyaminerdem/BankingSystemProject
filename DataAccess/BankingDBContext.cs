using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class BankingDBContext : DbContext
{
    public BankingDBContext(DbContextOptions<BankingDBContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
}