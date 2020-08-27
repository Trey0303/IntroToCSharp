using System;
using System.Collections.Generic;
using System.Text;

namespace TypeConversion
{
    class BinaryNumeral
    {
        private int value;

        public BinaryNumeral(int value)
        {
            this.value = value;
        }
        // Declare a conversion from an int to a RomanNumeral. Note the
        // the use of the operator keyword. This is a conversion
        // operator named RomanNumeral:
        static public implicit operator BinaryNumeral(int value)
        {
            // Note that because RomanNumeral is declared as a struct,
            // calling new on the struct merely calls the constructor
            // rather than allocating an object on the heap:
            return new BinaryNumeral(value);
        }
        // Declare an explicit conversion from a RomanNumeral to an int:
        static public explicit operator int(BinaryNumeral binary)
        {
            return binary.value;
        }
        // Declare an implicit conversion from a RomanNumeral to
        // a string:
        static public implicit operator string(BinaryNumeral binary)
        {
            return "";

        }
    }
}
