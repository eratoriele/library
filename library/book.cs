using System;

namespace library
{
    internal abstract class Book
    {

        private string bookName;
        private string writtenBy;

        public Book(string bookName, string writtenBy)
        {
            this.bookName = bookName;
            this.writtenBy = writtenBy;
        }


        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string WrittenBy
        {
            get { return writtenBy; }
            set { writtenBy = value; }
        }

    }
}
