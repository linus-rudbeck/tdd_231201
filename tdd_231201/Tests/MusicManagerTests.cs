using Moq;
using NUnit.Framework;
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
            var song = new Song(1, "Inferno") ;

            // Act
            musicManager.AddSongToPlaylist(song);

            // Assert (verify)
            playlistMock.Verify(p => p.AddSong(song), Times.Once);
        }

        [Test]
        public void RemoveSongFromPlaylist_Calls_RemoveSongOnPlaylist()
        {
            // Arrange
            var playlistMock = new Mock<IPlaylist>();
            var musicManager = new MusicManager(playlistMock.Object);
            var songId = 1;

            // Act
            musicManager.RemoveSongFromPlaylist(songId);

            // Assert (verify)
           playlistMock.Verify(p => p.RemoveSong(songId), Times.Once);
        }

        [Test]
        public void PlayCurrentSong_Calls_RemoveSongFromPlaylist_AndReturnsTitle()
        {
            // Arrange
            var playlistMock = new Mock<IPlaylist>();
            var musicManager = new MusicManager(playlistMock.Object);

            var song = new Song(1, "Inferno");
            playlistMock.Setup(p => p.GetCurrentSong()).Returns(song);

            // Act
            musicManager.AddSongToPlaylist(song);
            var songTitle = musicManager.PlayCurrentSong();

            // Assert
            playlistMock.Verify(p => p.GetCurrentSong(), Times.Once);
            playlistMock.Verify(p => p.RemoveSong(1), Times.Once);
            Assert.That(songTitle, Is.EqualTo("Inferno"));
        }
    }
}
