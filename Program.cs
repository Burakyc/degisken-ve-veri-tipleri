using System;

namespace degisken
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b = 5; // 1 byte
            sbyte  c = 5; // 1 byte

            short  s= 5; // 2 byte
            ushort us =5; // 2 byte

            Int16 i16 = 2; // 2 byte
            int   i=2 ; // 4 byte 
            Int32  i32 =2; // 4 byte
            Int64  i64 =2;  // 8 byte

            uint ui =2 ; // 8 byte
            long  l=4; // 8 byte
            ulong ul = 4; // 8 byte
            
            //reel sayılar
            float  f=5 ; //4 byte
            double  d=5; // 8byte
            decimal  de = 5 ; //16 byte

            char  ch='2';// 2 byte
            string  str="zikriye D" ;  //sınırsız

            bool  b1=true;
            bool b2=false;   

            DateTime dt = DateTime.Now;
            
            Console.WriteLine(dt);

            object o1="x";
            object o2="y";
            object o3=4;
            object o4=4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "zikriye ürkmez";
            string ad = "zikriye";
            String soyad = "ürkmez";
            string TamIsim = ad + " " +soyad;

            // integer tanımlama şekilleri

            int integer1 =5;
            int integer2 =3;
            int integer3 =integer1+integer2;

            // booolen

            bool bool1 = 10>2;

            // değişken dönüşümleri

            string str20="20";
            int int20 =20 ;
            string yenideger = str20+int20.ToString();
            Console.WriteLine(yenideger); // çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //çıktısı 40

            //date time

            string datetime= DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2= DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
