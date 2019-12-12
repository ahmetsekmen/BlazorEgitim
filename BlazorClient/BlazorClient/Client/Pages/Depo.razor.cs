using BlazorClient.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Client.Pages
{
    public partial class Depo
    {
        List<Malzeme> malzemeList;
        [Inject] BlazorClient.Client.Helper.InMemory inMemory { get; set; }


        protected override void OnInitialized()
        {
            malzemeList = inMemory.GetMalzemeList();


        }
    }
}
