using System;

namespace Operators_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");
            // Initializes a integer that multipies two integers
            int intMult = 6 * 45;
            // Initializes an integer that adds to integers
            int intAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. The min of the two is {Math.Min(intMult, intAdd)} "); 

            // initialize boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            //Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than{intAdd}, {isIntGreater}.\n");

            Console.WriteLine("SHORTS");
            // Initializes a short that multipies two shorts
            short shortult = 6 * 45;
            // Initializes an short that adds to shorts
          short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. The min of the two is {Math.Min(shortMult, shortAdd)} ");

            // initialize boolean to see if intMult is greater than intAdd
            bool isshortGreater = shortMult > shortAdd;
            //Prints if intMult is greater than intAdd
            Console.WriteLine($"{shortMult} is greater than{shortAdd}, {isshortGreater}.\n");


            Console.WriteLine("LONG");
            // Initializes a long that multipies two long
            long longMult = 6 * 45;
            // Initializes an long that adds tolongegers
           long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult,longAdd)}. The min of the two is {Math.Min(longMult,longAdd)} ");

            // initialize boolean to see iflongMult is greater thanlongAdd
            bool islongGreater =longMult >longAdd;
            //Prints iflongMult is greater thanlongAdd
            Console.WriteLine($"{longMult} is greater than{longAdd}, {isIntGreater}.\n");


            Console.WriteLine("FLOATS");
            // Initializes a float that multipies two float
            float floatMult = 6.5f * 45.25f;
            // Initializes an float that adds to float
            float floatAdd = 55.35f + 66.15f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. The min of the two is {Math.Min(floatMult, floatAdd)} ");

            // initialize boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            //Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than{floatAdd}, {isfloatGreater}.\n");


            Console.WriteLine("DOUBLES");
            // Initializes a double that multipies two double
            double doubleMult = 6.69 * 45.50;
            // Initializes an double that adds to double
            double doubleAdd = 55.38 + 66.15;
            // Prints the maximum and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. The min of the two is {Math.Min(doubleMult, doubleAdd)} ");

            // initialize boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            //Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than{doubleAdd}, {isdoubleGreater}.\n");


            Console.WriteLine("DECIMLES");
            // Initializes a decimale that multipies two decimale
            decimal decimalMult = (decimal)(6.25 * 45.15);
            // Initializes an decimale that adds to decimaleg
            decimal decimalAdd =(decimal)(55.66 + 66.55);
            // Prints the maximum and minimum of the two decimaleger variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. The min of the two is {Math.Min(decimalMult, decimalAdd)} ");

            // initialize boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            //Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than{decimalAdd}, {isdecimalGreater}.");

        }
    }
}
