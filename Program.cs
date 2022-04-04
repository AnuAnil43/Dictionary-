int i, choice, sum = 0;
string input = "";
string AOid;
string Afirstname, Alastname, Aphonenumber, ALocation ;
string[] products = new string[7] { "Bread", "Milk", "Soda", "Beef", "Pork", "Coffee", "Beer" };
int[] prices = new int[7] { 1, 2, 2, 5, 4, 6, 3 };

Console.WriteLine("\nCreating an Order................");
Console.WriteLine("\nThis is a list of shop products:");
for(i = 0; i < products.Length; i++)
{
    Console.WriteLine((i+1) + ". " + products[i]);
}
while(!input.ToLower().Equals("p"))
{
    input = Console.ReadLine();
    if(Int32.TryParse(input, out choice))
    {
        choice = choice-1;
        if(choice >= 0 && choice < products.Length)
        {
            Console.WriteLine("Adding " + products[choice] + " to the list.");
            sum += prices[choice];
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a number between 1-7.");
        }
    }
    else if(input.ToLower().Equals("p"))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input, please enter a number between 1-7 or P to exit.");
    }
}

Console.WriteLine("The final cost of the products is $" + sum);

Console.WriteLine("Input customer details");
Console.WriteLine("Enter OrderID");
AOid = Console.ReadLine();
Console.WriteLine("Enter First Name");
Afirstname = Console.ReadLine();
Console.WriteLine("Enter Last Name");
Alastname = Console.ReadLine();
Console.WriteLine("Enter PhoneNumber");
Aphonenumber = Console.ReadLine();
Console.WriteLine("Enter Location");
ALocation = Console.ReadLine();
Console.WriteLine("\n Printing Order details............");
Console.WriteLine("Order ID  "  + AOid);
Console.WriteLine("FirstName  "  + Afirstname);
Console.WriteLine("LastName  "  + Alastname);
Console.WriteLine("PhoneNumber  "  + Aphonenumber);
Console.WriteLine("Location  "  + ALocation);
Console.WriteLine("AmountSpent  "  + sum);

 
