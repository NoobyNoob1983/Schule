using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneckenRennen
{
    class Program
    {
        // ConsoleKey Info für nächsten Zug
        static ConsoleKeyInfo cki;

        static void Main(string[] args)
        {
            // Cursor Positionen
            int xPos = 0;
            int yPos = 10;

            // Rennschnecken Array
            Rennschnecke[] schnecken = new Rennschnecke[5];
            schnecken[0] = new Rennschnecke("Manfred",10,5,5);
            schnecken[1] = new Rennschnecke("Peter", 10, 5,7);
            schnecken[2] = new Rennschnecke("Herrmann", 10, 5,9);
            schnecken[3] = new Rennschnecke("Wolfgang", 10, 5,11);
            schnecken[4] = new Rennschnecke("Rudolf", 10, 5,13);


            int[] altPos = new int[schnecken.Length];

            // Game Schleife
            int count = 0;


            while (true)
            {
               
                // Rennschnecken Schleife
                for (int i = 0; i < 5; i++)
                {
                    // Counter für einen Zug IXDEEEEE
                    int counter = 0;
                    // SpielZug
                    do
                    {
                        Console.SetCursorPosition(altPos[i], schnecken[i].StartY);
                        Console.WriteLine("   ");
                        Console.SetCursorPosition(xPos, schnecken[i].StartY);


                        // Anzeige wer dran ist
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("{0} ist Dran", schnecken[i].Name);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Press Space To Walk ....");
                        Console.SetCursorPosition(xPos +2, yPos);


                        // xPos für schnecke setzen
                        xPos = schnecken[i].Krieche();
                        
                        // SchneckenNamen y -1 
                        Console.SetCursorPosition(0, schnecken[i].StartY -1);
                        Console.WriteLine(schnecken[i].Name);

                        // Position y +1 für Schnecke
                        Console.SetCursorPosition(xPos,schnecken[i].StartY);


                        // Wenn Key gedrückt
                        //cki = Console.ReadKey();

                        // Position für später speichern letztes Zeichen löschen

                        altPos[i] = xPos;

                        //Bug
                        if(schnecken[i].xPos >= 90)
                        {
                            break;
                        }

                        Console.WriteLine("@o\"");
                        System.Threading.Thread.Sleep(100);
                       
                        counter++;


                    } while (counter <  1 );

                 
                    
                    
                }
                count++;
            }
            Console.ReadLine();
        }
    }
} 
