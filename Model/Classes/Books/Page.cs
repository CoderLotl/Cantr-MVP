namespace Model
{
    public class Page
    {
        int index;
        int bookID;
        string content;

        public Page()
        {

        }

        public Page(int index, int bookID, string content = "")
        {
            this.index = index;
            this.bookID = bookID;
            this.content = content;
        }

        public int Index { get => index; set => index = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public string Content { get => content; set => content = value; }
    }
}
