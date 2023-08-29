using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cep_telefon_numarası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrana gireceğiniz sayıya 0 ile başlayıp içerisinde rakam dışında hiçbirşey kullanmayın");
            Console.ReadKey();
            Console.Clear();
            string sayi = Console.ReadLine();
            string numara = sayi.Substring(0, 11);
            //ekrandan telefon numarası olarak sayi adlı veriyi okur ve sayının ilk 11 basamağını alır
            if (numara.Substring(0, 1) == "5")
            {
                Console.WriteLine("bu numara bir cep telefonuna ait");
            }
            //burada eğer numaranın ilk iki hanesi 05 ile başlıyorsa ekrana 18. satırda tırnak işareti içerisindeki cümleyi ekrana yazar
            if (!(numara.Substring(0, 2) == "05"))
            {
                Console.WriteLine("bu bir telefon numarası değildir ");
            }
            //burada ise ilk iki hanesi 05 değil ise 23. satırda tırnak işareti içerisindeki cümleyi ekrana yazar
            Console.ReadKey();

        }
    }
}
