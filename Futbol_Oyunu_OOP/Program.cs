using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Oyunu_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Futbol> takim = new List<Futbol>();
            takim.Add(new Futbol    ("Kaleci"   , 1));
            takim.Add(new Defans    ("Defans1"  , 2));
            takim.Add(new Defans    ("Defans2"  , 3));
            takim.Add(new Defans    ("Defans3"  , 4));
            takim.Add(new Defans    ("Defans4"  , 5));
            takim.Add(new OrtaSaha  ("OrtaSaha1", 6));
            takim.Add(new OrtaSaha  ("OrtaSaha2", 7));
            takim.Add(new OrtaSaha  ("OrtaSaha3", 8));
            takim.Add(new OrtaSaha  ("OrtaSaha4", 9));
            takim.Add(new Forvet    ("Forvet1"  , 10));
            takim.Add(new Forvet    ("Forvet2"  , 11));

            Random rastgele = new Random();

            int formaNo = rastgele.Next(1,12);
            int pasKontrol = 12;
            bool golOlabilir = true;

            for (int i = 1; i < 4; i++)
            {
                while(pasKontrol == formaNo)
                {
                    formaNo = rastgele.Next(1, 12);
                }
                pasKontrol = formaNo;

                if (i == 3)
                {
                    if (!takim[formaNo - 1].PasVer())
                    {
                        Console.WriteLine(formaNo + " Numarali oyuncu kaleci ile karsi karsiya");
                        golOlabilir = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(formaNo + " Numarali oyuncu topu kontrol edemedi");
                        golOlabilir = false;
                    }
                }
                else
                {
                    if (!takim[formaNo - 1].PasVer())
                    {
                        Console.WriteLine(formaNo + " Numarali oyuncunun pasi basarisiz");
                        golOlabilir = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(formaNo + " Numarali oyuncunun pasi tam isabet");
                    }
                }

            }

            if (golOlabilir == true)
            {
                if (takim[formaNo-1].GolVurusu())
                {
                    Console.WriteLine(formaNo + " Numarali oyuncu gol atti");
                }
                else
                {
                    Console.WriteLine(formaNo + " Numarali oyuncu avuta atti");
                }
            }

            Console.WriteLine();
        }
    }
}
