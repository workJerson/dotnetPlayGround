using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.RestApi
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public bool IsSuccessful { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}
