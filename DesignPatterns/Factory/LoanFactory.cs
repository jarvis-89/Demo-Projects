namespace Factory
{
    public class LoanFactory
    {
        public ILoan Create(LoanType loanType)
        {
            ILoan loan = null;
            switch (loanType)
            {
                case LoanType.HomeLoan:
                    loan = new HomeLoan();
                    break;
                case LoanType.CarLoan:
                    loan = new CarLoan();
                    break;
                case LoanType.PersonalLoan:
                    loan = new PersonalLoan();
                    break;
                default:
                    break;
            }
            return loan;
        }
    }
}