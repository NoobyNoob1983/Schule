using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Farben Setzen und Console löschen
            Console.WindowWidth = 120;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;

            //Consolen Fenster Titel
            Console.Title = "N00by`s H4cker Game";

            //Start Sprech Feld Zeichnen
            int xPos = Console.CursorLeft;
            int yPos = Console.CursorTop;
            for (int x = 1; x <=100; x++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,-0}","#");
                System.Threading.Thread.Sleep(1);
            }
             Console.WriteLine();
            for (int y = 1; y <=10 ; y++)
            {
                Console.WriteLine("{0,-0}{0,99}","#");
                System.Threading.Thread.Sleep(80);
            }
            for (int z = 1; z <= 100; z++)
            {
                Console.Write("{0,-0}","#");
                
            }

            //Cursor zurücksetzen
            Console.CursorTop = 2;
            Console.CursorLeft = 5;
            string s = "Hallo ich bin der Crazy Hacker ich werde deine Pc zerstören\n#    falls du mir nicht glaubst ahahahha hier du Noob deine Ip 127.0.0.1 \n#    hahahahahahahahahahahahahaahahha ";
            
            //Den Text Langsam schreiben
            foreach (var item in s)
            {
                //Wenn Zeichen kein # dann Rot sonst grün
                if(item != '#')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                //Sound Tippen 2 Zeichen unterschiedlich
                Console.Write(item);
                if(item != ' ')
                {
                    Console.Beep(37, 50);
                }
                else
                {
                    Console.Beep(60, 50);
                }
                System.Threading.Thread.Sleep(15);
            }


            //Consolen Fake Ping schreiben
            Console.CursorTop = 14;
            Console.CursorLeft = 0;
           
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;


            //Shebang Anzeigen
            Console.Write("C:\\Users\\1337Hax0r>");
            string ss = "ping 127.0.0.1\n";
            foreach (var item in ss)
            {
                //Text langsam schreiben
                Console.Write(item);
                System.Threading.Thread.Sleep(20);
                if (item != ' ')
                {
                    Console.Beep(37, 50);
                }
                else
                {
                    Console.Beep(60, 50);
                }
            }


            //Ping ausgabe langsam
            Console.WriteLine("Ping wird ausgeführt für 127.0.0.1 mit 32 Bytes Daten:");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Antwort von 127.0.0.1: Bytes = 32 Zeit < 1ms TTL = 128");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Antwort von 127.0.0.1: Bytes = 32 Zeit < 1ms TTL = 128");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Antwort von 127.0.0.1: Bytes = 32 Zeit < 1ms TTL = 128");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Antwort von 127.0.0.1: Bytes = 32 Zeit < 1ms TTL = 128");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nPing - Statistik für 127.0.0.1:");
            System.Threading.Thread.Sleep(1);
            Console.WriteLine("{0,53} ", "Pakete: Gesendet = 4, Empfangen = 4, Verloren = 0");
            System.Threading.Thread.Sleep(1);
            Console.WriteLine("{0,17} ", "(0% Verlust),");
            System.Threading.Thread.Sleep(1);
            Console.WriteLine("{0,0} ", "Ca. Zeitangaben in Millisek.:");
            System.Threading.Thread.Sleep(1);
            Console.WriteLine("{0,50} ", "Minimum = 0ms, Maximum = 0ms, Mittelwert = 0ms");
            Console.WriteLine("\nC:\\Users\\Hax0r>");
            Console.Beep(37, 500);
            Console.CursorTop = 7;
            Console.CursorLeft = 5;


            //Ping Antwort Text
            string sss = "HAHAHAHAHAHH hast du gesehen, ich kann dich pingen :D jetzt mach ich dich platt";
            foreach (var item in sss)
            {
                //Text langsam schreiben
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item);
                System.Threading.Thread.Sleep(20);


                //Sound ausgeben 2 unterschiedliche tasten
                if (item != ' ')
                {
                    Console.Beep(37, 50);
                }
                else
                {
                    Console.Beep(60, 50);
                }
            }


            //Clear Screen CLS
            Console.CursorTop = 27;
            Console.CursorLeft = 5;
            string ssss = "cls";
            foreach (var item in ssss)
            {
                Console.ResetColor();
                Console.Write(item);
                System.Threading.Thread.Sleep(20);
            }
            System.Threading.Thread.Sleep(100);
            Console.CursorTop = 14;
            Console.CursorLeft = 19;


            //Console überschreiben
            for (int i = 0; i <200; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("sadasdasdsdsdad");
            }

            //Fenster und Cursor Position Reset
            Console.SetWindowPosition(0, 0);
            Console.CursorTop = 8;
            Console.CursorLeft = 5;
            string sssss = "Firewall warnung: Willst du den Exploit schutz ausführen \n#    und dich mit dem Remote rechner verbinden?  (Y/N)?";


            //Text langsam schreiben
            foreach (var item in sssss)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item);
                System.Threading.Thread.Sleep(20);

                //Sound 2 verschiedene töne
                if (item != ' ')
                {
                    Console.Beep(37, 50);
                }
                else
                {
                    Console.Beep(60, 50);
                }
            }

            //Metasploit Fake ausführen
            Console.CursorTop = 14;
            Console.CursorLeft = 19;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("Metasploit Remote Control ausführen(Y/N):");
            string eingabe = Console.ReadLine();
            
            Console.CursorTop = 14;
            Console.CursorLeft = 19;


            //Wenn Y Dann Fake Connecting to Server
            //langsam ausgeben
            if (eingabe == "Y" || eingabe == "y")
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("sadasdasdsdsdad");
                }
                Console.SetWindowPosition(0, 0);
                
                Console.CursorTop = 14;
                Console.CursorLeft = 19;
                string ssssss = "Connecting to Remote Machine . . . . . . . .\n";


                //Text langsam ausgeben
                foreach (var item in ssssss)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(item);
                    System.Threading.Thread.Sleep(20);
                }


                //Fake Client Hello
                System.Threading.Thread.Sleep(20);
                System.Threading.Thread.Sleep(500);
                Console.Write("Connected to 127.0.0.1 Client Hello\nEscape character is '^]'.\n\nHax0r:~ Manfred$> ");
                Console.Write("");
                Console.Beep(37, 500);
            }
            Console.CursorTop = 2;
            Console.CursorLeft = 5;


            //Text Febster Löschen
            for (int i = 0; i < 9; i++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Black; 
                Console.Write("cxycykcölyxklcxyölkcölxklcökxyölckölyxkclxyckölyxkclkxölckxyölkcölxkclöx1234köl\n");
                Console.CursorLeft = 5;
                Console.CursorTop = i+2;
                
            }
            Console.CursorTop = 2;
            Console.CursorLeft = 5;


            //Neue Aufgabe Text langsam schreiben
            string sssssss = "Deine nächste Aufgabe besteht darin, Dateien von seinem Rechner zu stehlen.\n#    Dazu kannst du Wie folgt vorgehen mit ls Verzeichniss Inhalt anzeigen.\n#    Mit scp Dateien auf deinen Rechner laden\n#    mit exit beenden ";
            foreach (var item in sssssss)
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Black;


                //Wenn # Dann grün sonst Rot
                if(item != '#')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }


                //2 verschiedene töne
                if (item != ' ')
                {
                    Console.Beep(37, 50);
                }
                else
                {
                    Console.Beep(60, 50);
                }
                Console.Write(item);
                System.Threading.Thread.Sleep(20);
            }
            Console.CursorTop = 18;
            Console.CursorLeft = 17;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            string ls = "";


            //Dateien auflisten und Kopieren
            while (ls != "exit")
            {
                Console.Write("");
                ls = Console.ReadLine();

                if (ls == "ls")
                {
                    //Ls Ausgabe
                    Console.WriteLine("drwxr-xr-x  5 Manfred root   4096 Mär 19 21:30 .");
                    Console.WriteLine("drwxr - xr - x  4 Manfred root   4096 Mär 17 00:05..");
                    Console.WriteLine("drwxr - xr - x  4 Manfred root   4096 Mär 17 00:05 UltraGeheimeDaten");
                    Console.Write("\nHax0r:~ Manfred$>");

                }
                if (ls == "scp")
                {
                    //Scp Ausgabe
                    Console.WriteLine("Connecting to server...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("sftp>get UltraGeheimeDaten");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(" Fetching /home/Manfred/UltraGeheimeDatent to UltraGeheimeDaten");
                    Console.WriteLine("{0}{1,60}", "/home/Manfred/UltraGeheimeDatent ", "100%   62KB  1024.2Mb/s   00:00");
                    Console.Write("\nsftp>");
                }
               
            }
            //Not Implemented Exception
            Console.Write("Hax0r:~ Manfred$>NotImplementedException()");
            Console.ReadKey();



            //Zurück zum Start
            Console.ResetColor();
            Console.WriteLine("Von vorne beginnen .....");
            Console.ReadKey();
            System.Threading.Thread.Sleep(200);
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Main(args);


            
            


        }
    }
}
