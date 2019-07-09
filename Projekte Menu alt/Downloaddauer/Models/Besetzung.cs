using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Downloaddauer.Models
{
    public class Besetzung
    {
        public int FilmId { get; set; }
        public int PersId { get; set; }
        public int Order { get; set; }

        public static List<Besetzung> besetzung = new List<Besetzung>();

        public Besetzung(int filmId, int persId, int order)
        {
            FilmId = filmId;
            PersId = persId;
            Order = order;
        }
    }
}