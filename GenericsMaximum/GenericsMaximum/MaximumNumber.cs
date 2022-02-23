using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximum
{
    public class MaximumNumber
    {
             public int MaxNumber(int firstNumber, int secondNumber, int thirdNumber)
            {
                if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                {
                    return firstNumber;
                }
                if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                {
                    return secondNumber;
                }
                return thirdNumber;
            }
        }
}
