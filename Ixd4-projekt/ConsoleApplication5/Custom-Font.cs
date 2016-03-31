using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace ConsoleApplication5
{
    public class Custom_Font
    {

        static void font1()
        {
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(@"C:\Users\kranzekage\Downloads\galano\Grotesque.otf");
            string grotesque = privateFonts.Families[0].Name;
    }

    }


    }

