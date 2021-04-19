using System;

namespace library_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int randomNumber = 42;

            Book harryPotterOne = new Book();
            harryPotterOne.Title = "Harry Potter and the Sorcerer's Stone";
            harryPotterOne.Author = "J. K. Rowling";


            Book harryPotterTwo = new Book(){
                Title = "Harry Potter and the Chamber of Secrets",
                Author= "J. K. Rowling"
            };

            Console.WriteLine(harryPotterOne.Title);
            Console.WriteLine(harryPotterOne);

            Library marmetLibrary = new Library(5, "Marmet Library");
            // marmetLibrary.Name = "Marmet Library";
            marmetLibrary.Restrooms = false;


            // Won't work!
            // marmetLibrary._inventory.Add(harryPotterOne);

            marmetLibrary.AddBook(harryPotterOne);

            marmetLibrary.PrintInventory();

            Library charlestonLibrary = new Library(100, "Charleston Library");
            // charlestonLibrary.Name = "Charleston Library";


            // const harryPotterOne = {
                // title: "",
                // author: "",
            // }

            // harryPotterOne.title = ""
      
        }
    }
}
