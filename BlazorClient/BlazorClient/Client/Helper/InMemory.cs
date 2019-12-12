using BlazorClient.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClient.Client.Helper
{
    public class InMemory
    {
        public List<Malzeme> GetMalzemeList()
        {
            return new List<Malzeme>()
            {   
                new Malzeme(){Ismi="Masa",Uzunlugu=80},
                new Malzeme(){Ismi="sandalye",Uzunlugu=100},
                new Malzeme(){Ismi="Vazor",Uzunlugu=30}
            };
        }
    }
}
