using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_231201.Musically;

namespace tdd_231201.Tests
{
    [TestFixture]
    internal class InMemoryPlaylistTests
    {
        [Test]
        public void TestAddSongAndCount()
        {
            // Arrange
            var inMemoryPlaylist = new InMemoryPlaylist();
            var song = new Song(1, "Inferno");

            // Act
            inMemoryPlaylist.AddSong(song);
            var result = inMemoryPlaylist.SongCount;

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void TestRemoveSongAndCount()
        {
            // Arrange
            var inMemoryPlaylist = new InMemoryPlaylist();
            var song1 = new Song(1, "Inferno");
            var song2 = new Song(2, "Sandstorm");

            // Act
            inMemoryPlaylist.AddSong(song1);
            inMemoryPlaylist.AddSong(song2);
            inMemoryPlaylist.RemoveSong(1);
            var herrnillson = inMemoryPlaylist.SongCount;

            // Assert
            Assert.That(herrnillson, Is.EqualTo(1));
        }

        [Test]
        public void TestGetCurrentSong_WhenEmpty_ThrowException()
        {
            // Arrange
            var inMemoryPlaylist = new InMemoryPlaylist();

            // Act
            // ...

            // Assert
            Assert.Throws<PlaylistEmptyException>(() => inMemoryPlaylist.GetCurrentSong());
        }

        [Test]
        public void TestGetCurrentSong_WhenNotEmpty_ReturnSong()
        {
            // Arrange
            var inMemoryPlaylist = new InMemoryPlaylist();
            var song = new Song(1, "Inferno");
            inMemoryPlaylist.AddSong(song);

            // Act
            var result = inMemoryPlaylist.GetCurrentSong();

            // Assert
            Assert.That(result, Is.EqualTo(song));
        }
    }
}
