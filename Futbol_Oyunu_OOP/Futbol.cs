using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Oyunu_OOP
{
    class Futbol
    {
        public Random RastgeleSayi = new Random();

        protected string AdSoyad;
        protected int FormaNo;
        protected int Hiz;
        protected int Dayaniklilik;
        protected int Pas;
        protected int Sut;
        protected int Yetenek;
        protected int Kararlilik;
        protected int DogalForm;
        protected int Sans;

        public Futbol(string AdSoyad, int FormaNo)
        {
            Hiz             = RastgeleSayi.Next(50, 100);
            Dayaniklilik    = RastgeleSayi.Next(50, 100);
            Pas             = RastgeleSayi.Next(50, 100);
            Sut             = RastgeleSayi.Next(50, 100);
            Yetenek         = RastgeleSayi.Next(50, 100);
            Kararlilik      = RastgeleSayi.Next(50, 100);
            DogalForm       = RastgeleSayi.Next(50, 100);
            Sans            = RastgeleSayi.Next(50, 100);
        }

        public Futbol()
        {

        }

        public virtual bool PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3
                                          + Dayaniklilik * 0.1
                                          + DogalForm * 0.1
                                          + Sans * 0.2);

            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3
                                               + Sut * 0.2
                                               + Kararlilik * 0.1
                                               + DogalForm * 0.1
                                               + Hiz * 0.1
                                               + Sans * 0.2);

            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Defans: Futbol
    {
        private int PozisyonAlma;
        private int Kafa;
        private int Sicrama;

        public Defans(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;

            Hiz             = RastgeleSayi.Next(50, 90);
            Dayaniklilik    = RastgeleSayi.Next(50, 90);
            Pas             = RastgeleSayi.Next(50, 90);
            Sut             = RastgeleSayi.Next(50, 90);
            Yetenek         = RastgeleSayi.Next(50, 90);
            Kararlilik      = RastgeleSayi.Next(50, 90);
            DogalForm       = RastgeleSayi.Next(50, 90);
            Sans            = RastgeleSayi.Next(50, 90);

            PozisyonAlma    = RastgeleSayi.Next(50, 90);
            Kafa            = RastgeleSayi.Next(50, 90);
            Sicrama         = RastgeleSayi.Next(50, 90);
        }

        public override bool PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3
                                          + Yetenek * 0.3
                                          + Dayaniklilik * 0.1
                                          + PozisyonAlma * 0.1
                                          + Sans * 0.2);

            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3
                                          + Sut * 0.2
                                          + Kararlilik * 0.1
                                          + DogalForm * 0.1
                                          + Kafa * 0.1
                                          + Sicrama * 0.1
                                          + Sans * 0.1);

            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class OrtaSaha: Futbol
    {
        private int UzunTop;
        private int IlkDokunus;
        private int Uretkenlik;
        private int TopSurme;
        private int OzelYetenek;

        public OrtaSaha(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;

            Hiz             = RastgeleSayi.Next(60, 90);
            Dayaniklilik    = RastgeleSayi.Next(60, 90);
            Pas             = RastgeleSayi.Next(60, 90);
            Sut             = RastgeleSayi.Next(60, 90);
            Yetenek         = RastgeleSayi.Next(60, 90);
            Kararlilik      = RastgeleSayi.Next(60, 90);
            DogalForm       = RastgeleSayi.Next(60, 90);
            Sans            = RastgeleSayi.Next(60, 90);

            UzunTop         = RastgeleSayi.Next(60, 90);
            IlkDokunus      = RastgeleSayi.Next(60, 90);
            Uretkenlik      = RastgeleSayi.Next(60, 90);
            TopSurme        = RastgeleSayi.Next(60, 90);
            OzelYetenek     = RastgeleSayi.Next(60, 90);
        }

        public override bool PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3
                                          + Yetenek * 0.2
                                          + OzelYetenek * 0.2
                                          + Dayaniklilik * 0.1
                                          + DogalForm * 0.1
                                          + UzunTop * 0.1
                                          + TopSurme * 0.1
                                          + Sans * 0.1);

            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3
                                          + OzelYetenek * 0.2
                                          + Sut * 0.2
                                          + IlkDokunus * 0.1
                                          + Kararlilik * 0.1
                                          + DogalForm * 0.1
                                          + Sans * 0.2);

            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Forvet: Futbol
    {
        private int Bitiricilik;
        private int IlkDokunus;
        private int Kafa;
        private int OzelYetenek;
        private int SogukKanlilik;

        public Forvet(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;

            Hiz             = RastgeleSayi.Next(70, 100);
            Dayaniklilik    = RastgeleSayi.Next(70, 100);
            Pas             = RastgeleSayi.Next(70, 100);
            Sut             = RastgeleSayi.Next(70, 100);
            Yetenek         = RastgeleSayi.Next(70, 100);
            Kararlilik      = RastgeleSayi.Next(70, 100);
            DogalForm       = RastgeleSayi.Next(70, 100);
            Sans            = RastgeleSayi.Next(70, 100);

            Bitiricilik     = RastgeleSayi.Next(70, 100);
            IlkDokunus      = RastgeleSayi.Next(70, 100);
            Kafa            = RastgeleSayi.Next(70, 100);
            OzelYetenek     = RastgeleSayi.Next(70, 100);
            SogukKanlilik   = RastgeleSayi.Next(70, 100);
        }

        public override bool PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3
                                          + Yetenek * 0.2
                                          + OzelYetenek * 0.2
                                          + Dayaniklilik * 0.1
                                          + DogalForm * 0.1
                                          + Sans * 0.1);

            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.2
                                          + OzelYetenek * 0.2
                                          + Sut * 0.1
                                          + Kafa * 0.1
                                          + IlkDokunus * 0.1
                                          + Bitiricilik * 0.1
                                          + SogukKanlilik * 0.1
                                          + Kararlilik * 0.1
                                          + DogalForm * 0.1
                                          + Sans * 0.1);

            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}