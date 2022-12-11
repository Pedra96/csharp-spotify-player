
using Spotify_Player;

Brano Brano = new("Toxicity", 180, "System of a down", new List<string> { "Nu metal" });
Podcast Podcast = new("Lorem Ipsum", new List<string> { "Marco", "Giovanni", "Giorgio" }, "Sev Stez", "Hello World", 254,
    new List<string> { "Comicità", "Fiction", "Musica", "Just Talking" });
List<IContenutoRiproducibile> lista = new() { Brano, Podcast };
string[] ArrayAttributiPodcast = new[] { "Podcast Titolo", "Podcast Hosts", "Podcast Produttore", "Episodio Titolo", "Episodio Durata", "Generi" };
string[] ArrayAttributiBrano = new[] { "Titolo Brano", "Autore", "Feat", "Generi", "Durata" };

foreach (var elemento in lista) {
    if (elemento is Brano) {
        Brano ElementoCast = (Brano)elemento;
        Console.WriteLine(ElementoCast);
    } else if (elemento is Podcast) {
        Podcast ElementoCast = (Podcast)elemento;
        Console.WriteLine(ElementoCast);
    }
}
do {
    Console.WriteLine("Cosa vuoi aggiungere Brano o Podcast?");
    string ObjectUtente = Console.ReadLine();
    ObjectUtente = ObjectUtente.ToLower();

    if (ObjectUtente == "brano") {
        Console.WriteLine("quanti brani vuoi aggiungere?");
        string NumeroBrani = Console.ReadLine();
        while (true) {
            try {
                int.Parse(NumeroBrani);
                break;
            }
            catch (FormatException) {
                Console.WriteLine("Valore non valido inserire nuovo numero");
                NumeroBrani = Console.ReadLine();
            }
        }
        for (int i = 0; i < int.Parse(NumeroBrani); i++) {
            while (true) {
                Brano BranoUtente = new();
                for (int j = 0; j < ArrayAttributiBrano.Length; j++) {

                    if (ArrayAttributiBrano[j] == "Generi") {
                        Console.WriteLine("quanti " + ArrayAttributiBrano[j] + " ha?");
                        Function.SanificatoreInput(ArrayAttributiBrano[j], Console.ReadLine(), BranoUtente);
                    } else if (ArrayAttributiBrano[j] == "Feat") {
                        Console.WriteLine("il brano ha un Feat Si/No?(lasciare vuoto se non si sà)");
                        Function.SanificatoreInput(ArrayAttributiBrano[j], Console.ReadLine(), BranoUtente);
                    } else {
                        Console.WriteLine("Inserire " + ArrayAttributiBrano[j]);
                        Function.SanificatoreInput(ArrayAttributiBrano[j], Console.ReadLine(), BranoUtente);
                    }
                }

                lista.Add(BranoUtente);
                Console.WriteLine(lista.Last());
                break;

            }
        }
    } else if (ObjectUtente == "podcast") {
        Console.WriteLine("quanti podcast vuoi aggiungere?");
        string NumeroPodcast = Console.ReadLine();
        while (true) {
            try {
                int.Parse(NumeroPodcast);
                break;
            }
            catch (FormatException) {
                Console.WriteLine("Valore non valido inserire nuovo numero");
                NumeroPodcast = Console.ReadLine();
            }
        }
        while (true) {
            for (int i = 0; i < int.Parse(NumeroPodcast); i++) {
                Podcast PodcastUtente = new();
                for (int j = 0; j < ArrayAttributiPodcast.Length; j++) {

                    if (ArrayAttributiPodcast[j] == "Generi" || ArrayAttributiPodcast[j] == "Podcast Hosts") {
                        Console.WriteLine("quanti " + ArrayAttributiPodcast[j] + " ha?");
                        Function.SanificatoreInput(ArrayAttributiPodcast[j], Console.ReadLine(), PodcastUtente);
                    } else {
                        Console.WriteLine("Inserire " + ArrayAttributiPodcast[j]);
                        Function.SanificatoreInput(ArrayAttributiPodcast[j], Console.ReadLine(), PodcastUtente);
                    }
                }

                lista.Add(PodcastUtente);
                Console.WriteLine(lista.Last());
            }
            break;
        }

    } else {}
    Console.WriteLine("Vuoi aggiungere altro? Si/No");
    string InputFlag = Console.ReadLine();
    if (InputFlag.ToLower() != "si") {
        break;
    }
} while (true);
Console.WriteLine("Che cosa vuoi ascoltare?");
string Input = Console.ReadLine();
Function.TrovaERiproduci(Input, lista);

Console.WriteLine("Vuoi stampare tutta la playlist? Si/No");
Input= Console.ReadLine();
if (Input.ToLower() == "si") {
    foreach (var elemento in lista) {
        Console.WriteLine(elemento);
    }
}