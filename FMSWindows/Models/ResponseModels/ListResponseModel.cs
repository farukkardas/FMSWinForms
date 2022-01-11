using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Models
{
    public class ListResponseModel<T> : ResponseModel
    {
        public T[] Data { get; set; }
    }


}
