using System.Threading.Tasks;
using FMSWindows.Models;

namespace FMSWindows.Services.Abstract
{
    public interface ICustomer
    {
        Task<ListResponseModel<CustomerDetail>> GetCustomerDetails();
    }
}