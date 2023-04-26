using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
