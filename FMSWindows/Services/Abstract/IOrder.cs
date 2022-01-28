using FMSWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Services.Abstract
{
    public interface IOrder
    {
        Task<ListResponseModel<OrderDetail>> GetUserOrders();
        Task<ResponseModel> ApproveOrder(string orderId);
        Task<ResponseModel> AddDeliveryNo(string order, string deliveryNo);

    }
}
