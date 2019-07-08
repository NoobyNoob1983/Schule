using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersandService_Forms.Model
{
    class Brief : PostSendung
    {
        #region Attribute

        // BriefKategorie Enum !?!?
        private enum BriefKategorie
        {
            StandardBrief = 1,
            EilBrief = 2,
            Einschreiben = 3
        }

        // BriegKAtegorie
        private string _kategorie;
        public string Kategorie
        {
            get { return _kategorie; }
            set { _kategorie = value; }
        }


        #endregion

        #region Konstruktor

        public Brief(int sendeId, Adresse absender, Adresse empfänger,string kategorie = "StandardBrief") 
            : base(sendeId, absender, empfänger)
        {
            this._kategorie = kategorie;
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
