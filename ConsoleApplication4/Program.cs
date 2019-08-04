using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Havale(banka b, string hesapno, int mikt)
        {
            b.havale(hesapno, mikt);
        }
        static void Main(string[] args)
        {
            akbank akh1 = new akbank();
            akh1.havale("345-12341", 200);

            garanti ghesap1 = new garanti();
            ghesap1.havale("123-32134", 500);

            Havale(akh1,"123123",100);


            Console.Read();
        }
    }
    class banka
    {
        virtual public void havale(string hesapNO, int miktar)
        {
            Console.WriteLine("Ana Sınıf Havale metodu çalıştı");
        }
    }
    class akbank : banka
    {
        override public void havale(string hesapNO, int miktar)
        {
            Console.WriteLine("Akbank havale işlemi yapıldı.");
            smsbilgilendir();
        }
        private void smsbilgilendir()
        {
            Console.WriteLine("Akbank alıcı bilgilendirme sms'i atıldı.");
        }
    }
    class garanti : banka
    {
        override public void havale(string hesapNO, int miktar)
        {
            Console.WriteLine("Garanti havale işlemi yapıldı.");
            epostabilgilendir();
        }
        public void epostabilgilendir()
        {
            Console.WriteLine("Garanti alıcı bilgilendirme e-postası atıldı.");
        }
    }
}
