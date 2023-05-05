using System;
using static System.Console;

namespace ValidID 
{
    class ValidID
    {
        static void Main()
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

                Write("Enter ID number:");
                input = ReadLine();
                idNum = Convert.ToInt32(input);

                while (idNum < LOW || idNum > HIGH)
                {
                    WriteLine("{0} is an invalid ID number", idNum);
                    Write("ID numbers must be");
                    WriteLine("bewteen {0} and {1} inclusive", LOW, HIGH);
                    Write("Enter an ID Number:");
                    input = ReadLine();
                    idNum = Convert.ToInt32(input);
                    

                }


            WriteLine("ID number is {0} is valid", idNum);
            input = ReadLine();
            idNum = Convert.ToInt32(input);
        }
    }
}
