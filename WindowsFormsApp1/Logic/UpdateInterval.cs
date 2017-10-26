using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class UpdateInterval
    {
        public int Tid { get; set; }
        public List<UpdateInterval> Tider { get; set; }

        public UpdateInterval()
        {
            this.Tid = Tid;
        }

        public int getTid()
        {
            return Tid;
        }

        public List<UpdateInterval> TidLista()
        {
            var Tider = new List<UpdateInterval>();
            Tider.Add(new UpdateInterval() { Tid = 100 });
            Tider.Add(new UpdateInterval() { Tid = 200 });
            return Tider;

        }
    }
}
