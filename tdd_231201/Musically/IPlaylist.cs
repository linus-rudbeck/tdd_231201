﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_231201.Musically
{
    public interface IPlaylist
    {
        void AddSong(Song song);

        void RemoveSong(int songId);

        Song GetCurrentSong();
    }
}
