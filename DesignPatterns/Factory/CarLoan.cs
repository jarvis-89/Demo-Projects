namespace Factory
{
    using System;

    // Car loan is a loan type which can have car specific details
    public class CarLoan : ILoan
    {
        public decimal Amount { get ; set ; }
        public string BorrowerName { get ; set ; }

        //Car specific property
        public string CarName { get; set; }

        public void GetDetails(decimal Amount, string BorrowerName, string CarName)
        {
            this.Amount = Amount;
            this.BorrowerName = BorrowerName;
            this.CarName = CarName;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Borrower Name: {this.BorrowerName}");
            Console.WriteLine($"Car Name: {this.CarName}");
            Console.WriteLine($"Loan Amount: {this.Amount}");   
        }
    }
}