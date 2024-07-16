namespace ChandiniAssessment1
{
    /*1.You deposit Rs 1000.00 in the bank account at 5% annual compound interest. 
The interest is paid once at the end of the year
What if you are interested in earning more than 100000? How long will it take to reach this mark
    */
    internal class Bank
    {
        double deposit = 1000.00;
        double compountInterest=0.05;
        double InterestInYear;
        double additionalInfo;
        public void Display()
        {
            int year = 0;
            try
            {
                while (deposit <= 100000)
                {
                    deposit = deposit + (deposit * InterestInYear);
                    year++;
                    Console.WriteLine("the amount to be deposit is:");
                    Console.WriteLine(year);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Bank obj = new Bank();
                obj.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
