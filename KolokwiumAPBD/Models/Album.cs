using System;
using System.Collections.Generic;

namespace KolokwiumAPBD.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public int IdMiusicLabel { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
