using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMSWindows.Models;
using FMSWindows.Models.Auth;
using Newtonsoft.Json;

namespace FMSWindows.Services
{
    public class AuthService
    {
        public async Task<SingleResponseModel<TokenModel>> Login(string email, string password)
        {

            var client = new HttpClient();

            var json = JsonConvert.SerializeObject(new LoginModel()
            {
                Email = email,
                Password = password
            }
            );


            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var jsonString = await client.PostAsync("http://localhost:5000/api/auth/login", httpContent);

            SingleResponseModel<TokenModel> tokenModel = new SingleResponseModel<TokenModel>
            {
                Message = jsonString.RequestMessage.ToString()
            };

            if (jsonString.Content != null)
            {
                var responseContent = await jsonString.Content.ReadAsStringAsync();

                var deserializeContent =
                    JsonConvert.DeserializeObject<SingleResponseModel<TokenModel>>(responseContent);

                tokenModel.Data = deserializeContent.Data;
                tokenModel.Message = deserializeContent.Message;
                tokenModel.Success = deserializeContent.Success;
            }


            return tokenModel;
        }

        public async Task<string> Register(string firstName, string lastName,string email,string password)
        {

            var client = new HttpClient();

            var json = JsonConvert.SerializeObject(new RegisterModel()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password
                }
            );


            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var jsonString = await client.PostAsync("http://localhost:5000/api/auth/register", httpContent);

            SingleResponseModel<TokenModel> tokenModel = new SingleResponseModel<TokenModel>
            {
                Message = jsonString.RequestMessage.ToString()
            };

            string responseContent = "";

            if (jsonString.Content != null)
            {
                responseContent = await jsonString.Content.ReadAsStringAsync();
            }


            return responseContent;
        }
    }
}
