    public static class Program
    {
        public static void Main(string[] args)
        {
        //Your first program! Console.WriteLine() prints to the console
        Console.WriteLine("Hello, World!");

        //Console.ReadLine() reads in a string (words) into your program
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        //Conditionals are what you use to direct what happens if certain things happen.
        //i.e. if (this thing is true) { do this}
        if (name == "Andrew")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Go away!");
        }

        //The three main basic data types you should know. There are more you'll learn in the future!
        int integers; //Whole Numbers
        string strings; //Words and Sentences
        double decimals; //Decimal numbers

        //Doubles print fractions. Integers drop the decimal point if you have one
        double number1 = 3;
        double number2 = 2;
        double result = number1 / number2;
        Console.WriteLine(result);

        //Even though number3 and number4 have the same data, it is not a compatible data type
        //i.e you can't divide a number by a word, so we have to parse (or convert) the variable
        string number3 = "123";
        int number3parsed = Int32.Parse(number3);
        int number3again = 123;
        int number4 = 123;
        int result2 = number3parsed / number4;

        int anInteger = 1; //Variable Declaration and assignment
        integers = 2; //Variable reassignment

        //use the \n character to print a new line on the console
        Console.WriteLine("1. Add \n" +
            "2. Subtract");
        string userresult = Console.ReadLine();
        int selection = int.Parse(userresult);

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
