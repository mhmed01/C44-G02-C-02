namespace Seeions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1-Write a program that allows the user to enter a number then print it.



            Console.Write("Enter a number: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine ( "The Number Is " + X );

            #endregion

            #region Q2-Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string Z = "111aww";
            int Y = int.Parse(Z);
            Console.WriteLine(Y);

            // int.Parse can't convert non-numeric characters.
            #endregion

            #region Q3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float A = 5.3F;
            float B = 2.1F;
            float result = A + B;
            Console.WriteLine("A + B = " + result)
            #endregion

            #region Q4-Write C# program that Extract a substring from a given string.
            string stringg = "I'm Mohamed ";
            string substringg = stringg.Substring(7, 5);
            Console.WriteLine("Substring : " + substringg);
            #endregion

            #region Q5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int a = 2;
            int b = a;
            b = 5;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            #endregion

            #region Q7-Write C# program that take two string variables and print them as one variable 
            string str1 = "I'm";
            string str2 = "Mohamed";
            string res = str1 + " " + str2;
            Console.WriteLine(res);
            #endregion



            #region MCQ
            //8 - a
            //9- d
            //10- d
            #endregion






        }
    }
}
