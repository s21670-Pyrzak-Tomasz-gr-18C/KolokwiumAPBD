namespace KolokwiumAPBD.Models
{
    public class Album
    {
        public virtual Musician Musican { get; set; }
        public virtual Track Track { get; set; }
    }
}
