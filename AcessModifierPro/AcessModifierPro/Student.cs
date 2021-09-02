using System;
using System.Collections.Generic;
using System.Text;

namespace AcessModifierPro
{
    class Student
    {
        public int a;
        private int b;
        protected int c; 
        internal int d;
        protected internal int e;  

        public void M2()
      {
            this.a = 3;
            //all member can be accessible from here 
        }
    }
}
