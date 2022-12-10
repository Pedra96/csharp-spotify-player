
using Spotify_Player;

Brano Brano = new("Toxicity", 180, "System of a down", new List<string> { "Nu metal" });
Podcast Podcast = new("Lorem Ipsum", new List<string> { "Marco", "Giovanni", "Giorgio" }, "Sev Stez","Hello World", 254,
    new List<string> { "Comicità", "Fiction", "Musica", "Just Talking" });
List<IContenutoRiproducibile> lista = new() { Brano, Podcast };

Brano.Play();
Brano.Stop();
Brano.Pause();

Console.WriteLine(Brano);

Podcast.Play();
Podcast.Stop();
Podcast.Pause();

Console.WriteLine(Podcast);

foreach(var elemento in lista) {
    if (elemento is Brano)
        {
        Brano ElementoCast=(Brano)elemento;
        Console.WriteLine(ElementoCast);
        }else if(elemento is Podcast) {
        Podcast ElementoCast = (Podcast)elemento;
        Console.WriteLine(ElementoCast);
    }
}