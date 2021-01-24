using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList();

            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
            Console.WriteLine("Kütüphaneye Ekelem İçin Değer ve Anahtar Giriniz");
            Console.ReadLine();
            dictionary.Add("Anahtar1", 10);
            dictionary.Add("Anahtar2", 30);
            Console.WriteLine(dictionary.GetValue("Anahtar1"));
            Console.WriteLine(dictionary.GetValue("Anahtar2"));
            Console.WriteLine(dictionary.GetKey(10));
            Console.WriteLine(dictionary.GetKey(30));

        }

        private static void MyList()
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("BERKAY"); // : )

            Console.WriteLine("Hello World!");
        }
    }
}
