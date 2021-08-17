using System;

namespace TDD_Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm(" Katie Melua life wonderfuL  "));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm(" Katie       Melua           life          wonderfuL  "));

            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Wonderful Like Katie Melua"));
            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("like Wonderful katie Melua"));
            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Katie Melua life wonderfuL"));

            Console.Read();
        }
    }
}
