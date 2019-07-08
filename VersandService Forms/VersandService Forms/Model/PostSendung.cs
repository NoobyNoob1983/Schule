using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersandService_Forms.Model;

namespace VersandService_Forms.Model
{
    class PostSendung
    {
        #region Attribute

        // SendungsNummer
        public static int _sendeId;

        // Absender Adresse
        protected Adresse _sender;
        public Adresse Sender
        {
            get { return _sender; }
            set { _sender = value;}
        }

        // Empfänger Adresse
        protected Adresse _empfänger;
        public Adresse Empfänger
        {
            get { return _empfänger; }
            set
            {
                _empfänger = value;
            }
        }

        // Ist die Post zugestellt ?
        protected static bool _istZugestellt;
        public static bool IstZugestellt
        {
            get{ return _istZugestellt; }
            set { _istZugestellt = value; }
        }

        #endregion


        #region Konstruktor

        public PostSendung(int sendeId,Adresse absender,Adresse empfänger)
        {
            _sendeId = _sendeId + 1;
            this._empfänger = empfänger;
            this._sender = absender;
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
