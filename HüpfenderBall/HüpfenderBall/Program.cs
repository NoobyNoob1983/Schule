using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HüpfenderBall
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variablen
            //Cursor Position Speichern
            int xPos ;
            int yPos;

            //Spieler anlegen
            string spieler = "*";

            //Geschwindigkeit
            int speed = 100;

            //Warum so ???????????????
            //ConsoleKey 
            ConsoleKeyInfo cki;

            //löschen der zeichen
            int löschenLinks;
            int löschenOben;

            #endregion

            #region Spielfeld
            //Spielfeld festlegen
            Console.Write("Breite:");
            int breite = int.Parse(Console.ReadLine());
            Console.Write("Höhe:");
            int höhe = int.Parse(Console.ReadLine());

            //Console säubern
            Console.Clear();

            //Spielfeld zeichnen x1
            for (int i = 0; i <= breite; i++)
            {
                //Ausgabe
                Console.Write("#");
            }
            Console.WriteLine();

            //String Format für Variable Breite 
            string format = "{0,0}{0," + breite +"}";

            //Spielfeld zeichnen y
            for (int i = 0; i <= höhe; i++)
            {
                //Ausgabe
                Console.WriteLine(string.Format(format,"#"));
            }

            //Spielfeld zeichnen x2
            for (int i = 0; i <= breite; i++)
            {
                //Ausgabe
                Console.Write("#");
            }
            #endregion

            #region SpielerPhysix

            //Cursor auf Startposition setzen zufällig
            Random zufall = new Random();
            xPos = zufall.Next(0,breite);
            yPos = zufall.Next(0,höhe);

            Console.CursorVisible = false;

            //Schleife für bewegung 
            while (true)
            {

                //Start des Balls
                xPos = xPos + 1;
                yPos = yPos + 1;

                //Cursor setzen
                Console.SetCursorPosition(xPos, yPos);

                //Spieler zeichnen
                Console.Write("*");
                Console.SetCursorPosition(xPos-1 , yPos-1 );
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
                Console.ResetColor();
                Console.SetCursorPosition(xPos, yPos);
                Console.ForegroundColor = Console.BackgroundColor;
                Console.Write("*");
                Console.ResetColor();

                //Speed vom Ball
                System.Threading.Thread.Sleep(speed);


                //Wenn Wand getroffen abprallen
                if(yPos >= höhe)
                {
                    while(yPos > 2)
                    {
                        yPos = yPos - 1;
                    }
                }
                Console.Write("{0} : {1}",xPos, yPos);
            }
            
            #endregion
        }
    }
}
