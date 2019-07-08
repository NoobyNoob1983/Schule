using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersandService_Forms.Model;

namespace VersandService_Forms.Model
{
    public class Adresse
    {
        #region Attribute

        // Nachname
        protected string _nachname;
        public string Nachname
        {
            get { return _nachname; }
            set { _nachname = value; }
        }

        // Vorname
        protected string _vorname;
        public string Vorname
        {
            get { return _vorname; }
            set { _vorname = value; }
        }

        // Strasse
        protected string _strasse;
        public string Strasse
        {
            get { return _strasse; }
            set { _strasse = value; }
        }

        // PLZ
        protected string _plz;
        public string Plz
        {
            get { return _plz; }
            set { _plz = value; }
        }

        // Ort
        protected string _ort;
        public string Ort
        {
            get { return _ort; }
            set { _ort = value; }
        }

        // Land
        protected string _land;
        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }

        #endregion

        #region Konstruktor

        public Adresse(string nachname,string vorname, string strasse, string plz,string ort,string land = "Deutschland")
        {
            if (IstGültig(vorname,nachname,strasse,plz,ort))
            {
                this._nachname = nachname;
                this._vorname = vorname;
                this._strasse = strasse;
                this._plz = plz;
                this._land = land; 
            }
        }

        #endregion

        #region Methoden
        /// <summary>
        /// Diese Methode prüft ob eine Adresse gültig ist
        /// </summary>
        /// <returns></returns>
        public bool IstGültig(string vorname,string nachname,string strasse, string plz,string ort)
        {
            if (string.IsNullOrEmpty(vorname) || string.IsNullOrEmpty(nachname) || string.IsNullOrEmpty(strasse) || string.IsNullOrEmpty(plz) || string.IsNullOrEmpty(ort))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        /// <summary>
        /// Diese Methode gibt einen String zurück überschreibt die ToString() Methode
        /// </summary>
        /// <returns></returns>
        public new string ToString()
        {
            return string.Format("");
        }

        #endregion
    }
}
