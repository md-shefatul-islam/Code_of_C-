using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClassinDifferentClass
{
   internal partial class Test
    {
        private int x;
        private string name;

        internal int X
        {
            get { return x; }
            set { this.x = value; }
        }
        internal string Name { set; get;  }
        internal string Y { get; set; }
        internal void M2()
        {

        }
    }
}
