using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Models.ResponseModels
{
    public class ListErrorModel<T>:ResponseModel
    {
        public T[] Errors { get; set; }
    }
}
