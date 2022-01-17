using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                 Console.WriteLine("Bir sayı giriniz.");
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }*/
            try
            {
                 //int a = int.Parse(null);
                 //int a = int.Parse("Test");
                 int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.Write(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.Write(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(":ok küçük yada çok büyük değer girdiniz.");
                Console.Write(ex);
            }
        }
    }
}
