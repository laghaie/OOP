using Library;
using OOP.Application.Implements;
using OOP.Domain.Enities;
using OOP.Domain.Interfaces;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student st = new Student(name: "Ali", lastName: "Rezaie", nationalId: "0010012030");
            ////st.NationalId = "0010012030";
            ////st.Name = "Ali";
            ////st.LastName = "Rezaie";
            //st.FeildOfStudy = Enums.FeildOfStudy.Computer;
            //st.Gender = true;
            //st.DateOfBirth = DateOnly.Parse("1990/01/01");
            //st.YearOfArrival = DateTime.Now;
            //st.Height = 180;
            //st.Interest = new List<string>
            //{
            //    "Sports","Music"
            //};
            //st.Score = new List<double>
            //{
            //    15,12.5,20,20
            //};

            //var average = st.GetAverage();

            //Console.WriteLine($"Average is: {average} - Student: {st.Name} {st.LastName}");

            //Test test = new Test();
            //test.Id = 10000;

            //Book book1 = new Book();
            //var book1 = new Book();
            Book book1 = new("Love Story", "Erich", "Segal");

            //book1.Pages = -20;

            //Utils.Print(book1.Pages.ToString());

            //book1.SetPages(-10);
            //Utils.Print(book1.GetPages().ToString());

            book1.Pages = -100;
            Utils.Print(book1.Pages.ToString());

            //book1.AuthorFullName = ""; Error

            Utils.Print(book1.AuthorFullName);

            DigitalBook digiBook = new("Love Story", "Erich", "Segal");
            digiBook.FileFomrat = "PDF";

            digiBook.DisplayInfo();

            //IReservable reservable = new IReservable();

            //book1.DisplayInfo();


            ILogger loggerConsole = new LogConsole();
            ILogger loggerFile = new LogFile("log.txt");

            loggerConsole.Log("Test");
            loggerFile.Log("Test");
        }
    }
}
