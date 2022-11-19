var path = "D:\\Record.txt";
//existing account number
long acc1 = 2150625015361254;
//the amount of money in the existing account
decimal accMoney1 = 150000;
decimal accMoney2 = 0;
Console.Write("Name:");
string? name = Console.ReadLine();
Console.Write("Surname:");
string? surname = Console.ReadLine();
Console.Write("Account number(16 digit):");
long acc2 = long.Parse(Console.ReadLine());
Console.Write("The amount of money you want to add:");
decimal addMoney = decimal.Parse(Console.ReadLine());
Console.Write("The amount of money you want to trasnfer from existing account to new: ");
decimal moveMoney = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Your existing account number is {acc1} and your balans is {accMoney1 - moveMoney} ");
Console.WriteLine($"Your new account number is {acc2} and your balans is  {accMoney2 + addMoney + moveMoney} ");
using var sw = new StreamWriter(path);
sw.WriteLine($"Name:{name}\n" +
    $"Surname: {surname}\n" +
    $"The amount of money you want to add: {addMoney}\n" +
    $"The amount of money you want to trasnfer from existing account to new: {moveMoney}" +
    $"Your existing account number is {acc1} and you have {accMoney1 - moveMoney} money\n" +
    $"Your new account number is {acc2} and you have {accMoney2 + addMoney + moveMoney} money\n");

if (accMoney1 > accMoney2)
{
    Console.WriteLine($"In Existing account (number:{acc1}) you have much money");
    sw.WriteLine($"In Existing account (number:{acc1}) you have much money");
}
else if(accMoney1 == accMoney2)
{
    Console.WriteLine("The amount of  money is the same in your two");
    sw.WriteLine("The amount of  money is the same in your two");
}
else
{
    Console.WriteLine($"In New account (number:{acc2}) you have much money");
    sw.WriteLine($"In New account (number:{acc2}) you have much money");
}
Console.WriteLine("data saved in D:\\Record.txt");
