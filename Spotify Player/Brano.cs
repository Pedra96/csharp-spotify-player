using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player {
    public class Brano : IContenutoRiproducibile {

        private string TitoloBrano;
        private bool Feat;
        private uint Durata;
        private string FeatNome = "";
        private string Autore;
        private List<string> Genere;

        public Brano() { }

        public Brano(string TitoloBrano, uint Durata, string Autore, List<string> Generi, string Feat = "") {
            this.Autore = Autore;
            this.TitoloBrano = TitoloBrano;
            this.Durata = Durata;
            SetFeat(Feat);
            this.Genere = Generi;
        }

        public void SetAutore(string Autore) {
            if (string.IsNullOrWhiteSpace(Autore)) {
                throw new Exception();
            } else {
                this.Autore = Autore;
            }
        }

        public void SetTitoloBrano(string Titolo) {
            if (string.IsNullOrWhiteSpace(Titolo)) {
               throw new Exception();
            } else {
                TitoloBrano = Titolo;
            }
        }
        public void SetDurata(uint durata) {
            Durata = durata;
        }

        public void SetFeat(string feat) {
            if (string.IsNullOrEmpty(feat)||feat=="no") {
                Feat = false;
            }
            else {
                Console.WriteLine("Inserire nome del Feat");
                FeatNome = Console.ReadLine();
                Feat = true;
            }
        }
        public void SetGenere(List<string> Genere) {
            this.Genere = Genere;
        }

        public string GetTitoloBrano() {
            return TitoloBrano;
        }
        public uint GetDurata() {
            return Durata;
        }
        public string GetFeatName() {
            return FeatNome;
        }

        public string GetAutore() {
            return Autore;
        }
        public string GetGenere() {
            string ListaGeneri = "";
            foreach (var genere in Genere) {
                ListaGeneri += genere + " ";
            }
            return ListaGeneri;
        }

        public void Play() {
            if (Feat) {
                Console.WriteLine("Riproduzione del brano: " + TitoloBrano + "di " + Autore + " Feat: " + FeatNome);
            } else {
                Console.WriteLine("Riproduzione del brano: " + TitoloBrano+ " di " + Autore);
            }

        }
        public void Pause() {
            if (Feat) {
                Console.WriteLine("Il brano " + TitoloBrano + " di " + Autore + " Feat: " + FeatNome + " è stato messo in pausa");
            } else {
                Console.WriteLine("Il brano " + TitoloBrano +" di "+ Autore+ " è stato messo in pausa");
            }

        }

        public void Stop() {
            if (Feat) {
                Console.WriteLine("Il brano " + TitoloBrano + " Feat: " + FeatNome + " è stato fermato");
            } else {
                Console.WriteLine("Il brano " + TitoloBrano + " è stato fermato");
            }
        }
        public override string ToString() {
            string Print = "------------------------------------\n";
            Print += "Scheda Brano\n";
            Print += "Autore: " + Autore+"\n";
            Print += "Titolo del brano: " + TitoloBrano+"\n";
            if(Feat) {
                Print += "Feat: " + FeatNome+"\n";
            }
            Print += "Genere: "+GetGenere() + "\n";
            Print += "Durata: " + Durata +" secondi\n";
            Print += "------------------------------------\n";
            return Print;
        }
    }
}
