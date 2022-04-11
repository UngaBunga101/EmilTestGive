using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing2Test
{
    class DVD : Disc
    {
        string skådisar;
        string regissör;
        string genre;
        bool seenMovie;
        int betyg;

        public DVD(string name,string skådisar, string regissör, string genre, bool seenMovie, int betyg) : base(name)
        {
            this.skådisar = skådisar;
            this.regissör = regissör;
            this.genre = genre;
            this.seenMovie = seenMovie;
            this.betyg = betyg;
        }

        public string Skådisar { get => skådisar; set => skådisar = value; }
        public string Regissör { get => regissör; set => regissör = value; }
        public string Genre { get => genre; set => genre = value; }
        public bool SeenMovie { get => seenMovie; set => seenMovie = value; }
        public int Betyg { get => betyg; set => betyg = value; }


        public void InfoDVD()
        {
            Console.WriteLine("Namn: " + base.GetNamn());
        }
    }
}
