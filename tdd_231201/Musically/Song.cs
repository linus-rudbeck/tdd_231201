﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_231201.Musically
{
    public class Song(int id, string title)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
    }
}
