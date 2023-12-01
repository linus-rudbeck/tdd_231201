using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_231201.Musically
{
    public class PlaylistEmptyException() 
        : Exception("The playlist is empty")
    {
    }
}
