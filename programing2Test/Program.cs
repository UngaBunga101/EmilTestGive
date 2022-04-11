using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DVD> DVDs = new List<DVD>();
            List<CD> CDs = new List<CD>();
            //List<List<>> samling = new List<List<>>();
            //samling.Add(DVDs);
            //samling.Add(CDs);
            //Console.WriteLine(samling);


            CD lisasAbum = new CD("lisasAbum","Lisa","3 låtar","rock");
            CDs.Add(lisasAbum);
            CD LofiHipHopStudio = new CD("LofiHipHopStudio", "lofiBread", "145 låtar", "lofiHipHop");
            CDs.Add(LofiHipHopStudio);
            DVD jungelboken = new DVD("jungelboken", "baloo", "galen man","comedi",true,7);
            DVDs.Add(jungelboken);
            DVD jungelbroken = new DVD("jungelbroken", "bob", "man", "sus", false, 10);
            DVDs.Add(jungelbroken);

            int antalDvd = DVDs.Count;
            int antalCd = CDs.Count;

            bool cont = true;
            bool contcont = true;
            while (cont == true)
            {
                Console.WriteLine("Enter a number for what you want to do : ");
                Console.WriteLine("add Cd/Dvd [1]");
                Console.WriteLine("search [2]");
                Console.WriteLine("testing now [3]");
                Console.WriteLine("listor [4]");
                Console.WriteLine("end this session [6]");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        AddFuntcion();
                        break;
                    case "2":
                        SearchFunction();
                        break;
                    case "3":
                        break;
                    case "4":
                        ListFunction();
                        break;
                    case "5":
                        break;
                    case "6":
                        cont = false;
                        break;
                }
            }

            void AddFuntcion()
            {
                Console.WriteLine("what is it you whant to add? : write (cd) or (dvd)");
                string val = Console.ReadLine();
                if (val == "dvd")
                {

                    string named = Console.ReadLine();
                    string skå = Console.ReadLine();
                    string res = Console.ReadLine();
                    string gen = Console.ReadLine();
                    bool tf = System.Convert.ToBoolean (Console.ReadLine());
                    int scale = Int32.Parse (Console.ReadLine());
                    antalDvd = +1;

                    
                    DVD UserDVD = new DVD (named, skå, res, gen, tf, scale);
                    DVDs.Add(jungelboken);
                }
                else if (val == "cd")
                {
                    string named = Console.ReadLine();
                    string art = Console.ReadLine();
                    string låt = Console.ReadLine();
                    string mus = Console.ReadLine();
       
                    antalCd += 1;


                    CD UserCD = new CD(named, art, låt, mus);
                    DVDs.Add(jungelboken);
                }
                else
                {
                    Console.WriteLine("so u dont want anything? ok");
                    Console.WriteLine();
                }
            }

            void SearchFunction()
            { 

            }

            void ListFunction()
            {
                while (contcont == true)
                {
                    Console.WriteLine("skriv (cd) för att komma åt alla cd's");
                    Console.WriteLine("skriv (dvd) för att komma åt alla dvd's");
                    Console.WriteLine("skriv (dvdcd) för att komma åt alla disc's");
                    Console.WriteLine("skriv vad som för att avsluta och gå till baka till menyn");
                    Console.WriteLine();
                    switch (Console.ReadLine())
                    {
                        case "dvd":
                            foreach (var dvd in DVDs)
                            {
                                Console.WriteLine("DVD: {0},{1},{2},{3},{4}", dvd.GetNamn(), dvd.Skådisar, dvd.Genre, dvd.SeenMovie, dvd.Betyg);
                            }
                            break;
                        case "cd":
                            foreach (var cc in CDs)
                            {
                                Console.WriteLine("CD: {0},{1},{2},{3}", cc.GetNamn(), cc.Artist, cc.Låtlista, cc.MusikGenere);
                            }
                            break;
                        case "dvdcd":
                            foreach (var dvd in DVDs)
                            {
                                Console.WriteLine("DVD: {0},{1},{2},{3},{4}", dvd.GetNamn(), dvd.Skådisar, dvd.Genre, dvd.SeenMovie, dvd.Betyg);
                            }
                            foreach (var cc in CDs)
                            {
                                Console.WriteLine("CD: {0},{1},{2},{3}", cc.GetNamn(), cc.Artist, cc.Låtlista, cc.MusikGenere);
                            }
                            break;
                        default:
                            contcont = false;
                            break;
                    }
                }
                
            }

        }
    }
}
