using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player {
    public class Podcast : IContenutoRiproducibile {
        private string PodcastTitolo;
        private List<string> PodcastHost;
        private string PodcastProduttore;
        private string EpisodioTitolo;
        private uint EpisodioDurata;
        private List<string> Genere;

        public Podcast() { }
        public Podcast(string PodcastTitolo, List<string> PodcastHost, string PodcastProduttore, string EpisodioTitolo, uint EpisodioDurata, List<string> Genere) {
            this.PodcastTitolo = PodcastTitolo;
            this.PodcastHost = PodcastHost;
            this.PodcastProduttore = PodcastProduttore;
            this.EpisodioTitolo = EpisodioTitolo;
            this.EpisodioDurata = EpisodioDurata;
            this.Genere = Genere;
        }

        //Getters
        public string GetPodcastTitolo() {
            return PodcastTitolo;
        }
        public string GetPodcastProduttore() {
            return PodcastProduttore;
        }
        public string GetEpisodioTitolo() {
            return EpisodioTitolo;
        }
        public uint GetEpisodioDurata() {
            return EpisodioDurata;
        }
        public string GetPodcastHost() {
            string ListaHost = "";
            foreach (var Host in PodcastHost) {
                ListaHost += Host + " ";
            }
            return ListaHost;
        }

        public string GetGenere() {
            string ListaGeneri = "";
            foreach (var genere in Genere) {
                ListaGeneri += genere + " ";
            }
            return ListaGeneri;
        }


        //Setters
        public void SetPodcastNome(string titolo) {
            if (string.IsNullOrWhiteSpace(titolo)) {
                throw new Exception();
            } else {
                PodcastTitolo = titolo;
            }
        }
        public void SetPodcastHost(List<string> listaHost) {
            PodcastHost = listaHost;
        }
        public void SetPodcastProduttore(string Produttore) {

            if (string.IsNullOrWhiteSpace(Produttore)) {
                throw new Exception();
            } else {
                PodcastProduttore = Produttore;
            }
        }
        public void SetEpisodioTitolo(string EpisodioTitolo) {
            if (string.IsNullOrWhiteSpace(EpisodioTitolo)) {
                throw new Exception();
            } else {
                this.EpisodioTitolo = EpisodioTitolo;
            }
        }
        public void SetEpisodioDurata(uint EpisodioDurata) {
            this.EpisodioDurata = EpisodioDurata;
        }
        public void SetGenere(List<string> Genere) {
            this.Genere = Genere;
        }


        //Metodi
        public void Play() {
            Console.WriteLine("Riproduzione del Podcast: " + PodcastTitolo + " di " + GetPodcastHost() + "episodio " + EpisodioTitolo);
        }
        public void Pause() {
            Console.WriteLine(EpisodioTitolo + " è stato messo in pausa");
        }
        public void Stop() {
            Console.WriteLine(EpisodioTitolo + " è stato fermato");
        }
        public override string ToString() {
            string Print = "------------------------------------\n";
            Print += "Scheda Podcast\n";
            Print += "Podcast nome: " + PodcastTitolo + "\n";
            Print += "Hosts: " + GetPodcastHost() + "\n";
            Print += "Produttore: " + PodcastProduttore+"\n";
            Print += "Titolo dell' episodio: " + EpisodioTitolo + "\n";
            Print += "Genere: " + GetGenere() + "\n";
            Print += "Durata: " + EpisodioDurata + " secondi\n";
            Print += "------------------------------------\n";
            return Print;
        }
    }
}
