using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Bmi_Calc
{
    class Program
    {
        static void Main(string[] args)
        {

           
                Console.WriteLine("Please enter your height");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your current weight (kg)");
                int weight = Convert.ToInt32(Console.ReadLine());
            
            // float dividedHeight = DivideUserHeight(height);

            float BmiResult = BodyMassIndex(weight, height);

            Console.WriteLine("Your current Bmi = " + BmiResult);
        }

        static float BodyMassIndex(float x,float y)
        {
            y = y / 100;
            y = y * y;
            return x / y;
        }

       /* static float DivideUserHeight(float y)
        {
            y = y / 2;
            return y * y;
        }
       */
    }
}
