namespace Factory
{
    public interface ILoan
    {
         public decimal Amount { get; set; }
         public string BorrowerName { get; set; }

         void PrintDetails();
    }
}