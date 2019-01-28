using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            string answer = "Y";
            string finalOrder;

            //input


            //if = to empty string then re enter with correct info while is check and check if its true, if true loop if not continue w calc


            do
            {
                finalOrder = TaxCalculations();
                Console.WriteLine(finalOrder);



                Console.WriteLine("Would you like to calculate another order? (Y)es or (N)o");
                answer = Console.ReadLine();

            } while (answer.ToUpper() == "Y");



        }
        public static string TaxCalculations()
        {
            double orderTotal = 0.0;
            double statetax = 0.05;
            double localtax = 0.03;
            double grandtotal = 0.0;
            string response;

            double stateTaxAmount; // 0.5%
            double localTaxAmount; // 0.3%


            do
            {
                Console.WriteLine("What is your order total?");

            } while (!Double.TryParse(Console.ReadLine(), out orderTotal));



            //process

            stateTaxAmount = orderTotal * statetax;
            localTaxAmount = orderTotal * localtax;
            grandtotal = orderTotal + stateTaxAmount + localTaxAmount;


            //output
            response = "Your order subtotal is " + "$" + orderTotal +
                " with a state tax of " + "$" + stateTaxAmount + " and a local tax " +
                "of " + "$" + localTaxAmount +
                " for a grand total of " + "$" + grandtotal;

            return (response);


        }


    }
}
