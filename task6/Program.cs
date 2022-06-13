Console.WriteLine ("input number : ");
int number = Convert.ToInt32(Console.ReadLine ());
int result1 = number/2;
int result2 = number%2;
if (result1==result2)
{
    Console.WriteLine(number + " - четное");
}
else
{
   Console.WriteLine(number + " - нечетное"); 
}