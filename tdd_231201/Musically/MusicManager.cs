using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_231201.Musically
{
    /// <summary>
    /// Class for managing and updating a playlist
    /// </summary>
    internal class MusicManager
    {
        private readonly IPlaylist _playlist;

        public MusicManager(IPlaylist playlist)
        {
            _playlist = playlist;
        }

        public void AddSongToPlaylist(Song song)
        {
            // 1. Kolla så låten finns
            // 2. Kontrollera att låten inte är korrupt
            // 3. Kolla så låten inte är bannad
            // 4. Kolla så låten passa målgruppen

            _playlist.AddSong(song);
        }


    }
}
