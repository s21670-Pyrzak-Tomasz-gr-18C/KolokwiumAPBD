using System.Collections.Generic;

namespace KolokwiumAPBD.Models
{
    public class MiusicLabel
    {
        public int IdMusicLabel { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MusicianTrack> Albums { get; set; }
    }
}
