using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Delegation
{
    public class PrintBanner : Print
    {
        private Banner banner;
        public PrintBanner(String str)
        {
            banner = new Banner(str);
        }

        public override void PrintWeak()
        {
            banner.ShowWIthParen();
        }
        public override void PrintStrong()
        {
            banner.ShowWithAster();
        }
    }
}
