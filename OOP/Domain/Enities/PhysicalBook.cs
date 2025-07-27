using OOP.Domain.Interfaces;

namespace OOP.Domain.Enities
{
    public class PhysicalBook : Book, IReservable
    {
        public PhysicalBook(string title, string authorName, string authorLastName)
            : base(title, authorName, authorLastName)
        {
        }

        public void Reserve()
        {

        }
    }
}
