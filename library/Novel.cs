namespace library
{
    internal class Novel : Book
    {
        public Novel(string bookName, string writtenIn, string writtenBy, int pageCount) : 
            base(bookName, writtenIn, writtenBy, pageCount)
        {
        }

        public override string ToString()
        {
            return BookName + " was written by " + WrittenBy + " in " + WrittenIn + ".\nIt is " + PageCount + " pages long.\n";
        }
    }
}