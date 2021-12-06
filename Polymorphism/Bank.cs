using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Bank
    {
        private string bankaAdi;

        public string _bankaAdi
        {
            get { return bankaAdi; }
            set { bankaAdi = value; }
        }


        private decimal alisVerisTutari = 0;
        public decimal _alisverisTutari { get; set; }

        public void BilgileriAl()
        {
            Console.WriteLine(bankaAdi+"bankasına hoş geldiniz.");
            Console.WriteLine("Alışveriş tutarı giriniz: ");

            _alisverisTutari = alisVerisTutari;
            if (alisVerisTutari>0)
            {
                _alisverisTutari = alisVerisTutari;

            }
            else
            {
                throw new Exception("Tutar Sıfırdan büyük olmalı");
            }
        }

        public virtual void IndirimOraninaGoreIndirimYap()
        {
            _alisverisTutari -= _alisverisTutari * 0.20m;
            Console.WriteLine("Yüzde 20 indirim Uygulandı");
            Console.WriteLine("ödenecek tutar: "+_alisverisTutari);
        }
    }
}
