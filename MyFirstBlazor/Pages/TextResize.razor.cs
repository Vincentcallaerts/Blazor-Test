using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Pages
{
    public partial class TextResize
    {
        private int fontsize = 50;
        private string fontsizepx = "50px";
        protected void Up()
        {
            fontsize++;
            Change();
        }
        protected void Down()
        {
            fontsize--;
            Change();
        }
        protected void Change()
        {
            fontsizepx = fontsize + "px";
        }
    }
}
