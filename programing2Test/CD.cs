using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programing2Test
{
     class CD : Disc
    {
        string artist;
        string låtlista;
        string musikGenere;

        public CD(string name, string artist, string låtlista, string musikGenere) : base(name)
        {
            this.artist = artist;
            this.låtlista = låtlista;
            this.musikGenere = musikGenere;
        }

        public string Artist { get => artist; set => artist = value; }
        public string Låtlista { get => låtlista; set => låtlista = value; }
        public string MusikGenere { get => musikGenere; set => musikGenere = value; }

        public void InfoCD()
        {
            Console.WriteLine("Namn: " + base.GetNamn());
            
        }
    }
}
