// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace LMCBeta2
{

    public class Item
    {
        public string Book_id
        {
            get { return book_id; }
            set { book_id = value; }
        }
        public string Book_name
        {
            get { return book_name; }
            set { book_name = value; }
        }
        public int Book_left
        {
            get { return book_left; }
            set { book_left = value; }
        }
        public string Book_author
        {
            get { return book_author; }
            set { book_author = value; }
        }
        public string Book_publisher
        {
            get { return book_publisher; }
            set { book_publisher = value; }
        }
        public int Book_saletime
        {
            get { return book_saletime; }
            set { book_saletime = value; }
        }
        public int Book_status
        {
            get { return book_status; }
            set { book_status = value; }
        }

        public string Book_status_display
        {
            get { return book_status_display; }
            set { book_status_display = value; }
        }

        private string book_id;
        private string book_name;
        private int book_left;
        private string book_author;
        private string book_publisher;
        private int book_saletime;
        private int book_status;
        private string book_status_display;
    }
}
