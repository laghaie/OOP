using Library;
using OOP.Domain.Interfaces;

namespace OOP.Domain.Enities
{
    public class DigitalBook : Book, IReservable
    {
        public string FileFomrat {  get; set; }

        public DigitalBook(string title, string authorName, string authorLastName)
            : base(title, authorName, authorLastName)
        {
            
        }

        public override void DisplayInfo()
        {
            //base.DisplayInfo();

            Utils.Print($"FileFomrat is: {FileFomrat}", Library.Enums.PrintState.Success);
        }

        public void Reserve()
        {
            
        }
    }
}
