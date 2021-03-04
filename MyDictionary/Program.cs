using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            do
            {

                {
                    Console.WriteLine("Ekle:1  Veri Bulma :2    Veri Listele:3  Exit:4    ");
                    string secim = Console.ReadLine();
                    if (secim == 1.ToString())
                    {
                        Console.WriteLine("Key No :");
                        int keyNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Değer Girişi :");
                        string value = Console.ReadLine();
                        myDictionary.Add(keyNo, value);
                    }
                    else if (secim == 2.ToString())
                    {
                        Console.WriteLine("Key No :");
                        string keyNo = Console.ReadLine();
                        myDictionary.Show(Convert.ToInt32(keyNo));

                    }

                    else if (secim == 3.ToString())
                    {
                        myDictionary.Listele();
                    }

                }

                Console.WriteLine("Ana Ekran : 1   Exit: 4");

            }
            while (Console.ReadLine() != 4.ToString());


        }
    }
}
