namespace SqliteManipulation
{
    using System;
    using System.Data.SQLite;
    using System.IO;

    public class EntryPoint
    {
        private static string currentDirectory = Directory.GetCurrentDirectory();

        public static void Main()
        {
            // Uncomment if you don't have books table in your database books.
            // CreateTableBooksInDatabase();

            Book bookToAdd = new Book
            {
                Title = "C# Title",
                Author = "C# Author",
                ISBN = "1234567891"
            };

            Console.WriteLine("All books in database:");
            SelectAllBooks();

            AddBookToDatabase(bookToAdd);

            Console.WriteLine("Books after addition:");
            SelectAllBooks();

            Console.WriteLine("Selected books:");
            SelectBooksByName("C#");
        }

        private static void AddBookToDatabase(Book bookToAdd)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + currentDirectory + "\\..\\..\\..\\books.db" + ";Version=3;");

            connection.Open();

            using (connection)
            {
                SQLiteCommand insertcommand = new SQLiteCommand(
                    "INSERT INTO books (Title, Author, PublishDate, ISBN) VALUES(@title, @author, @date, @isbn)",
                    connection);

                insertcommand.Parameters.AddWithValue("@title", bookToAdd.Title);
                insertcommand.Parameters.AddWithValue("@author", bookToAdd.Author);
                insertcommand.Parameters.AddWithValue("@date", DateTime.Now);
                insertcommand.Parameters.AddWithValue("@isbn", bookToAdd.ISBN);

                insertcommand.ExecuteNonQuery();
            }
        }

        private static void SelectAllBooks()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + currentDirectory + "\\..\\..\\..\\books.db" + ";Version=3;");

            SQLiteDataReader reader;
            connection.Open();

            using (connection)
            {
                SQLiteCommand selectAllBooks = new SQLiteCommand("SELECT * FROM books", connection);

                reader = selectAllBooks.ExecuteReader();
                PrintAllBooksInReader(reader);
            }

            Console.WriteLine("-----");
        }

        private static void SelectBooksByName(string pattern)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + currentDirectory + "\\..\\..\\..\\books.db" + ";Version=3;");

            SQLiteDataReader reader;

            connection.Open();

            using (connection)
            {
                SQLiteCommand selectBooksByTitle =
                    new SQLiteCommand("SELECT * FROM books WHERE Title LIKE '%" + pattern + "%'", connection);

                reader = selectBooksByTitle.ExecuteReader();
                PrintAllBooksInReader(reader);
            }

            Console.WriteLine("-----");
        }

        private static void PrintAllBooksInReader(SQLiteDataReader reader)
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

        private static void CreateTableBooksInDatabase()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + currentDirectory + "\\..\\..\\..\\books.db" + ";Version=3;");

            connection.Open();

            using (connection)
            {
                SQLiteCommand createTable = new SQLiteCommand(
                    "CREATE TABLE books (BookId NUMBER unique primary key, Title TEXT, Author TEXT, PublishDate date, ISBN TEXT)",
                    connection);

                createTable.ExecuteNonQuery();
            }
        }
    }
}
