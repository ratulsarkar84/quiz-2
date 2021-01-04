using Quiz_2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2.Controller
{
   public class BookController
    {
        public static Database db = new Database();
        public static bool AddFood(dynamic book)
        {
            Book r = new Book();
            r.Id = book.Id;
            r.Name = book.Name;
            r.Author = book.Author;
            r.Edition = book.Edition;
            return db.Books.AddBook(r);
        }

        public static ArrayList GetAllBook1()
        {
            return db.Books.GetAllBook1();
        }
        public static ArrayList GetAllBook2(int id)
        {
            return db.Books.GetAllBook2(id);
        }
    }
}
