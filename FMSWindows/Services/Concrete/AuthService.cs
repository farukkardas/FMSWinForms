using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FMSWindows.Models;
using FMSWindows.Models.Auth;
using FMSWindows.Services.Abstract;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Windows.Forms;
using System.Linq;

namespace FMSWindows.Services
{
    public class AuthService : IAuth
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
               
               
                var handler = new JwtSecurityTokenHandler();
                var decodedValue = handler.ReadJwtToken(deserializeContent.Data.Token);

           
                foreach (var claims in decodedValue.Claims)
                {
                    if (claims.Type.Contains("claims/role"))
                    {
                        Program.Role = claims.Value;
                    }

                    if (claims.Type.Contains("nameidentifier"))
                    {
                        Program.Id = Convert.ToInt32(claims.Value);
                    }

                }

                Program.Jwt = deserializeContent.Data.Token;
                Program.SecurityKey = deserializeContent.Data.SecurityKey;
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
