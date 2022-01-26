using System;

namespace WissenOdev
{
    class Program
    {

        static void Main(string[] args)
        {
            string myInput;
            Console.Write("Lütfen aşağıdaki zorluk seviyelerinden birisni seçiniz : \n" +
            "1. Kolay seviye için 1'i tuşlayın\n" +
            "2. Orta seviye için 2'i tuşlayın\n" +
            "3. Zor seviye için 3'i tuşlayın\n");
            myInput = Console.ReadLine();

            switch (myInput)
            {
                case "1":
                    Random rnd = new Random();
                    int pcSayi = rnd.Next(0, 10);
                    int sayac = 0;
                    while (true)
                    {
                        Console.Write("Sayı giriniz: ");
                        int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
                        sayac++;
                        if (kullaniciSayi == pcSayi)
                        {
                            Console.WriteLine("Tebrikler!! " + pcSayi + " doğru tahmin!");
                            Console.WriteLine("Oyunu {0}.tahminde bitirdiniz", sayac);
                            Console.WriteLine("Çıkmak için E/e tuşuna basın");
                            char cevap = Convert.ToChar(Console.ReadLine());
                            if (cevap == 'e' || cevap == 'E')
                            {
                                break;
                            }

                            sayac = 0;
                            pcSayi = rnd.Next(0, 100);
                        }
                        else if (kullaniciSayi > pcSayi)
                        {
                            Console.WriteLine("Daha küçük bir sayı girin");
                        }
                        else
                        {
                            Console.WriteLine("Daha büyük bir sayı girin");
                        }
                    }


                    




                    break;

                    case "2":
                    Random rnd2 = new Random();
                    int pcSayi2 = rnd2.Next(0, 100);
                    int sayac2 = 0;
                    while (true)
                    {
                        Console.Write("Sayı giriniz: ");
                        int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
                        sayac2++;
                        if (kullaniciSayi == pcSayi2)
                        {
                            Console.WriteLine("Tebrikler!! " + pcSayi2 + " doğru tahmin!");
                            Console.WriteLine("Oyunu {0}.tahminde bitirdiniz", sayac2);
                            Console.WriteLine("Çıkmak için E/e tuşuna basın");
                            char cevap = Convert.ToChar(Console.ReadLine());
                            if (cevap == 'e' || cevap == 'E')
                            {
                                break;
                            }

                            sayac = 0;
                            pcSayi = rnd2.Next(0, 100);
                        }
                        else if (kullaniciSayi > pcSayi2)
                        {
                            Console.WriteLine("Daha küçük bir sayı girin");
                        }
                        else
                        {
                            Console.WriteLine("Daha büyük bir sayı girin");
                        }
                    }

                    break;


                case "3":
                    Random rnd3 = new Random();
                    int pcSayi3 = rnd3.Next(0, 1000);
                    int sayac3 = 0;
                    while (true)
                    {
                        Console.Write("Sayı giriniz: ");
                        int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
                        sayac3++;
                        if (kullaniciSayi == pcSayi3)
                        {
                            Console.WriteLine("Tebrikler!! " + pcSayi3 + " doğru tahmin!");
                            Console.WriteLine("Oyunu {0}.tahminde bitirdiniz", sayac3);
                            Console.WriteLine("Çıkmak için E/e tuşuna basın");
                            char cevap = Convert.ToChar(Console.ReadLine());
                            if (cevap == 'e' || cevap == 'E')
                            {
                                break;
                            }

                            sayac = 0;
                            pcSayi = rnd3.Next(0, 100);
                        }
                        else if (kullaniciSayi > pcSayi3)
                        {
                            Console.WriteLine("Daha küçük bir sayı girin");
                        }
                        else
                        {
                            Console.WriteLine("Daha büyük bir sayı girin");
                        }
                    }
                    break;
                    
            }

        }
    }
}
        
   