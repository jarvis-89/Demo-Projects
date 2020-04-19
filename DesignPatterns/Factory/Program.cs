using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory patter example!");
            Console.WriteLine("=======================");
            Console.WriteLine();

            //Create Loan

            var loanFactory = new LoanFactory();

            HomeLoan homeLoan = (HomeLoan)loanFactory.Create(LoanType.HomeLoan);
            homeLoan.GetDetails(2000000,"Satya", "Pune");
            Console.WriteLine("Home Loan Details:");
            Console.WriteLine("==================");
            homeLoan.PrintDetails();

            Console.WriteLine();

            CarLoan carLoan = (CarLoan)loanFactory.Create(LoanType.CarLoan);
            carLoan.GetDetails(750000,"Sarabjit","i20");
            Console.WriteLine("Car Loan Details:");
            Console.WriteLine("==================");
            carLoan.PrintDetails();

            Console.WriteLine();

            //Here in same way above we can create personal loan object as it implements ILoan interface
            //Also we can create other loan types as well by adding class which implements ILoan
            //Thus we can add new loans without modifying domain object like Home Loan, Car Loan etc.

            Console.ReadKey();
        }
    }
}
