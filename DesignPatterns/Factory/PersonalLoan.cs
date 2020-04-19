namespace Factory
{
    using System;

    //Personal loan is a loan type which can have Person specific details
    public class PersonalLoan : ILoan
    {
        public decimal Amount { get ; set ; }
        public string BorrowerName { get ; set ; }
        
        //Person specific property
        public string Purpose { get; set; }
        public void GetDetails(decimal Amount, string BorrowerName, string Purpose)
        {
            this.Amount = Amount;
            this.BorrowerName = BorrowerName;
            this.Purpose = Purpose;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Borrower Name: {this.BorrowerName}");
            Console.WriteLine($"Purpose: {this.Purpose}");
            Console.WriteLine($"Loan Amount: {this.Amount}");   
        }
    }
}