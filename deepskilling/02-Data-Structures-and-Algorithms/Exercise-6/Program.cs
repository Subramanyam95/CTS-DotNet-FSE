using System;

class Book
{
    public int BookId;
    public string Title;
    public string Author;

    public Book(int id, string title, string author)
    {
        BookId = id;
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{BookId} {Title} {Author}");
    }
}

class Program
{
    // Linear Search
    static Book LinearSearch(Book[] books, string title)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }
        return null;
    }

    // Binary Search
    static Book BinarySearch(Book[] books, string title)
    {
        int low = 0;
        int high = books.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            int result = string.Compare(books[mid].Title, title, true);

            if (result == 0)
                return books[mid];
            else if (result < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        // Sorted by Title
        Book[] books =
        {
            new Book(101,"C Programming","Dennis Ritchie"),
            new Book(102,"Data Structures","Mark Allen"),
            new Book(103,"Java","James Gosling"),
            new Book(104,"Python","Guido van Rossum"),
            new Book(105,"SQL","Oracle")
        };

        Console.WriteLine("Linear Search:");
        Book b1 = LinearSearch(books, "Python");

        if (b1 != null)
            b1.Display();
        else
            Console.WriteLine("Book Not Found");

        Console.WriteLine();

        Console.WriteLine("Binary Search:");
        Book b2 = BinarySearch(books, "Python");

        if (b2 != null)
            b2.Display();
        else
            Console.WriteLine("Book Not Found");
    }
}