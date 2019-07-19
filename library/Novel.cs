namespace library
{
    internal class Novel : Book
    {

        private string ISBN;

        public Novel(string bookName, string writtenBy, string ISBN) : 
            base(bookName, writtenBy)
        {

            this.ISBN = ISBN;

        }

        public override string ToString()
        {
            return BookName + " was written by " + WrittenBy + ".\nISBN number:" + ISBN + ".\n";
        }
    }
}