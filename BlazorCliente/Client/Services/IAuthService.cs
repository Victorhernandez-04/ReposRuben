using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationWithClientSideBlazor.Shared;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;

namespace BlazorCliente.Client.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
