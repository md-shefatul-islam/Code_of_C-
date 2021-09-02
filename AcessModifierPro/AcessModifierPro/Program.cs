namespace AcessModifierPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.d = 5;
            //public-a, internal-d, protected internal-e is accessible

            CollegeStudent cs = new CollegeStudent();
            cs.a1 = 6;
            //a,a1,c,d,d1,e,e1 can be accessible
        }
    }
}
