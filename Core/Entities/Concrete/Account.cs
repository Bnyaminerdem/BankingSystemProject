using System.Security.Principal;

namespace Core.Entities.Concrete;

public class Account
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public string Currency { get; set; }    
    //public AccountType Type { get; set; }
    //public int UserId { get; set; }
}