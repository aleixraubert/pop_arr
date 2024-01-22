using System;

namespace pop_arr
{
    class Program
    {
        public static void Main()
        {
            const string Msg_Day = "Introdueix el dia: ";
            const string Msg_month = "Introdueix el mes: ";
            const string Msg_year = "Introdueix l'any: ";
            const string Msg_Error = "El format no és correcte";
            const string Msg_Correct = "La data és correcta";

            int dia, mes, any;

            Console.WriteLine(Msg_Day);
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Msg_month);
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Msg_year);
            any = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(valida(dia, mes, any) ? Msg_Correct : Msg_Error);
        }

        public static bool valida(int day, int month, int year)
        {

            if (day < 1 || day > 31)

                return false;

            if (month < 1 || month > 12)

                return false;

            // determinem la quantitat de dies del mes:

            int totalDaysMonth = 0;

            switch (month)
            {

                case 1:

                case 3:

                case 5:

                case 7:

                case 8:

                case 10:

                case 12: totalDaysMonth = 31; 
                    break;

                case 4:

                case 6:

                case 9:

                case 11: totalDaysMonth = 30; 
                    break;

                case 2: // verifica l'any de traspàs

                    if ((year % 400 == 0) ||

                    ((year % 4 == 0) && (year % 100 != 0)))
                        totalDaysMonth = 29;

                    else totalDaysMonth = 28;

                    break;

            }

            if (day > totalDaysMonth)

                return false;

            else return true;

        }
    }
}