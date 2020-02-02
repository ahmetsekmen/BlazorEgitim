using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClient.Client.Auth
{
    public class OrnekAuthenticationStateProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(500);
            var anonim = new System.Security.Claims.ClaimsIdentity(new List<Claim>() 
            { 
                new Claim("Key","Value"),
                new Claim(ClaimTypes.Name,"Ahmet")
                //new Claim(ClaimTypes.Role,"Manager")
            });
            return await Task.FromResult(new AuthenticationState(new System.Security.Claims.ClaimsPrincipal(anonim)));
        }
    }
}
