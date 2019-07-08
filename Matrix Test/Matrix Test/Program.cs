using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int zufall;

            Console.WindowWidth = 240;
            Console.WindowHeight = 60;
            //2DArray
            int[,] spielFeld = { { 60,50 ,25,1}, { 1,10,15,10} };
            int rowLength = spielFeld.GetLength(0);
            int colLength = spielFeld.GetLength(1);
            int xPos = 0;
            int yPos = 0;

           
            int j = 0;
   
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            Console.SetCursorPosition(xPos, yPos);
            while(true)
            { 
                Console.CursorVisible = false;
                foreach (var item in colors)
                {

                    
                   
                    for (int z = 1; z < Console.WindowWidth;)
                    {
                        zufall = random.Next(0, 3);

                        int posx = random.Next(1, Console.WindowWidth);
                        int posy = random.Next(1, Console.WindowHeight);
                        //Console.Write(" x:{0,5} ", "#", spielFeld[0, z]);




                        if(z % 100 == 0)
                        {
                     
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else if (z % 2 == 0)
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else
                        {
                            Console.ForegroundColor = item;
                        }
                        
                        Console.BackgroundColor = ConsoleColor.Black;



                        Console.SetCursorPosition(posx  ,posy -1);
                        Console.WriteLine("{0,0} ", zufall);


                        System.Threading.Thread.Sleep(0);
                        
                        z++;
                      
                    }

                }

            } 


            Console.ReadKey();

        }
    }
}
