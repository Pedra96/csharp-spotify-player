using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player {
    public static class Function {
        public static void TrovaERiproduci(string trovaOggetto,List<IContenutoRiproducibile> lista) {
            bool Flag = false;
            foreach (var contenuto in lista) {
                if (contenuto is Brano) {
                    var contenutoBrano = (Brano)contenuto;
                    if (contenutoBrano.GetTitoloBrano().ToLower() == trovaOggetto.ToLower()) {
                        contenutoBrano.Play();
                        Thread.Sleep(1000);
                        contenutoBrano.Pause();
                        Thread.Sleep(1000);
                        contenutoBrano.Stop();
                        Thread.Sleep(1000);
                        Flag = true;
                        break;
                    }
                } else if (contenuto is Podcast) {
                    var ContenutoPodcast = (Podcast)contenuto;
                    if (ContenutoPodcast.GetEpisodioTitolo().ToLower() == trovaOggetto.ToLower()) {
                        ContenutoPodcast.Play();
                        Thread.Sleep(1000);
                        ContenutoPodcast.Pause();
                        Thread.Sleep(1000);
                        ContenutoPodcast.Stop();
                        Thread.Sleep(1000);
                        Flag = true;
                        break;
                    }
                }
            }
            if (Flag == false) {
                Console.WriteLine("Titolo non trovato");
                Thread.Sleep(1000);
            }
        }
       public static void SanificatoreInput(string Attributo, string? Input, IContenutoRiproducibile Oggetto) {
            while (true) {
                try {
                    if (Oggetto is Brano) {
                        Brano BranoConvertito = (Brano)Oggetto;
                        switch (Attributo) {

                            case "Titolo Brano":
                                BranoConvertito.SetTitoloBrano(Input);
                                break;

                            case "Autore":
                                BranoConvertito.SetAutore(Input);
                                break;

                            case "Feat":
                                Input = Input.ToLower();
                                if (string.IsNullOrEmpty(Input) || Input == "si" || Input == "no") {
                                    BranoConvertito.SetFeat(Input);
                                } else { throw new Exception(); }
                                break;

                            case "Generi":
                                List<string> ListaGeneri = new List<string>();
                                for (int i = 0; i < int.Parse(Input); i++) {
                                    Console.WriteLine("Inserire un Genere");
                                    ListaGeneri.Add(Console.ReadLine());
                                }
                                BranoConvertito.SetGenere(ListaGeneri);
                                break;

                            case "Durata":
                                BranoConvertito.SetDurata(uint.Parse(Input));
                                break;
                        }
                    } else if (Oggetto is Podcast) {
                        Podcast PodcastConvertito = (Podcast)Oggetto;
                        switch (Attributo) {

                            case "Podcast Titolo":
                                PodcastConvertito.SetPodcastNome(Input);
                                break;

                            case "Podcast Hosts":
                                List<string> ListaHosts = new List<string>();
                                for (int i = 0; i < int.Parse(Input); i++) {
                                    Console.WriteLine("Inserire un Host");
                                    ListaHosts.Add(Console.ReadLine());
                                }
                                PodcastConvertito.SetPodcastHost(ListaHosts);
                                break;
                            case "Podcast Produttore":
                                PodcastConvertito.SetPodcastProduttore(Input);
                                break;
                            case "Episodio Titolo":
                                PodcastConvertito.SetEpisodioTitolo(Input);
                                break;
                            case "Episodio Durata":
                                PodcastConvertito.SetEpisodioDurata(uint.Parse(Input));
                                break;
                            case "Generi":
                                List<string> ListaGeneri = new List<string>();
                                for (int h = 0; h < int.Parse(Input); h++) {
                                    Console.WriteLine("Inserire un Genere");
                                    ListaGeneri.Add(Console.ReadLine());
                                }
                                PodcastConvertito.SetGenere(ListaGeneri);
                                break;
                        }
                    }
                    break;

                }
                catch (FormatException) {
                    Console.WriteLine("non hai inserito un numero,inserire nuovo valore:");
                    Input = Console.ReadLine();
                }
                catch (Exception ex) {
                    Console.WriteLine("Errore reinserire valore:");
                    Input = Console.ReadLine();
                }
            }
        }
    }
}
