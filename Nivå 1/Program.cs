using System;

namespace Nivå_1
{
    class Program
    {

        static bool IsDigit(string PersonID)
        {
            bool Valid;
            long ID;

            Console.WriteLine("---- "+PersonID);
           Valid= Int64.TryParse(PersonID, out ID);
          //  Valid = int.TryParse(PersonID, out ID);
            if(Valid==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static bool Validation(string UserInput)
        {

            string PersonID;
            if (UserInput.Length == 11)
            {
               
                
                
                
                if ((UserInput[6] == '+' || UserInput[6] == '-' || UserInput[6] == ' '))
                {
                    UserInput = (UserInput.Remove(6, 1));
                    Console.WriteLine(UserInput);
                    if (IsDigit(UserInput) && YearCheck() && MonthCheck() && DayCheck())
                    {
                        return true;
                    } 
                }
                else
                    return false;
            }
            else
            if (UserInput.Length == 13 && (UserInput[8] == '+' || UserInput[8] == '-' || UserInput[8]==' '))
            {
                PersonID = (UserInput.Remove(8, 1));
                Console.WriteLine(UserInput);
                if (IsDigit(PersonID)   && YearCheck() && MonthCheck() && DayCheck()  )
                {
                    return true;
                }
                else
                    return false;

            }
            else
            if(UserInput.Length==12)
            {
                if (IsDigit(UserInput) && YearCheck() && MonthCheck() && DayCheck())
                {
                    return true;
                }
                else
                    return false;

            }
            return false;

        }




        static bool YearCheck()
        {
            return true;
        }

        static bool MonthCheck()
        {
            return true;

        }
        static bool DayCheck()
        {
            return true;
        }

        static void Main(string[] args)
        {
            string UserInput;


            Console.Write("Ange personnummer: ");
            UserInput = Console.ReadLine();

            
            if (Validation(UserInput))
            {
                Console.WriteLine("Giltig Personnummer");
               // Console.WriteLine(UserInput);
            }
            else
            {
                Console.WriteLine("Ogiltig Personnummer!!!");
                //Console.WriteLine(UserInput);

            }

            Console.ReadKey();







        }
    }
}
