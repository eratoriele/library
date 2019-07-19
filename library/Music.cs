namespace library
{
    internal class Music : Digital
    {

        private string genre;

        public Music(string name, bool downloadable, string genre) :
            base(name, downloadable)
        {
            this.genre = genre;
        }

        public override string ToString()
        {
            return Name + " is in genre of " + genre + " and is " + (Downloadable ? "" : "not ") + "downloadable.\n";
        }
    }
}