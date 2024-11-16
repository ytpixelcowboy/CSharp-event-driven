using System.Runtime.InteropServices;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public float Addition(float num1, float num2)
        {
            return num1 + num2;
        }

        public  float Subtraction(float num1, float num2)
        {
            return (num1 - num2);
        }

        public float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }

        public float Division(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
