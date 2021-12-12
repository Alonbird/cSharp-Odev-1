using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "21";
            int degisken2 = 10;
            // integer'ı string'e çevir.

            string yeniDegisken = degisken1 + degisken2.ToString();
            Console.WriteLine(yeniDegisken);

            string datetime2 = DateTime.Now.ToString("dd*MM*yyyy");
            Console.WriteLine(datetime2);
        }
    }
}
