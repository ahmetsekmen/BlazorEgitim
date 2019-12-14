using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClient.Client.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask<string> AlVer(this IJSRuntime js,string message1, string message2)
        {
            return await js.InvokeAsync<string>("alVer", message1, message2);
        }
    }
}
