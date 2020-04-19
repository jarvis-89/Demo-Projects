namespace Factory
{
    using System;

    // Home loan is a loan type which can have Home specific details
    public class HomeLoan : ILoan
    {
        public decimal Amount { get ; set ; }
        public string BorrowerName { get ; set ; }

        //Home specific property
        public string PropertyAddress { get; set; }

        public void GetDetails(decimal Amount, string BorrowerName, string PropertyAddress)
        {
            this.Amount = Amount;
            this.BorrowerName = BorrowerName;
            this.PropertyAddress = PropertyAddress;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Borrower Name: {this.BorrowerName}");
            Console.WriteLine($"Property Address: {this.PropertyAddress}");
            Console.WriteLine($"Loan Amount: {this.Amount}");   
        }
    }
}