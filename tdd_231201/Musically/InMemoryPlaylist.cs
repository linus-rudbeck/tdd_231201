using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_231201.Musically
{
    internal class InMemoryPlaylist : IPlaylist
    {
        private readonly List<Song> _playlist = new List<Song>();

        public int SongCount { get { return _playlist.Count; } }

        public void AddSong(Song song)
        {
            _playlist.Add(song);
        }

        public Song GetCurrentSong()
        {
            if(SongCount == 0)
            {
                throw new PlaylistEmptyException();
            }

            return _playlist.First();
        }

        public void RemoveSong(int songId)
        {
            var song = _playlist.Find(s => s.Id == songId);
            
            if (song != null)
            {
                _playlist.Remove(song);
            }
        }

    }
}
