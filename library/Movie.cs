namespace library
{
    internal class Movie : Digital
    {


        public Movie(string name, bool downloadable) :
            base(name, downloadable)
        {
        }

        public override string ToString()
        {
            return Name + " is " + (Downloadable ? "" : "not ") + "downloadable.\n";
        }
    }
}