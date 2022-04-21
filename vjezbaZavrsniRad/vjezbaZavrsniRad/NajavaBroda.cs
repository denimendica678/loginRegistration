using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaZavrsniRad
{
    class NajavaBroda
    {
        DateTime datumDolaska, datumaOdlaska;
        string vez;

        public NajavaBroda(DateTime datumDolaska, DateTime datumaOdlaska, string vez)
        {
            this.datumDolaska = datumDolaska;
            this.datumaOdlaska = datumaOdlaska;
            this.vez = vez;
        }

        public DateTime DatumDolaska { get => datumDolaska; set => datumDolaska = value; }
        public DateTime DatumaOdlaska { get => datumaOdlaska; set => datumaOdlaska = value; }
        public string Vez { get => vez; set => vez = value; }
    }
}
