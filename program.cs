using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace exproot {
    class Program {
        static void Main(string[] args) {
        
            int[] sayilar = { 2, 3, 5, 7, 11, 13, 17, 19 }; // test için kullanacağımız asal sayılar listesi daha da genişletilebilir.

            int[] sonuclar = new int[sayilar.Length]; // girdiğimiz sayıyı listemizdeki sayılara böldüğümüzde elde ettiğimiz kalan sayılar listesi.

            bool isAsal = false; 

        bas:
        
            Thread.Sleep(2000); 
            Console.Clear();

            Console.WriteLine("sayiyi girin: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++) {

                if (sayilar.Contains(x)) { 

                    Console.WriteLine("asal.");    // girdiğimiz sayının listede olup olmadığını kontrol ediyoruz, eğer listedeyse asal olduğunu söyleyip başa geri dönüyoruz.
                    goto bas;
                    
                } else {
                    sonuclar[i] = x % sayilar[i];  // eğer sayı listemizde yoksa, girilen sayıyı listemizdeki sayılara bölüp kalanları sonuçlar listemize ekliyoruz.
                }

            }


            isAsal = sonuclar.Contains(0); // burada ise sonuçlar listemizde 0 olup olmamasına göre asallığı belirliyoruz.

            if (isAsal) {
                Console.WriteLine("asal değil.");
            }else {
                Console.WriteLine("asal.");
            }




            goto bas; 
            
            
            

            Console.ReadLine();

       }

    }

}
