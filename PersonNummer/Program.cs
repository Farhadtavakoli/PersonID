using System;
using System.Collections.Generic;


namespace PersonNummer
{
    class Program
    {
        static void Main(string[] args)
        {
            string PersonNummer;
            List<string> DigitSaving = new List<string>();
            List<string> DigitAdding = new List<string>();

            Console.Write("Ange personnummer: ");
            PersonNummer = Console.ReadLine();
           
            for (int i = 0; i < PersonNummer.Length; i++)
            {
                DigitSaving.Add(Convert.ToString((PersonNummer[i])));
            }

            int Multiply;
            int sum = 0;
            for (int i = 0; i < DigitSaving.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Multiply = ((Convert.ToInt32(DigitSaving[i]) * 2));
                    DigitAdding.Add(Convert.ToString(Multiply / 10));
                    DigitAdding.Add(Convert.ToString(Multiply % 10));
                    Multiply = 0;

                }
                else
                {
                    Multiply = ((Convert.ToInt32(DigitSaving[i])*1));
                    DigitAdding.Add(Convert.ToString(Multiply/ 10));
                    DigitAdding.Add(Convert.ToString(Multiply % 10));
                    Multiply = 0;

                }

            }
            Console.WriteLine();

            sum = 0;
            for (int i = 0; i < DigitAdding.Count; i++)
            {
                sum += Convert.ToInt32(DigitAdding[i]);

            }
            Console.WriteLine();

            int x = 0;
            x = ((10 - (sum % 10)) % 10);
            Console.WriteLine(x + " " + PersonNummer[9]);


            if ( Convert.ToString( x)== ( Convert.ToString( PersonNummer[9])))
            {
                Console.WriteLine("Giltig");
            }
            else
            {
                Console.WriteLine("Ogiltig eller fel !!!");
            }



            Console.ReadKey();


           
        }



    }
}
