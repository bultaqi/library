using System;

namespace library_demo
{
    public class Book
    {
        // readonly property
        public int Id {get; }

        public string Title {get; set;}

        public string Author {get; set;}

        public string Color {get; set;}

        public string ISBN {get; set;}

        public string Genre {get; set;}
    }
}