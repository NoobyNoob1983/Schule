using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Downloaddauer.Models
{
    public class DbConnector
    {

        static string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=TeachSql;Integrated Security=true"; 



        public static SqlCommand Connect()
        {
            SqlConnection con = new SqlConnection(connectionstring);

             con.Open();

            SqlCommand sql = con.CreateCommand();


            return sql;

        }


        public static void GetFilme(SqlCommand sql)
        {

            Film.filme.Clear();


            //sql.CommandText = "Select  Top(10) * From MOV_FILM  ORDER BY(punkte) DESC ; ";
            sql.CommandText = "Select *  From MOV_FILM  ORDER BY(titel) DESC ; ";

            SqlDataReader read = sql.ExecuteReader();

            while (read.Read())
            {
                Film f = new Film(Convert.ToInt32(read["ID"]), read["TITEL"].ToString(),Convert.ToInt32(read["jahr"]),Convert.ToDouble(read["punkte"]),Convert.ToInt32(read["stimmen"]),Convert.ToInt32(read["regie"]));
                Film.filme.Add(f);
            }


        }

        public static void GetPersons(SqlCommand sql)
        {

            Person.persons.Clear();


            sql.CommandText = "Select * From MOV_Person; ";

            SqlDataReader read = sql.ExecuteReader();

            while (read.Read())
            {
                Person p = new Person(Convert.ToInt32(read["ID"]), read["name"].ToString());
                Person.persons.Add(p);
            }


        }

        public static void GetBesetzung(SqlCommand sql)
        {

            Besetzung.besetzung.Clear();


            sql.CommandText = "Select * From MOV_Besetzung; ";

            SqlDataReader read = sql.ExecuteReader();

            while (read.Read())
            {
                Besetzung b = new Besetzung(Convert.ToInt32(read["filmid"]), Convert.ToInt32(read["persid"].ToString()), Convert.ToInt32(read["ord"]));
                Besetzung.besetzung.Add(b);
            }


        }


    }
}