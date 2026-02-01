using System;

namespace Calculadora;

public class ConverterModel
{
    public string ConvertDecimalToBinary(double inputDecimal)
    {
        if (inputDecimal == 0) return "0";

        long wholePart = (long)Math.Truncate(inputDecimal);
        double decimalPart = inputDecimal - wholePart;

        string binaryWhole = "";
        if (wholePart == 0)
        {
            binaryWhole = "0";
        }
        else
        {
            while (wholePart > 0)
            {
                long remainder = wholePart % 2;
                binaryWhole = remainder + binaryWhole;
                wholePart /= 2;
            }
        }

        string binaryDecimal = "";
        if (decimalPart > 0)
        {
            binaryDecimal = ".";
            int maxDigits = 10;
            while (decimalPart > 0 && maxDigits > 0)
            {
                decimalPart *= 2;
                if (decimalPart >= 1)
                {
                    binaryDecimal += "1";
                    decimalPart -= 1;
                }
                else
                {
                    binaryDecimal += "0";
                }
                maxDigits--;
            }
        }

        return binaryWhole + binaryDecimal;
    }

    public string ConvertDecimalToOctal(double inputDecimal)
    {
        if (inputDecimal == 0) return "0";

        long integerPart = (long)Math.Truncate(inputDecimal);
        double decimalPart = inputDecimal - integerPart;

        string octalInteger = "";
        if (integerPart == 0)
        {
            octalInteger = "0";
        }
        else
        {
            while (integerPart > 0)
            {
                long remainder = integerPart % 8;
                octalInteger = remainder + octalInteger;
                integerPart /= 8;
            }
        }

        string octalDecimal = "";
        if (decimalPart > 0)
        {
            octalDecimal = ".";
            int maximumDigits = 10;
            while (decimalPart > 0 && maximumDigits > 0)
            {
                decimalPart *= 8;
                long digit = (long)Math.Truncate(decimalPart);
                octalDecimal += digit;
                decimalPart -= digit;
                maximumDigits--;
            }
        }

        return octalInteger + octalDecimal;
    }

    public string ConvertDecimalToHexadecimal(double inputDecimal)
    {
        if (inputDecimal == 0) return "0";

        long integerPart = (long)Math.Truncate(inputDecimal);
        double decimalPart = inputDecimal - integerPart;
        char[] digitCharacters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        string hexValue = "";
        if (integerPart == 0)
        {
            hexValue = "0";
        }
        else
        {
            while (integerPart > 0)
            {
                long remainder = integerPart % 16;
                hexValue = digitCharacters[remainder] + hexValue;
                integerPart /= 16;
            }
        }


        string hexDecimal = "";
        if (decimalPart > 0)
        {
            hexDecimal = ".";
            int maxDigits = 10;
            while (decimalPart > 0 && maxDigits > 0)
            {
                decimalPart *= 16;
                int digit = (int)Math.Truncate(decimalPart);
                hexDecimal += digitCharacters[digit];
                decimalPart -= digit;
                maxDigits--;
            }
        }

        return hexValue + hexDecimal;
    }
}