using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibarySystem.Core.Interfaces;

namespace LibarySystem.Core.Objects {

    public class Book : IBook {

        public Book(int id, string name, string author, int releaseDate) {
            ID = id;
            Name = name;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public int ID { get; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }

        public override string ToString() {
            return "Book " + this.Name.ToString() + " Author: " + this.Author.ToString() + " Release date: " +
                    this.ReleaseDate.ToString() + ". This book has ID: " + this.ID.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable) this).GetEnumerator();
        }

    }

}