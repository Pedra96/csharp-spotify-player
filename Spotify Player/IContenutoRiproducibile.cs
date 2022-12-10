using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player {
    public interface IContenutoRiproducibile {

        public void Play();
        public void Pause();
        public void Stop();
    }
}
