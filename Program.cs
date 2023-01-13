// See https://aka.ms/new-console-template for more information

//declaring variable
int firstHeight = 0, secondHeight = 0;

//receiving input
Console.WriteLine("Enter first height:");
firstHeight = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second height:");
secondHeight = int.Parse(Console.ReadLine());

if (firstHeight > secondHeight)
{
    Console.WriteLine("The ball is in the retreat state");
}
else if (secondHeight > firstHeight)
{
    Console.WriteLine("The ball is in the takeoff state");
}
else
{
    Console.WriteLine("error");
}