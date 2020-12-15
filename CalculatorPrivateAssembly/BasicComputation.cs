using System;

namespace CalculatorPrivateAssembly
{
    public delegate float getTotal(float x, float y);
    public class BasicComputation
    {
        public static float Addition(float Num1, float Num2)
        {
            float answer = Num1 + Num2;
            return answer;
        }
        public static float Substraction(float Num1, float Num2)
        {
            float answer = Num1 - Num2;
            return answer;
        }
        public static float Multiplication(float Num1, float Num2)
        {
            float answer = Num1 * Num2;
            return answer;
        }
        public static float Division(float Num1, float Num2)
        {
            float answer = Num1 / Num2;
            return answer;
        }
    }
}
