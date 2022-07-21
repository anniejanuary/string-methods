using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Magda";
            string lastName = "Z;
            string fullName = string.Concat("",firstName, lastName,"");

            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Substring(2)); //output will be: gda, becasue "0" is M,
            //"1" is A. "2" is G
            Console.WriteLine(firstName.ToLower()); // output: magda
            Console.WriteLine(firstName.ToUpper()); // output: MAGDA
            Console.Read();
        }
    }
}
