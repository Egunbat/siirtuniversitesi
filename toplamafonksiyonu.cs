using System;
namespace toplama
{
 class ToplamaFonksiyonu
 {
   public static int topla(int a,int b)
   {
      int toplam = a+b; 
      return toplam;
   }
   
   public static void Main(string[] args)
   {
     int x = topla(10,20);
     Console.WriteLine(x);
   }
 }
}
