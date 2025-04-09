using System;

class PrintedEdition
{
    public string Title;
    public int Year;

    public PrintedEdition(string title, int year)
    {
        Title = title;
        Year = year;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Назва: {Title}, Рік: {Year}");
    }
}

class Magazine : PrintedEdition
{
    public int IssueNumber;

    public Magazine(string title, int year, int issueNumber)
        : base(title, year)
    {
        IssueNumber = issueNumber;
    }

    public override void Show()
    {
        Console.WriteLine($"[Журнал] Назва: {Title}, Рік: {Year}, Номер випуску: {IssueNumber}");
    }
}

class Book : PrintedEdition
{
    public string Author;

    public Book(string title, int year, string author)
        : base(title, year)
    {
        Author = author;
    }

    public override void Show()
    {
        Console.WriteLine($"[Книга] Назва: {Title}, Автор: {Author}, Рік: {Year}");
    }
}

class Textbook : Book
{
    public string Subject;

    public Textbook(string title, int year, string author, string subject)
        : base(title, year, author)
    {
        Subject = subject;
    }

    public override void Show()
    {
        Console.WriteLine($"[Підручник] Назва: {Title}, Автор: {Author}, Рік: {Year}, Предмет: {Subject}");
    }
}

class Program
{
    static void Main()
    {
        PrintedEdition[] library = new PrintedEdition[5];

        library[0] = new Magazine("Наука і життя", 2022, 5);
        library[1] = new Book("Майстер і Маргарита", 1967, "Булгаков");
        library[2] = new Textbook("Математика", 2020, "Іваненко", "Алгебра");
        library[3] = new Magazine("Forbes", 2023, 12);
        library[4] = new Textbook("Фізика", 2021, "Петренко", "Механіка");

        // Сортуємо за роком видання
        Array.Sort(library, (a, b) => a.Year.CompareTo(b.Year));

        // Виводимо всі видання
        Console.WriteLine("Список друкованих видань (відсортовано за роком):\n");
        foreach (PrintedEdition item in library)
        {
            item.Show();
        }
    }
}
