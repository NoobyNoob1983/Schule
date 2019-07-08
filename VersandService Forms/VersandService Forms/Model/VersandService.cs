using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersandService_Forms.Model
{
    class VersandService : PostSendung
    {
        #region Attribute

        // Liste der Sendeungen
        private List<PostSendung> post = new List<PostSendung>();


        #endregion


        #region Konstruktor
        public VersandService(int sendeId, Adresse absender, Adresse empfänger) 
            : base(sendeId, absender, empfänger)
        {
        }

        #endregion


        #region Methoden

        /// <summary>
        /// Diese Methode erzeugt ein neuen Brief 
        /// </summary>
        public void NeuerBrief(Adresse absender,Adresse empfänger,int sendeId,string kategorie)
        {
            Brief brief = new Brief(sendeId = PostSendung._sendeId, absender,empfänger,kategorie);
            post.Add(brief);
        }

        /// <summary>
        /// Diese Methode erzeugt ein neues Paket 
        /// </summary>
        public void NeuesPaket(Adresse absender, Adresse empfänger,int sendeId)
        {
            Paket paket = new Paket(sendeId = PostSendung._sendeId,absender,empfänger);
            post.Add(paket);
        }

        /// <summary>
        /// Diese Methode setzt die Post auf ausgeliefert
        /// </summary>
        public void Ausliefern()
        {
            PostSendung._istZugestellt = true;
        }


        #endregion


    }
}
