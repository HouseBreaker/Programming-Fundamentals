namespace _05.Book_Library
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public static class BookLibrary
	{
		public static void Main(string[] args)
		{
			var numberOfBooks = int.Parse(Console.ReadLine());

			var library = new Library("Prosveta");
			for (int i = 0; i < numberOfBooks; i++)
			{
				var book = ParseBookDetails(Console.ReadLine().Split());
				library.AddBook(book);
			}

			var pricesByAuthor = new Dictionary<string, double>();
			foreach (var author in library.Books.Select(a => a.Author))
			{
				pricesByAuthor[author] = library.Books.Where(a => a.Author == author).Select(a => a.Price).Sum();
			}

			pricesByAuthor = pricesByAuthor.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
			foreach (var authorAndPrice in pricesByAuthor)
			{
				Console.WriteLine($"{authorAndPrice.Key} -> {authorAndPrice.Value:F2}");
			}
		}

		private static Book ParseBookDetails(string[] tokens)
		{
			var title = tokens[0];
			var author = tokens[1];
			var publisher = tokens[2];
			var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", null);
			var isbn = tokens[4];
			var price = double.Parse(tokens[5]);

			var book = new Book(title, author, publisher, releaseDate, isbn, price);
			return book;
		}
	}

	public class Library
	{
		private IList<Book> books;

		public Library(string name)
			: this(name, new List<Book>())
		{
		}

		public Library(string name, IEnumerable<Book> books)
		{
			this.Name = name;
			this.Books = books;
		}

		public string Name { get; set; }

		public IEnumerable<Book> Books
		{
			get
			{
				return new List<Book>(this.books);
			}

			private set
			{
				this.books = new List<Book>(value);
			}
		}

		public void AddBook(Book book)
		{
			this.books.Add(book.Clone());
		}

		public void AddBooks(IEnumerable<Book> booksToAdd)
		{
			foreach (var book in booksToAdd)
			{
				this.AddBook(book.Clone());
			}
		}
	}

	public class Book
	{
		public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, double price)
		{
			this.Title = title;
			this.Author = author;
			this.Publisher = publisher;
			this.ReleaseDate = releaseDate;
			this.Isbn = isbn;
			this.Price = price;
		}

		public string Title { get; set; }

		public string Author { get; set; }

		public string Publisher { get; set; }

		public DateTime ReleaseDate { get; set; }

		public string Isbn { get; set; }

		public double Price { get; set; }

		public Book Clone()
		{
			return new Book(this.Title, this.Author, this.Publisher, this.ReleaseDate, this.Isbn, this.Price);
		}
	}
}