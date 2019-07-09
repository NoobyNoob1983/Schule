using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Downloaddauer.Models
{
    public class Palindrom
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private bool isPalindrom;

        public bool IsPalindrom
        {
            get { return isPalindrom; }
            set { isPalindrom = value; }
        }
    }
}