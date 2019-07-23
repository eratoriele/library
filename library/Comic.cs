namespace library
{
    internal class Comic : Book
    {

        private int numOfPages;

        public Comic(string bookName, string writtenBy, int numOfPages) :
            base(bookName, writtenBy)
        {
            this.numOfPages = numOfPages;
        }


        public int NumOfPages {
            
            get { return numOfPages;}
            set { numOfPages = value;}

        }

        public override string ToString()
        {
            return BookName + " was written by " + WrittenBy + ".\nHas " + numOfPages + " pages.\n";
        }
    }
}