using Moq;
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
    internal class MusicManagerTests
    {

        [Test]
        public void AddSongToPlaylist_CallsAddSongOnPlaylist()
        {
            // Arrange
            var playlistMock = new Mock<IPlaylist>();
            var musicManager = new MusicManager(playlistMock.Object);
            var song = new Song() { Id = 1, Title = "Inferno" };

            // Act
            musicManager.AddSongToPlaylist(song);

            // Assert (verify)
            playlistMock.Verify(p => p.AddSong(song), Times.Once);
        }
    }
}
