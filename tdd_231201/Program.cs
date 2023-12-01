// See https://aka.ms/new-console-template for more information
using tdd_231201.Musically;

// Setup
var playlist = new InMemoryPlaylist();
var musicManager = new MusicManager(playlist);

// Create songs
var inferno = new Song(1, "Inferno");
var sandstorm = new Song(2, "Sandstorm");

// Add to playlist
musicManager.AddSongToPlaylist(inferno);
musicManager.AddSongToPlaylist(sandstorm);

// Play all songs
try
{
    for (int i = 1; i < 10; i++)
    {
        var title = musicManager.PlayCurrentSong();
        Console.WriteLine($"{i}. {title}");
    }
}
catch (PlaylistEmptyException)
{
    Console.WriteLine("Spellistan är tom");
}