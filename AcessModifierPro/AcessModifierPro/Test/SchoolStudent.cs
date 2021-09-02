using System;
using System.Collections.Generic;
using System.Text;

namespace AcessModifierPro.Test
{
    class SchoolStudent : Student
    {
        public void m3()
        {
            this.a = 3;
            //a,b,c,d,e is accessible from here
        }
    }
}
