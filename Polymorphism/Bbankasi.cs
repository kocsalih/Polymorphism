using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Bbankasi:Bank
    {
        public override void IndirimOraninaGoreIndirimYap()
        {
            _alisverisTutari -= _alisverisTutari * 0.5m;
            Console.WriteLine("0.5 indirim uygulandı");
            Console.WriteLine("Ödenecek tutat: "+_alisverisTutari);
        }
    }
}
