using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        //[Parameter nog adden]
        protected int addMany = 0;
        protected void IncrementCount()
        {
            currentCount++;
        }
        protected void Up()
        {
            addMany++;
        }
        protected void Down()
        {
            addMany--;
        }
        protected void IncrementMany()
        {
            currentCount += addMany;
        }
    }
}
