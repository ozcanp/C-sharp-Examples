

using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Birininci sayiyi giriniz : ");
            int number1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Birininci sayiyi giriniz : ");
            int number2 = Convert.ToInt32(System.Console.ReadLine());

            if (number1>number2)
            {
                Console.WriteLine("Sayi 1 sayi 2 den buyuktur");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Sayi 2 sayi 1 den buyuktur");
            }
            else if (number1 == number2)
            {
                Console.WriteLine("Birbirlerine esitlerdir.");
            }
            Console.ReadLine();




            /*Console.WriteLine("Lutfen bir sayi giriniz :");
            int number = Convert.ToInt32(System.Console.ReadLine());
            if (number>0 )
            {
                Console.WriteLine("Sayi pozitiftir");
            }else if (number < 0)
            {
                Console.WriteLine("Sayi negatifir");
            }
            else
            {
                Console.WriteLine("Sayi = 0 dir ");
            }
            Console.ReadKey();
            */




            /* Console.WriteLine("Lutfen sayi giriniz : ");
            int number = Convert.ToInt32(System.Console.ReadLine());
            int sonuc;
            double karekok;
          
            Console.WriteLine("1=)karekok \n2=)kup\n3=)karesi\nBir islem seciniz : ");
            int secim = Convert.ToInt32(System.Console.ReadLine());
            if (secim == 1)
            {
                karekok = Math.Sqrt(number);
                Console.WriteLine("Sonuc :"+karekok);
            }else if (secim == 2)
            {
                sonuc = number * number * number;
                Console.WriteLine("Sonuc :" + sonuc);
            }else if(secim == 3)
            {
                sonuc = number * number;
                Console.WriteLine("Sonuc : "+sonuc);
            }
            Console.ReadKey();
            */











            /*Console.WriteLine("Sayi giriniz : ");
            int number1=Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("ikinci sayiyi giriniz : ");
            int number2= Convert.ToInt32(System.Console.ReadLine()); ;

            if (number1 % 2 == 0)
            {
                Console.WriteLine(" tam bolunuyor.");
            }
            else
            {
                Console.WriteLine(" tam bolunmuyor.");
            }
            Console.ReadKey();
            */






            /*
            Console.WriteLine("Sayi giriniz : ");
            int sayi = Convert.ToInt32(System.Console.ReadLine());
            int sonuc;
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayi ciftir.");
                sonuc = sayi / 2;

            }
            else
            {
                Console.WriteLine("Sayi tektir.");
                sonuc= sayi * 2;
            }
            Console.WriteLine("Sonuc : " + sonuc);
            Console.ReadKey();
           */






            /*
            Console.WriteLine("Lutfen bir sayi giriniz :");
            int sayi = Convert.ToInt16(System.Console.ReadLine());
            
            if (sayi %2 == 0 )
            {
                Console.WriteLine("Sayi ciftir.");
            }
            else
            {
                Console.WriteLine("Sayi tektir.");
            }
            Console.ReadKey();
        */
        }
    }
}


