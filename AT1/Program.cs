try
{
    Console.WriteLine("First Number:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Second Number:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Third Number:");
    int c = Convert.ToInt32(Console.ReadLine());

    int result = a + b + c;
    Console.WriteLine("Result = " + result);
}
catch (Exception)
{
    Console.WriteLine("Please try again");

}
