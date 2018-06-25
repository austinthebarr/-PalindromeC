using System;
using System.Collections.Generic;

class Palindrome
{
  private string[] _userInput;

  public Palindrome (string[] word)
  {
    _userInput = word;
  }

  public void SetWord (string[] newWord)
  {
    _userInput = newWord;
  }
  public string[] GetWord()
  {
    return _userInput;
  }


public static string ReverseString(string input)
{
  char[] arr = input.ToCharArray();
  Array.Reverse(arr);
  return new string(arr);
}
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word to find out if it's a palindrome");
    string stringWord = Console.ReadLine();
    // char[] arrayWord = stringWord.ToCharArray();
    // string[] splitWord = arrayWord.Split();
    // string[] word = stringWord;

    Console.WriteLine(Palindrome.ReverseString(stringWord));



  }
}
