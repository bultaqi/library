using System;
using System.Collections.Generic;

namespace library_demo {
    public class Library {


        public Library(int capacityParam, string libraryNameParam){
            _capacity = capacityParam;
            Name = libraryNameParam;
        }
        public string Name {get; set;}

        public bool Restrooms { get; set;}

        public string Address {get; set;}

        private int _capacity {get; set;}

        private List<Book> _inventory  {get; set;} = new List<Book>();

        public void AddBook(Book bookToAdd){
            if(_inventory.Count < _capacity){
                 _inventory.Add(bookToAdd);
            } else {
                Console.WriteLine("No can do, the library is full");
            }

        }

        public void PrintInventory(){
            _inventory.ForEach(book => Console.WriteLine(book.Title));
        }

    }
}