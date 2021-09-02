using System;
using System.Collections.Generic;
using System.Text;

namespace AcessModifierPro
{
    class CollegeStudent : Student
    {
        public int a1;
        private int b1;
        protected int c1;
        internal int d1;
        protected internal int e1;

        public void M2()
        {
            this.a1 = 3;
            //all member o0f its own can be accessible from here
            //a c d e can be accessible
        }

    }
}
