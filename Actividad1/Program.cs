class operacion
{
    static void Main(string[] arg)
    {
        int qp = int.Parse(Console.ReadLine());
        if (qp == 1 )
        {
            Console.WriteLine("Enter the first number to be added ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the following number ");
            double n2 = double.Parse(Console.ReadLine());

            double Result1 = n1 + n2;
            Console.WriteLine("the result is " + Result1);
        }

        Console.ReadKey();


    }

}
