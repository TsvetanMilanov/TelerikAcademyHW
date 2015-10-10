namespace MySqlDataManipulation
{
    using MySql.Data.MySqlClient;
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=books; Uid = root; Pwd = 123456123; pooling = true");
            // Uncomment if you don't have books table in your database books.
            // CreateTableBooksInDatabase(connection);

            Book bookToAdd = new Book
            {
                Title = "C# Title",
                Author = "C# Author",
                ISBN = "1234567891"
            };

            Console.WriteLine("All books in database:");
            SelectAllBooks(connection);

            AddBookToDatabase(connection, bookToAdd);

            Console.WriteLine("Books after addition:");
            SelectAllBooks(connection);

            Console.WriteLine("Selected books:");
            SelectBooksByName(connection, "C#");
        }

        private static void AddBookToDatabase(MySqlConnection connection, Book bookToAdd)
        {
            connection.Open();

            using (connection)
            {
                MySqlCommand insertcommand = new MySqlCommand(
                    "INSERT INTO books (Title, Author, PublishDate, ISBN) VALUES(@title, @author, CURDATE(), @isbn)",
                    connection);

                insertcommand.Parameters.AddWithValue("@title", bookToAdd.Title);
                insertcommand.Parameters.AddWithValue("@author", bookToAdd.Author);
                insertcommand.Parameters.AddWithValue("@isbn", bookToAdd.ISBN);

                insertcommand.ExecuteNonQuery();
            }
        }

        private static void SelectAllBooks(MySqlConnection connection)
        {
            MySqlDataReader reader;
            connection.Open();

            using (connection)
            {
                MySqlCommand selectAllBooks = new MySqlCommand("SELECT * FROM books", connection);

                reader = selectAllBooks.ExecuteReader();
                PrintAllBooksInReader(reader);
            }

            Console.WriteLine("-----");
        }

        private static void SelectBooksByName(MySqlConnection connection, string pattern)
        {
            MySqlDataReader reader;

            connection.Open();

            using (connection)
            {
                MySqlCommand selectBooksByTitle =
                    new MySqlCommand("SELECT * FROM books WHERE Title LIKE '%" + pattern + "%'", connection);

                reader = selectBooksByTitle.ExecuteReader();
                PrintAllBooksInReader(reader);
            }

            Console.WriteLine("-----");
        }

        private static void PrintAllBooksInReader(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                string bookTitle = (string)reader["Title"];
                string bookAuthor = (string)reader["Author"];
                DateTime bookPublishDate = (DateTime)reader["PublishDate"];
                string bookIsbn = (string)reader["ISBN"];

                Console.WriteLine("Title: {0}; Author: {1}; Publish Date: {2}; ISBN: {3};", bookTitle, bookAuthor, bookPublishDate, bookIsbn);
            }
        }

        private static void CreateTableBooksInDatabase(MySqlConnection connection)
        {
            connection.Open();

            using (connection)
            {
                MySqlCommand createTable = new MySqlCommand(
                    "CREATE TABLE books (BookId INT unique primary key auto_increment, Title nvarchar(45), Author nvarchar(45), PublishDate date, ISBN nvarchar(45))",
                    connection);

                createTable.ExecuteNonQuery();
            }
        }
    }
}
