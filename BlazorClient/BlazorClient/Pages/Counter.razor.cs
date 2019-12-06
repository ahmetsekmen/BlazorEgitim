using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [Parameter]
        public int artıs { get; set; } = 1;

        private void IncrementCount()
        {
            currentCount = currentCount + artıs;
        }
    }
}
