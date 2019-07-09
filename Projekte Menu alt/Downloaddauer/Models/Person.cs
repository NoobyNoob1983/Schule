using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Downloaddauer.Models
{
    public class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Person> persons = new List<Person>();

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}