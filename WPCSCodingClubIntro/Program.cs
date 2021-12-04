    public static class Program
    {
        public static void Main(string[] args)
        {
        //Console.WriteLine("Hello, World!");

        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Hello, " + name + "!");

        //if(name == "Andrew")
        //{
        //    Console.WriteLine("Welcome");
        //}
        //else
        //{
        //    Console.WriteLine("Go away!");
        //}

        //int integers; //Whole Numbers
        //string strings; //Words and Sentences
        //double decimals; //Decimal numbers

        //double number1 = 3;
        //double number2 = 2;
        //double result = number1 / number2;
        //Console.WriteLine(result);

        //string number3 = "123";
        //int number3parsed = Int32.Parse(number3);
        //int number3again = 123;
        //int number4 = 123;
        //int result2 = number3parsed / number4;

        int integers = 1; //Variable Declaration
        integers = 2;

        Console.WriteLine("1. Add \n" +
            "2. Subtract");
        string result = Console.ReadLine();
        int selection = int.Parse(result);

        if(selection == 1)
        {
            Console.WriteLine("Adding!");
        }
        else if(selection == 2)
        {
            Console.WriteLine("Subtracting!");
        }

       




    }
}
