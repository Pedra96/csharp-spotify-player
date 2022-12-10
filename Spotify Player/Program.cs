
using Spotify_Player;

Brano Brano = new("Toxicity", 180, "System of a down", new List<string> { "metal", "rock", "punk" });

Brano.Play();
Brano.Stop();
Brano.Pause();

Console.WriteLine(Brano);