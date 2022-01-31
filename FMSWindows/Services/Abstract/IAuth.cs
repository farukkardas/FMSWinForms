using System.Threading.Tasks;
using FMSWindows.Models;

namespace FMSWindows.Services.Abstract
{
    public interface IAuth
    {
        Task<SingleResponseModel<TokenModel>> Login(string email, string password);
        Task<string> Register(string firstName, string lastName, string email, string password);
    }
}