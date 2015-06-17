/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {

        var books = [],
            categories = {},
            lastBookId = 2,
            lastCategoryId = 2,
            hasCategory = false;

        function listBooks(input) {
            var result = [];

            if (!input) {
                if (books.length === 0) {
                    return [];
                } else {
                    return books.sort(function (firstBook, secondBook) {
                        return firstBook.ID - secondBook.ID;
                    });
                }
            }

            for (var cat in categories) {
                if (cat === input.category) {
                    hasCategory = true;
                    break;
                }
            }

            if (!hasCategory) {
                return [];
            }

            var currentCategory = input.category;

            if (!currentCategory) {
                return [];
            }

            result = categories[currentCategory];

            if (!result && result.length === 0) {
                return [];
            } else {
                return result;
            }
        }

        function addBook(book) {
            var titles = [],
                isbns = [],
                category,
                arrayOfCategories = [];

            if (!book.title || !book.author || !book.isbn || !book.category) {
                throw new Error('No title, author, isbn or category.');
            }

            if (book.title.length < 2 || book.title.length >= 100) {
                throw new Error('Invalid title length.');
            }

            if (book.category.length < 2 || book.category.length >= 100) {
                throw new Error('Invalid category length.');
            }

            if (book.isbn.length !== 13 && book.isbn.length !== 10) {
                throw new Error('Invalid isbn length');
            }

            titles = books.reduce(function (result, book) {
                result.push(book.title);
                return result;
            }, []);

            if (titles.indexOf(book.title) >= 0) {
                throw new Error('There is book with this title.');
            }

            isbns = books.reduce(function (result, book) {
                result.push(book.isbn);
                return result;
            }, []);

            if (isbns.indexOf(book.isbn) >= 0) {
                throw new Error('Book with same ISBN already exists.');
            }

            book.ID = lastBookId;

            category = {id: lastCategoryId, categoryName: book.category};

            lastCategoryId += 1;

            for (var cat in categories) {
                arrayOfCategories.push(cat);
            }

            if (arrayOfCategories.indexOf(category) >= 0) {
                categories[category.categoryName].push(book);
            } else {
                categories[category.categoryName] = [];
                categories[category.categoryName].push(book);
            }

            lastBookId += 1;

            books.push(book);

            return book;
        }

        function listCategories() {
            var arrayOfCategories = [];

            for (var cat in categories) {
                arrayOfCategories.push(cat);
            }

            arrayOfCategories = arrayOfCategories.sort(function (a, b) {
                return a.id - b.id;
            });

            return arrayOfCategories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}

module.exports = solve;
