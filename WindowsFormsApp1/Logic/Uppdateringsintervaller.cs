using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Uppdateringsintervaller
    {
        public int Tid { get; set; }
        public List<Uppdateringsintervaller> Tider { get; set; }

        public Uppdateringsintervaller()
        {
            this.Tid = Tid;
        }

        public int getTid()
        {
            return Tid;
        }

        public List<Uppdateringsintervaller> TidLista()
        {
            var Tider = new List<Uppdateringsintervaller>();
            Tider.Add(new Uppdateringsintervaller() { Tid = 100 });
            Tider.Add(new Uppdateringsintervaller() { Tid = 100 });
            return Tider;

        }
    }
}
