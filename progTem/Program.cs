using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTem
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade = "  Merhaba programlama dünyası.";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);//uzunluk
            Console.WriteLine(ifade.ToUpper());//ifade büyülterek veriri
            Console.WriteLine(ifade.ToLower());//ifadeti küçülterek verir
            Console.WriteLine(ifade.TrimStart());//baştaki boşlukları keser
            Console.WriteLine(ifade.TrimEnd());//sondaki boşlukları keser
            Console.WriteLine(ifade.Trim());//hem baş hem sondaki karakterleri keser
            Console.WriteLine(ifade[0]);//ilk karakteri gösterir
            Console.WriteLine(ifade[1]);//2. karakteri gösterir
            Console.WriteLine(ifade[ifade.Length-1]);//sonuncu karakteri gösterir



            Console.ReadKey();
        }

        private static void OrtuluDegiskenTanimi()
        {
            string ifade = Console.ReadLine();//readline string ifade döndürür
            //eşitliklerin hem sol tarafı hem sağ tarafı aynı türde olması gerekir
            //örtülü değişken
            var ifade2 = Console.ReadKey();
            //fonksiyon çalıştıktan sonra ifadenin türüne karar verilir
            //readkey ifadenin türünü dönderecek

            ConsoleKeyInfo ifade3 = Console.ReadKey();
            //var yerine yukarıdaki ifadeyi de kullanabliriz

            Console.WriteLine(ifade);
            Console.WriteLine(ifade2.Key);
            Console.WriteLine(ifade2.KeyChar);
        }
    }
}
