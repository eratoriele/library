using System;

namespace library
{
    internal abstract class Book
    {

        private string bookName;
        private string writtenIn;
        private string writtenBy;
        private int pageCount;

        public Book(string bookName, string writtenIn, string writtenBy, int pageCount)
        {
            this.bookName = bookName;
            this.writtenIn = writtenIn;
            this.writtenBy = writtenBy;
            this.pageCount = pageCount;
        }


        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string WrittenIn
        {
            get { return writtenIn; }
            set { writtenIn = value; }
        }

        public string WrittenBy
        {
            get { return writtenBy; }
            set { writtenBy = value; }
        }

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

    }
}
