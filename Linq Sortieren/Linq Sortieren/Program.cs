using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Linq_Sortieren
{
    class Program 
    {
        static void Main(string[] args)
        {

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            //var patternNumbers = @"^[0-9]{1}$";

            //string[] text = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };
            //var patternText = "^[a-z]{3}$";
            //var patternTeen = "teen$";
            ////Match m = Regex.Match(text[],pattern);

            //int[] textNeu = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

            //var zahlenKleiner = from n in numbers
            //             where  n < 7
            //             select n;


            //var zahlenGerade = from n in numbers
            //           .Where(n => n % 2 == 0)
            //             select n;

            //var zahleneinstellig = from n in numbers
            //           .Where(n => Regex.IsMatch(n.ToString(), patternNumbers))
            //            select n;

            //var zahlenab6 = from n in numbers
            //            .Skip(5)
            //           .Where(n => n % 2 == 0)

            //            select n;

            //var zahlenmitO = from n in text
            //          .Where(n => n.ToLower().Contains("o"))

            //                select n;



            //var dreizeichen = from n in text
            //                  .Where(n => Regex.IsMatch(n, patternText) )
            //                  select n ;


            //var zahlenmitTeen = from n in text
            //                  .Where(n => Regex.IsMatch(n, patternTeen))
            //                  select n;

            //var zahlenmitTeenGross = from n in text
            //                  .Where(n => Regex.IsMatch(n, patternTeen))
            //                    select n.ToUpper();

            //var zahlenmitfour = from n in text
            //                  .Where(n => n.Contains("four"))
            //                         select n;


            //var summe = textNeu.Sum();

            //var min = textNeu.Min();

            //var max = textNeu.Max();

            //var avg = textNeu.Average();

            //var minGerade = textNeu.Where(n => n % 2 == 0 && n > 0).Min();

            //var maxUngerade = textNeu.Where(n => n % 2 == 1 && n > 0).Max();


            //var sumGerade = textNeu.Where(n => n % 2 == 0 && n > 0).Sum();

            //var avgUngerade = textNeu.Where(n => n % 2 == 1 && n > 0).Average();


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

            //string[] text = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

            //var aufsteigend = numbers.OrderBy(n => n);

            //var absteigend = numbers.OrderByDescending(n => n);


            //var aufsteigendGerade = numbers.OrderBy(n => n).Where(n => n % 2 == 0);


            //var textAufsteigend = text.OrderBy(n => n.Length);
            //var textAufsteigendlänge = text.OrderBy(n => n.Length).ThenByDescending(n => n.ToString());

            //var rev = text.Reverse();


            //DirectoryInfo di = new DirectoryInfo("C:\\Windows");

            //var dateien = di.GetFiles().OrderBy(n => n.ToString());

            //var dateiengross = di.GetFiles().OrderBy(n => n.Length);

            //var nachDatum = di.GetFiles().OrderByDescending(n => n.LastWriteTimeUtc).Select(n => n.LastWriteTimeUtc );

            //int[] numbersNeu = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };


            //var ersteFünf = numbersNeu.Take(5);

            //var letzteFünf = numbersNeu.Reverse().Take(5);


            //var lealleAusser1 = numbersNeu.Skip(3).Reverse().Skip(3).Reverse();

            //var alleGrösser0 = numbersNeu.Where(n => n > 0);

            //var alleNach12 = numbersNeu.SkipWhile(n => n != 12).Skip(1);

            //var fünfNeue = di.GetFiles().OrderByDescending(n => n.CreationTimeUtc).Take(5);



            //var seiten = di.GetDirectories();

            ////Console.WriteLine(seiten);


            //for (int i = 0; i < di.GetFiles().Length; i++)
            //{
            //    if (i % 5 == 0 && i > 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        Console.WriteLine("Leerzeichen");

            //    }
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine(di.GetFiles().Take(di.GetFiles().Length));
            //}



            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };


            //var sortByHyphen = numbers.GroupBy(n => n[0]);
            //var sortByHyphenLength = numbers.GroupBy(n => n.Length);

            //var sortByHyphenAndLength = numbers.GroupBy(n => n.Length.ToString() + n[0]);


            //foreach (var gruppe in sortByHyphenAndLength)
            //{
            //    Console.WriteLine(gruppe.Key.ToString().ToUpper() + "------------");


            //    foreach (var item in gruppe)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}


            //var procs = Process.GetProcesses().OrderBy(x => x.Threads.Count).GroupBy(n => n.Threads.Count);


            //foreach (var item in procs)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var threads in item)
            //    {
            //        Console.WriteLine(threads.ProcessName);
            //    }
            //}


           

            Process[] mods = Process.GetProcesses().GroupBy(n=> 
            try
            {
               return n.MOdules
            }
            catch (Exception)
            {

                throw;
            }


            );

            Console.ForegroundColor = ConsoleColor.White;

            foreach (var process in mods)
            {

                foreach (ProcessModule item in process.Modules)
                {
                        var group = item.ModuleName;
                    Console.WriteLine(group);
                }
            }







            //try
            //{

            //    foreach (var item in mods)
            //    {

            //        foreach (var modules in item)
            //        {
            //            Console.WriteLine(modules.ProcessName);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}



            //var modsAlpha = Process.GetProcesses().GroupBy(n => n.Modules);


            //try
            //{
            //    foreach (var item in modsAlpha)
            //    {
            //        Console.WriteLine(item.Key);

            //        foreach (var modules in item)
            //        {
            //            Console.WriteLine(modules.ProcessName);
            //        }
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Fehler " + e.Message);
            //}

            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };


            //var factor = factorsOf300.Distinct();

            //foreach (var item in factor)
            //{
            //    Console.WriteLine( item);
            //}

            //var union = numbersA.Union(numbersB);

            //foreach (var item in union)
            //{
            //    Console.WriteLine(item);
            //}


            //var schnitt = numbersA.Intersect(numbersB);
            //foreach (var item in schnitt)
            //{
            //    Console.WriteLine(item);
            //}

            //var except = numbersA.Except(numbersB);

            //foreach (var item in except)
            //{
            //    Console.WriteLine(item);
            //}


           

            Console.ReadLine();
        }
    }
}
