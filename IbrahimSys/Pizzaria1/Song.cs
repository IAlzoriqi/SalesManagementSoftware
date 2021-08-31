using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria1
{
    class Song
    {
        private string titall = string.Empty;
        private string outher = string.Empty;

        
        public string Tital
        {
            get { return titall; }
            set {
                if (titall != value)
                    this.titall = value;
            }
        }

        public string Outher
        {
            get { return outher; }
            set
            {
                if (outher != value)
                    this.outher = value;
            }
        }
    }
}
