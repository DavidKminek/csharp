﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        public BookGenre Genre { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime BorrowedTime { get; set; }
        public User BorrowedBy { get; set; }
        public object Id { get; }
        public object Releasedate { get; }
        public BookGenre Genre1 { get; }

        public Book(int iD, string name, string Author, DateTime releaseDate, BookGenre genre)
        {
            ID= iD;
            Name = name;
            ReleaseDate = releaseDate;
            Genre = genre;

        }

        public Book(object id, string name, object releasedate, string author, BookGenre genre)
        {
            Id = id;
            Name = name;
            Releasedate = releasedate;
            Author = author;
            Genre1 = genre;
        }

        public override string ToString()
        {
            if (IsBorrowed)
                return $"{Name.PadRight(15, ' ')}{BorrowedBy.FullName.PadRight(15, ' ')}{BorrowedTime.ToString().PadRight(15, ' ')}";
            else 
                return $"{Name.PadRight(15,' ')}";
        }








    }


    public enum BookGenre
    {
        Scifi,
        Comedy,
        Cartoon,
        Comix
    }
}
