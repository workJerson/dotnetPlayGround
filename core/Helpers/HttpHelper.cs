using Core.Models.RestApi;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public interface IHttpHelper
    {
        Task<ApiResponse> Get(string url, dynamic auth, dynamic dynamic);
        Task<ApiResponse> Post(string url, dynamic auth, dynamic dynamic);
        Task<ApiResponse> Put(string url, dynamic auth, dynamic dynamic);
        Task<ApiResponse> Patch(string url, dynamic auth, dynamic dynamic);
        Task<ApiResponse> Destroy(string url, dynamic auth, dynamic dynamic);
    }
    public class HttpHelper : IHttpHelper
    {
        private readonly HttpClient httpClient = new HttpClient();
        public HttpHelper()
        {

        }
        public Task<ApiResponse> Destroy(string url, dynamic auth, dynamic dynamic)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Get(string url, dynamic auth, dynamic dynamic)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Patch(string url, dynamic auth, dynamic dynamic)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Post(string url, dynamic auth, dynamic dynamic)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Put(string url, dynamic auth, dynamic dynamic)
        {
            throw new NotImplementedException();
        }
    }
}
