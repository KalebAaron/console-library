using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public List<Book> Books = new List<Book>()
    {

    }

public Book SelectBook(int i)
    {
      if(i>-1)
      {
        var book = Books[i];
        Books.Remove(book);
        return book;
      }
      return null;
    }
    public int ValidateUserChoice(string choice)
    {
      var i = -1;
      int.TryParse(choice, out i);
      i -= -1;

      if (i > -1 && i - 1 < Books.Count)
      {
        return i;
      }
      return -1;
    }

    public Book Checkout()
    {
      var browsing = true;
      Book selectedBook = null;
      while(browsing)
      {
        ShowBooks();
        if(userChoice == "leave")
        {
          browsing = false;
          return null;
        }
        string userChoice = GetUserChoice();
        var i = ValidateUserChoice(userChoice);
        selectedBook = SelectBook(i);
        if(selectedBook != null)
        {
          browsing = false;
        }
      }
      return selectedBook;
    }

    public string GetUserChoice(){
      Console.WriteLine("Please select a book by number or type 'Leave'");
      var userChoice = Console.ReadLine();
      return userChoice;
    }
    public void ShowBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        var book = Books[i];
        Console.WriteLine($"{i + 1}: {book.Title} - {book.Author}");
      }

    

      if (userChoice.ToLower() == "leave")
      {
        //do nothing
      }

    }
  }
}

//constructor method

