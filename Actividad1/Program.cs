class operacion
{
    static void Main(string[] arg)
    {
        Console.WriteLine("What operation you wish to perform? \n (1) Sddition  (2) Subtraction  (3) Multiplication  (4) Divicion  (5) Exit");
        
        string reply = Console.ReadLine();
        Convert.ToInt32(reply);
        int qp = int.Parse(reply);
        if (qp == 1 )
        {
            Console.WriteLine("Enter the first number to be added ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the following number ");
            double n2 = double.Parse(Console.ReadLine());

            double Result1 = n1 + n2;
            Console.WriteLine("the result is " + Result1);
        }
        else if (qp == 2 )
        {
            Console.WriteLine("Enter the first number to be added ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the following number ");
            double n2 = double.Parse(Console.ReadLine());

            double Result1 = n1 - n2;
            Console.WriteLine("the result is " + Result1);
        }
        else if(qp == 3 )
        {
            Console.WriteLine("Enter the first number to be added ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the following number ");
            double n2 = double.Parse(Console.ReadLine());

            double Result1 = n1 * n2;
            Console.WriteLine("the result is " + Result1);
        }
        else if(qp == 4)
        {
            Console.WriteLine("Enter the first number to be added ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the following number ");
            double n2 = double.Parse(Console.ReadLine());

            double Result1 = n1 / n2;
            Console.WriteLine("the result is " + Result1);
        }
        else
        {
            Console.WriteLine("Goodbye ");
        }

        Console.ReadKey();


    }

}
