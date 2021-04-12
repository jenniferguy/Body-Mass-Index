using System;

namespace Body_Mass_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARE VARIABLE(S)

            double userWeight = 0.0;
            double userHeight = 0.0;

            //GET INFO FROM USER
            Console.Write(" Enter you weight using pounds ");
            userWeight = double.Parse(Console.ReadLine());

            Console.Write(" Enter your height using inches ");
            userHeight = double.Parse(Console.ReadLine());

            //DISPLAY RESULTS TO USER
            DisplayBodyMassIndex(userWeight, userHeight);

            //HOLD WINDOW OPEN UNTIL A KEY IS PRESSED
            Console.ReadKey();

            //ENTER FUNCTIONS AND CALCULATIONS
         static void DisplayBodyMassIndex(double userWeight, double userHeight){
                double bmi = (userWeight * 703) /  Math.Pow(userHeight,2);
                Console.WriteLine("Your total BMI is {0:F3}", bmi);
         }//END FUNCTION

     }

 }
    
}
