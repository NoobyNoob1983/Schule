using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersandService_Forms.Model;

namespace VersandService_Forms.Model
{
    class Paket:PostSendung
    {
        #region Attribute

        // Gewicht
        protected float _gewicht;
        public float Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        // Ist das Paket Versichert
        protected bool _istVersichert;

        public bool IstVersichert
        {
            get { return _istVersichert; }
            set { _istVersichert = value; }
        }

        #endregion

        #region Konstruktor
        public Paket(int sendeId, Adresse absender, Adresse empfänger) 
            : base(sendeId, absender, empfänger)
        {
        }


        #endregion


        #region Methoden

        /// <summary>
        /// Diese Methode gibt einen String zurück
        /// </summary>
        /// <returns></returns>
        public new string ToString()
        {
            return string.Format("");
        }

        #endregion

    }
}
