using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Sayi1 = new Random();
            Random Sayi2 = new Random();
            Random Sayi3 = new Random();
            Random Sayi4 = new Random();

            int Oyuncu1 = 0;
            int Oyuncu2 = 0;
            int Oyuncu3 = 0;
            int Oyuncu4 = 0;
            for (int i = 0; i < 25; i++)
            {
                int rndmsayi1 = Sayi1.Next(1, 7);
                int rndmsayi2 = Sayi2.Next(1, 7);
                int rndmsayi3 = Sayi3.Next(1, 7);
                int rndmsayi4 = Sayi4.Next(1, 7);
                Console.WriteLine(rndmsayi1 +","+ rndmsayi2 + "," + rndmsayi3 + "," + rndmsayi4);

                if (rndmsayi1==rndmsayi2 && rndmsayi1==rndmsayi3 && rndmsayi1==rndmsayi4)
                {
                    Oyuncu1 += 100;
                }
                else if (rndmsayi1==rndmsayi2 && rndmsayi1==rndmsayi3 || rndmsayi1==rndmsayi2 && rndmsayi1==rndmsayi4 || 
                    rndmsayi1==rndmsayi3 && rndmsayi1==rndmsayi4 || rndmsayi2==rndmsayi3 && rndmsayi2==rndmsayi4)
                {
                    Oyuncu1 += 50;
                }
                else if (rndmsayi1==rndmsayi2 || rndmsayi1==rndmsayi3 || rndmsayi1==rndmsayi4 || rndmsayi2==rndmsayi3 || rndmsayi2==rndmsayi4 || rndmsayi3==rndmsayi4)
                {
                    Oyuncu1 += 20;
                }
                else
                {
                }
                Console.WriteLine(Oyuncu1);
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < 25; i++)
            {
                int rndmsayi1 = Sayi1.Next(1, 7);
                int rndmsayi2 = Sayi2.Next(1, 7);
                int rndmsayi3 = Sayi3.Next(1, 7);
                int rndmsayi4 = Sayi4.Next(1, 7);
                Console.WriteLine(rndmsayi1 + "," + rndmsayi2 + "," + rndmsayi3 + "," + rndmsayi4);

                if (rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi3 && rndmsayi1 == rndmsayi4)
                {
                    Oyuncu2 += 100;
                }
                else if (rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi3 || rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi4 ||
                    rndmsayi1 == rndmsayi3 && rndmsayi1 == rndmsayi4 || rndmsayi2 == rndmsayi3 && rndmsayi2 == rndmsayi4)
                {
                    Oyuncu2 += 50;
                }
                else if (rndmsayi1 == rndmsayi2 || rndmsayi1 == rndmsayi3 || rndmsayi1 == rndmsayi4 || rndmsayi2 == rndmsayi3 || rndmsayi2 == rndmsayi4 || rndmsayi3 == rndmsayi4)
                {
                    Oyuncu2 += 20;
                }
                else
                {
                }
                Console.WriteLine(Oyuncu2);
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < 25; i++)
            {
                int rndmsayi1 = Sayi1.Next(1, 7);
                int rndmsayi2 = Sayi2.Next(1, 7);
                int rndmsayi3 = Sayi3.Next(1, 7);
                int rndmsayi4 = Sayi4.Next(1, 7);
                Console.WriteLine(rndmsayi1 + "," + rndmsayi2 + "," + rndmsayi3 + "," + rndmsayi4);

                if (rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi3 && rndmsayi1 == rndmsayi4)
                {
                    Oyuncu3 += 100;
                }
                else if (rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi3 || rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi4 ||
                    rndmsayi1 == rndmsayi3 && rndmsayi1 == rndmsayi4 || rndmsayi2 == rndmsayi3 && rndmsayi2 == rndmsayi4)
                {
                    Oyuncu3 += 50;
                }
                else if (rndmsayi1 == rndmsayi2 || rndmsayi1 == rndmsayi3 || rndmsayi1 == rndmsayi4 || rndmsayi2 == rndmsayi3 || rndmsayi2 == rndmsayi4 || rndmsayi3 == rndmsayi4)
                {
                    Oyuncu3 += 20;
                }
                else
                {
                }
                Console.WriteLine(Oyuncu3);
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < 25; i++)
            {
                int rndmsayi1 = Sayi1.Next(1, 7);
                int rndmsayi2 = Sayi2.Next(1, 7);
                int rndmsayi3 = Sayi3.Next(1, 7);
                int rndmsayi4 = Sayi4.Next(1, 7);
                Console.WriteLine(rndmsayi1 + "," + rndmsayi2 + "," + rndmsayi3 + "," + rndmsayi4);

                if (rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi3 && rndmsayi1 == rndmsayi4)
                {
                    Oyuncu4 += 100;
                }
                else if (rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi3 || rndmsayi1 == rndmsayi2 && rndmsayi1 == rndmsayi4 ||
                    rndmsayi1 == rndmsayi3 && rndmsayi1 == rndmsayi4 || rndmsayi2 == rndmsayi3 && rndmsayi2 == rndmsayi4)
                {
                    Oyuncu4 += 50;
                }
                else if (rndmsayi1 == rndmsayi2 || rndmsayi1 == rndmsayi3 || rndmsayi1 == rndmsayi4 || rndmsayi2 == rndmsayi3 || rndmsayi2 == rndmsayi4 || rndmsayi3 == rndmsayi4)
                {
                    Oyuncu4 += 20;
                }
                else
                {
                }
                Console.WriteLine(Oyuncu4);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Oyuncu1 :" + Oyuncu1 + "\nOyuncu2 :" + Oyuncu2 + "\nOyuncu3 :" + Oyuncu3 + "\nOyuncu4 :" + Oyuncu4);
            if (Oyuncu1>Oyuncu2 && Oyuncu1>Oyuncu3 && Oyuncu1>Oyuncu4)
            {
                Console.WriteLine("Oyuncu1 Kazandı!\n1. Oyuncu1");
            }
            else if (Oyuncu2 > Oyuncu1 && Oyuncu2 > Oyuncu3 && Oyuncu2 > Oyuncu4)
            {
                Console.WriteLine("Oyuncu2 Kazandı!\n1. Oyuncu2");
            }
            else if (Oyuncu3 > Oyuncu1 && Oyuncu3 > Oyuncu2 && Oyuncu3 > Oyuncu4)
            {
                Console.WriteLine("Oyuncu3 Kazandı!\n1. Oyuncu3");
            }
            else
            {
                Console.WriteLine("Oyuncu4 Kazandı!\n1. Oyuncu4");
            }

           
            if (Oyuncu1>Oyuncu2 && Oyuncu1>Oyuncu3 && Oyuncu1<Oyuncu4 || Oyuncu1 > Oyuncu2 && Oyuncu1 > Oyuncu4 && Oyuncu1 < Oyuncu3 || Oyuncu1 > Oyuncu3 && Oyuncu1 > Oyuncu4 && Oyuncu1 < Oyuncu2)
            {
                Console.WriteLine("2. Oyuncu1");
            }
            else if (Oyuncu2 > Oyuncu1 && Oyuncu2 > Oyuncu3 && Oyuncu2 < Oyuncu4 || Oyuncu2 > Oyuncu1 && Oyuncu2 > Oyuncu4 && Oyuncu2 < Oyuncu3 || Oyuncu2 > Oyuncu3 && Oyuncu2 > Oyuncu4 && Oyuncu2 < Oyuncu1)
            {
                Console.WriteLine("2. Oyuncu2");
            }
            else if (Oyuncu3 > Oyuncu2 && Oyuncu3 > Oyuncu1 && Oyuncu3 < Oyuncu4 || Oyuncu3 > Oyuncu2 && Oyuncu3 > Oyuncu4 && Oyuncu3 < Oyuncu1 || Oyuncu3 > Oyuncu1 && Oyuncu3 > Oyuncu4 && Oyuncu3 < Oyuncu2)
            {
                Console.WriteLine("2. Oyuncu3");
            }
            else
            {
                Console.WriteLine("2. Oyuncu4");
            }


            if (Oyuncu1<Oyuncu2 && Oyuncu1<Oyuncu3 && Oyuncu1>Oyuncu4 || Oyuncu1 < Oyuncu2 && Oyuncu1 < Oyuncu4 && Oyuncu1 > Oyuncu3 || Oyuncu1 < Oyuncu3 && Oyuncu1 < Oyuncu4 && Oyuncu1 > Oyuncu2)
            {
                Console.WriteLine("3. Oyuncu1");
            }
            else if (Oyuncu2 < Oyuncu1 && Oyuncu2 < Oyuncu3 && Oyuncu2 > Oyuncu4 || Oyuncu2 < Oyuncu1 && Oyuncu2 < Oyuncu4 && Oyuncu2 > Oyuncu3 || Oyuncu2 < Oyuncu3 && Oyuncu2 < Oyuncu4 && Oyuncu2 > Oyuncu1)
            {
                Console.WriteLine("3. Oyuncu2");
            }
            else if (Oyuncu3 < Oyuncu1 && Oyuncu3 < Oyuncu2 && Oyuncu3 > Oyuncu4 || Oyuncu3 < Oyuncu1 && Oyuncu3 < Oyuncu4 && Oyuncu3 > Oyuncu2 || Oyuncu3 < Oyuncu2 && Oyuncu3 < Oyuncu4 && Oyuncu3 > Oyuncu1)
            {
                Console.WriteLine("3. Oyuncu3");
            }
            else
            {
                Console.WriteLine("3. Oyuncu4");
            }


        }
    }
}