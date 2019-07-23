namespace library
{
    internal class Movie : Digital
    {

        private string rating;

        public Movie(string name, bool downloadable, string rating) :
            base(name, downloadable)
        {
            this.rating = rating;
        }


        public string Rating {

            get {return rating;}
            set {rating = value;}

        }

        public override string ToString()
        {
            return Name + " is " + (Downloadable ? "" : "not ") + "downloadable.\nIt's rating is " + rating + ".\n";
        }
    }
}