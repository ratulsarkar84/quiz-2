using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2.Models
{
   public class Books
    {
        SqlConnection conn;
        public Books() { }
        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddBook(Book book)
        {
            conn.Open();
            string query = String.Format("INSERT INTO DataTable VALUES('{0}','{1}','{2}','{3}')", book.Id, book.Name, book.Author, book.Edition);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public ArrayList GetAllBook1()
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = String.Format("Select * FROM DataTable");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(book);
            }

            conn.Close();
            return books;
        }
        public ArrayList GetAllBook2(int id)
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = String.Format("Select * FROM DataTable WHERE ID='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(book);
            }

            conn.Close();
            return books;
        }
    }
}
