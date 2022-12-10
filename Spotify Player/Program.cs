
using Spotify_Player;

Brano Brano = new("Toxicity", 180, "System of a down", new List<string> { "Metal", "Rock", "Punk" });
Podcast Podcast = new("Lorem Ipsum", new List<string> { "Marco", "Giovanni", "Giorgio" }, "Sev Stez","Hello World", 254, new List<string> { "Comicità", "Fiction", "Musica", "Just Talking" });


Brano.Play();
Brano.Stop();
Brano.Pause();

Console.WriteLine(Brano);

Podcast.Play();
Podcast.Stop();
Podcast.Pause();

Console.WriteLine(Podcast);