using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Product
    {
        public bool IsLogo { get;  set; }
        /// <summary>
        /// Boolean that determines wether price has been set
        /// </summary>
        public decimal Price { get; set; }
        public string Name { get; set; }
        public bool HasImage { get; set; }
        public string _pathOfImage;
        public string PathOfImage
        {
            get { return _pathOfImage; }
            set
            {
                _pathOfImage = value;
                if (_pathOfImage == "")
                {
                    HasImage = false;
                }
                else
                {
                    HasImage = true;
                }
            }
        }

        public override string ToString()
        {
            return (Name + " " + Price+ " " + "kr");
  
        }
    }
}
