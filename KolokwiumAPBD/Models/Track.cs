using System.Collections.Generic;

namespace KolokwiumAPBD.Models
{
    public class Track
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; }
        public int IdMiusicAlbuml { get; set; }
        public virtual ICollection<Album> MiusicianTracks { get; set; }
    }
}
