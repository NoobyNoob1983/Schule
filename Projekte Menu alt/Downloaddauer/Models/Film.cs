using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Downloaddauer.Models
{
    public class Film
    {
        public static List<Film> filme = new List<Film>();
        

        public int Id { get; set; }
        public string Titel { get; set; }
        public int Jahr { get; set; }
        public double Punkte { get; set; }
        public int Stimmen { get; set; }
        public int Regie { get; set; }

        public Film(int id, string titel, int jahr, double punkte, int stimmen, int regie)
        {
            Id = id;
            Titel = titel;
            Jahr = jahr;
            Punkte = punkte;
            Stimmen = stimmen;
            Regie = regie;
        }

        public static string GetRegisseur(int id)
        {
            string r = "";

            for (int i = 0; i < filme.Count; i++)
            {

                for (int k = 0; k < Person.persons.Count; k++)
                {

                    if (filme[i].Id == id)
                    {
                        if (Person.persons[k].Id == filme[i].Regie)
                        {
                            r = Person.persons[k].Name;
                        } 
                    }

                }  
            }
            
            return r;
        }


        public static List<string> GetBesatzung(int id)
        {
            //string besatzung ="";

            List<string> besatzung = new List<string>();

            for (int i = 0; i < Besetzung.besetzung.Count; i++)
            {
                if (Besetzung.besetzung[i].FilmId == id)
                {
                    for (int k = 0; k < Person.persons.Count; k++)
                    {
                        if (Person.persons[k].Id == Besetzung.besetzung[i].PersId)
                        {
                            besatzung.Add(Person.persons[k].Name);
                        }
                    }
                }
            }

            return besatzung ;
        }
    }
}