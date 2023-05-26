namespace Ex1
{
    class LibraryItem
    {
        protected string Title;
        protected string Author;
        protected int PublicationYear;

        public LibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public LibraryItem()
        {
        }

        public void Input()
        {
            Console.Write("Nhap title: ");
            Title = Console.ReadLine();
            Console.Write("Nhap Author: ");
            Author = Console.ReadLine();
            Console.Write("Nhap PublicationYear: ");
            PublicationYear = Convert.ToInt32(Console.ReadLine());
        }

        public virtual String ToString()
        {
            return "Title is: " + Title + "\nAuthor is: " + Author + "\nPublicationYear is: " + PublicationYear;
        }
    }

    class Book : LibraryItem
    {
        protected int Page;

        public Book()
        {
        }
        public void InputPage()
        {
            Console.Write("Nhap so trang: ");
            Page = Convert.ToInt32(Console.ReadLine());

        }

        public override String ToString()
        {
            return "Title is: " + Title + "\nAuthor is: " + Author + "\nPublicationYear is: " + PublicationYear+ "\nPage is: "+Page;
        }
    }

    class Magazine : LibraryItem
    {
        protected string Id;

        public Magazine()
        {
        }

        public void InputId()
        {
            Console.WriteLine("Nhap id: ");
            Id = Console.ReadLine();
        }

        public override String ToString()
        {
            return "Title is: " + Title + "\nAuthor is: " + Author + "\nPublicationYear is: " + PublicationYear + "\nId is: " + Id;

        }
    }
    
    class DVD : LibraryItem
    {
        protected string Category;

        public DVD()
        {
        }

        public void InputCatogery()
        {
            Console.WriteLine("Nhap the loai: ");
            Category = Console.ReadLine();
        }

        public override string ToString()
        {
            return "Title is: " + Title + "\nAuthor is: " + Author + "\nPublicationYear is: " + PublicationYear + "\nCategory is: " + Category;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Input();
            b.InputPage();
            Console.WriteLine(b.ToString());
            Magazine m = new Magazine();
            m.Input();
            m.InputId();
            Console.WriteLine(m.ToString());
            DVD d = new DVD();
            d.Input();
            d.InputCatogery();
            Console.WriteLine(d.ToString());

        }
    }
}