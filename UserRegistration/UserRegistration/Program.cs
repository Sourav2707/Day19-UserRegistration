using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Enter the First name");
string firstname = Console.ReadLine();
if(patterns.Validation(firstname))
    Console.WriteLine("Valid first name");
else
    Console.WriteLine("Invalid first name");
Console.WriteLine("Enter the Last name");
string lastname = Console.ReadLine();
if (patterns.Validation(lastname))
    Console.WriteLine("Valid first name");
else
    Console.WriteLine("Invalid first name");