using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Pages
{
    public partial class CommentBox
    {
        private int Words { get; set; }
        private int MaxCount { get; set; } = 256;
        public string Input { get; set; } = string.Empty;

        private void WordUpdate()
        {
            int counter = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == ' ')
                {
                    counter++;
                }
            }
            Words = counter;
        }
    }
}
