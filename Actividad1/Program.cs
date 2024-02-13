class operacion
{
    static void Main(string[] arg)
    {
        string reply;
        int qp;
        double n1, n2;

        do
        {
            Console.WriteLine("What operation you wish to perform? \n (1) Sddition  (2) Subtraction  (3) Multiplication  (4) Divicion  (5...) Exit");
            reply = Console.ReadLine();
        }
        while (!int.TryParse(reply, out qp));
        
  
        Convert.ToInt32(reply);
        qp = int.Parse(reply);


        if (qp == 1 )
        {
            do
            {
                Console.WriteLine("Enter the first number to be added ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n1 = double.Parse(reply);



            do
            {
                Console.WriteLine("Enter the following number ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n2 = double.Parse(reply);

            double Result1 = n1 + n2;
            Console.WriteLine("the result is " + Result1);
        }


        else if (qp == 2 )
        {
            do
            {
                Console.WriteLine("Enter the first number to be added ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n1 = double.Parse(reply);



            do
            {
                Console.WriteLine("Enter the following number ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n2 = double.Parse(reply);

            double Result1 = n1 - n2;
            Console.WriteLine("the result is " + Result1);
        }
        else if(qp == 3 )
        {
            do
            {
                Console.WriteLine("Enter the first number to be added ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n1 = double.Parse(reply);



            do
            {
                Console.WriteLine("Enter the following number ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n2 = double.Parse(reply);

            double Result1 = n1 * n2;
            Console.WriteLine("the result is " + Result1);
        }
        else if(qp == 4)
        {
            do
            {
                Console.WriteLine("Enter the first number to be added ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n1 = double.Parse(reply);



            do
            {
                Console.WriteLine("Enter the following number ");
                reply = Console.ReadLine();
            }
            while (!double.TryParse(reply, out n1));

            Convert.ToDouble(reply);
            n2 = double.Parse(reply);

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
