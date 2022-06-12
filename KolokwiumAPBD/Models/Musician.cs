using System.Collections.Generic;

namespace KolokwiumAPBD.Models
{
    public class Musician
    {
        public int IdMusican { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public virtual ICollection<Album> MiusicianTracks { get; set; }
    }
}
