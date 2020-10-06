using System;
using System.ComponentModel.DataAnnotations;
namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            bool result = class1.ValidateEmail("abc.123@yahoo.com.com");
            Console.WriteLine(result);
        }
    }
}
