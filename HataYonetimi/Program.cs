using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            try
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: "+e.Message.ToString());                
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            */
            try
            {
                //int a = int.Parse(null);

                int a = int.Parse("test");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }

        }
    }
}
