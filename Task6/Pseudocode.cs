//setup
double orderTotal = 0.0;
double statetax = 0.05;
double localtax = 0.03;
double grandtotal = 0.0;
string response;
string answer = "Y";
string finalOrder;



//input
"What is your order amount?"
GET ORDER AMOUNT
"Would you like to calculate another order?"
GET ANSWER


//process

stateTaxAmount = orderTotal* statetax;
localTaxAmount = orderTotal* localtax;
grandtotal = orderTotal + stateTaxAmount + localTaxAmount;

do
{
  Console.WriteLine("What is your order total?");
} while (!Double.TryParse(Console.ReadLine(), out orderTotal)

do
{
finalOrder = TaxCalculations();
Console.WriteLine(finalOrder);

Console.WriteLine("Would you like to calculate another order? (Y)es or (N)o");
answer = Console.ReadLine();
} while (answer.ToUpper() == "Y");

//output
response = "Your order subtotal is " + "$" + orderTotal +" with a state tax of " + "$" + stateTaxAmount + " and a local tax " +
            "of " + "$" + localTaxAmount + " for a grand total of " + "$" + grandtotal;