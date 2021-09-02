using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Test
{
   public class SchoolStudent : Student
    {
        public void M3()
        {
            this.a = 2;
            //a c d e can be accessible
        }
    }
}
