using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersandService_Forms.Model
{
    class PaketVerfolgung:Paket
    {
        #region Attribute

        // Ort
        protected string _ort;
        public string Ort
        {
            get { return _ort; }
            set { _ort = value; }
        }

        // Uhrzeit
        protected static string _uhrzeit;
        public static string Uhrzeit
        {
            get { return _uhrzeit; }
            set { _uhrzeit = value; }
        }

        protected List<Station> station = new List<Station>();

        #endregion

        #region Konstruktor
        public PaketVerfolgung(int sendeId, Adresse absender, Adresse empfänger) 
            : base(sendeId, absender, empfänger)
        {
            Station stationEins = new Station(absender.Ort);
        }


        #endregion



    }
}
