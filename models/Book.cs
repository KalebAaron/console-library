namespace console_library.Models
{
  public class Book
  {
    public string Title;
    public string Author;
    public string BelongsTo;

    //constructor method
    public Book(string title, string author, string belongsTo)
    {
        Title = title;
        Author = author;
        BelongsTo = belongsTo;
    }
  }
}