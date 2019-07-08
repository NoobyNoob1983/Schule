using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersandService_Forms.Model;

namespace VersandService_Forms.Model
{
    class Station
    {
        #region Attribute

        // Ort
        private string _ort;
        public string Ort
        {
            get { return _ort; }
            set { _ort = value; }

        }

        #endregion

        #region Konstruktor

        public Station(string ort) 
        {
            this._ort = ort;
            PaketVerfolgung.Uhrzeit = DateTime.Now.ToString();
        }

        #endregion
    }
}
