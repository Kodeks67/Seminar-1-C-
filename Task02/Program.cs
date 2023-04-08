int numberA = int.Parse (Console.ReadLine());
int numberB = int.Parse (Console.ReadLine());
int numberC = int.Parse (Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.Write("max = ");
    Console.Write(numberA);
}
else if (numberB > numberA && numberB > numberC)
{
    Console.Write("max = ");
    Console.Write(numberB);
}
else
{
    Console.Write("max = ");
    Console.Write(numberC);
}
