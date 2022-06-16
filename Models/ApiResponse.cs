using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IctChain.Models.Response
{
    public class ApiResponse
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public object Data { get; set; }

    }
    public class APIListResponse<T>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public List<T> Data { get; set; }
    }

}
