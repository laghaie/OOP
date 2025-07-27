using Library;

namespace OOP.Domain.Enities
{
    public class Book
    {
        //public string Title;
        //public string Author;

        private string _id;
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFullName
        {
            get
            {
                return $"{AuthorName}_{AuthorLastName}";
            }
        }

        //Field
        private int _pages = 1;
        //Property
        public int Pages
        {
            get => _pages;
            set
            {
                if (value > 0)
                    _pages = value;
            }
        }

        //Setter
        public void SetPages(int pages)
        {
            if (pages > 0)
                _pages = pages;
        }

        //Getter
        public int GetPages()
        {
            return _pages;
        }

        //public Book(string title, string author, int pages)
        //{
        //    Title = title;
        //    Author = author;

        //    if (pages <= 0) 
        //        Pages = 1;
        //}

        //public Book()
        //{
            
        //}

        public Book(string title, string authorName, string authorLastName)
        {
            Title = title;
            AuthorName = authorName;
            AuthorLastName = authorLastName;
        }

        public virtual void DisplayInfo()
        {
            //Utils utils = new();
            Utils.Print($"Title is {Title} and Author is {AuthorName}",
                Library.Enums.PrintState.Warning);
        }
    }
}
