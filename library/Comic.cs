namespace library
{
    internal class Comic : Book
    {


        public Comic(string bookName, string writtenBy) :
            base(bookName, writtenBy)
        {
        }

        public override string ToString()
        {
            return BookName + " was written by " + WrittenBy + ".\n";
        }
    }
}