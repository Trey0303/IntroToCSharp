using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral numeral;
            numeral = 10;
            // Call the explicit conversion from numeral to int. Because it is
            // an explicit conversion, a cast must be used:
            Console.WriteLine((int)numeral);
            // Call the implicit conversion to string. Because there is no
            // cast, the implicit conversion to string is the only
            // conversion that is considered:
            Console.WriteLine(numeral);
            // Call the explicit conversion from numeral to int and
            // then the explicit conversion from int to short:
            short s = (short)numeral;
            Console.WriteLine(s);
            Console.ReadKey();

            BinaryNumeral bnumeral;
            numeral = 10;
            // Call the explicit conversion from numeral to int. Because it is
            // an explicit conversion, a cast must be used:
            Console.WriteLine((int)numeral);
            // Call the implicit conversion to string. Because there is no
            // cast, the implicit conversion to string is the only
            // conversion that is considered:
            Console.WriteLine(numeral);
            // Call the explicit conversion from numeral to int and
            // then the explicit conversion from int to short:
            short sb = (short)numeral;
            Console.WriteLine(s);
            Console.ReadKey();

            RomanNumeral roman;
            roman = 10;
            BinaryNumeral binary;
            // Perform a conversion from a RomanNumeral to a
            // BinaryNumeral:
            binary = (BinaryNumeral)(int)roman;
            // Performs a conversion from a BinaryNumeral to a RomanNumeral.
            // No cast is required:
            roman = binary;
            Console.WriteLine((int)binary);
            Console.WriteLine(binary);
            Console.ReadKey();


        }
    }
}
