using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab12
{
    public class Books

    {

        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public DateTime DateOfRelease { get; set; }

        public static List<Books> GetBooks()
        {

            List<Books> bookList = new List<Books>();

            bookList.Add(new Books
            {

                Id = 1,
                Price = 250.59,

                DateOfRelease = DateTime.Parse("2018-01-12"),

                Title = "Programming in C#"

            });

            bookList.Add(new Books

            {

                Id = 2,

                Price = 170.99,

                DateOfRelease = DateTime.Parse("2018-02-12"),

                Title = "Programming in PHP"

            });

            bookList.Add(new Books

            {

                Id = 3,

                Price = 89.99,

                DateOfRelease = DateTime.Parse("2018-05-14"),

                Title = "Programming in SQL"

            });

            bookList.Add(new Books

            {

                Id = 4,

                Price = 39.99,

                DateOfRelease = DateTime.Parse("2016-08-14"),

                Title = "C# for Dummies"

            });

            bookList.Add(new Books

            {

                Id = 5,

                Price = 99.99,

                DateOfRelease = DateTime.Parse("2017-09-14"),

                Title = "C# for Beginners"

            });

            return bookList;

        }

    }
}