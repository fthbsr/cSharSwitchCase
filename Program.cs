using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = DateTime.Now.Day;
            double sonuc = day / 7;
            Console.WriteLine(Math.Floor(sonuc));
            int month = DateTime.Now.Month;
            
            switch(sonuc)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
               
               Console.WriteLine("Hafta ici gunlerindesiniz");
               break;

               case 6:
               case 7:

               Console.WriteLine("Hafta sonu gunlerindesiniz");
               break;

            }

            switch(month)
            {
                case 12 :
                case 1 :
                case 2 :
                    Console.WriteLine("Kis Ayindasiniz:");
                    break;

                case 3 :
                case 4 :
                case 5 :
                    Console.WriteLine("Ilkbahar Ayindasiniz:");
                    break;

                case 6 :
                case 7 :
                case 8 :
                    Console.WriteLine("Yaz Ayindasiniz:");
                    break;

                case 9 :
                case 10 :
                case 11 :
                    Console.WriteLine("Sonbahar Ayindasiniz:");
                    break;

                   default: 
                    Console.WriteLine("Ay Giriniz :");
                    break;
            }
        }
    }
}