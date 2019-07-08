using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneckenRennen
{
    class Rennschnecke
    {
        // Attribute
        private string _name;
        public string Name
        {
            get { return _name; }
            set { Name = value; }
        }

        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        private int _startX;
        public int StartX
        {
            get { return _startX; }
        }

        private int _startY;
        public int StartY
        {
            get { return _startY; }
        }

        public int xPos = Console.CursorLeft;


        //Static Random
        static Random random = new Random();

        // Konstruktor
        public Rennschnecke(string name, int maxSpeed, int startX, int startY)
        {
            this._name = name;
            this._maxSpeed = maxSpeed;
            this._startX = startX;
            this._startY = startY;
        }

        // Methoden
        public int Krieche()
        {
             return xPos += random.Next(1,MaxSpeed); 
        }

 

    }
}
