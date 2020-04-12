using System;
using Bridge.Categories;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Category pantry = new Pantry();
            pantry.Load(1);
            Category personalCare = new PersonalCare();
            personalCare.Load(2);

            IVendor wsRetail = new Vendor(pantry,personalCare);

            Console.WriteLine(pantry.Name);
            Console.WriteLine("===============");
            wsRetail.PrintItems(pantry);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(personalCare.Name);
            Console.WriteLine("===============");
            wsRetail.PrintItems(personalCare);

            Console.ReadKey();
        }
    }
}
