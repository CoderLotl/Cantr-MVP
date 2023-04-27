using System.Collections.Generic;

namespace Model
{
    public class Book
    {
        string title;
        int id;
        List<Page> pages;

        public Book()
        {

        }

        public Book(string title, int id)
        {
            this.title = title;
            this.id = id;
            this.pages = new List<Page>();
        }
    }
}
