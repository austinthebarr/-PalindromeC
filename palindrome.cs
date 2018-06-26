using System;
using System.Collections.Generic;

class Palindrome
{
  private string _userInput;

  public Palindrome (string word)
  {
    _userInput = word;
  }

  public bool isPalindrome()
  {
    char[] reversedInputArray = _userInput.ToCharArray();
    Array.Reverse(reversedInputArray);
    string reversedInput = new string(reversedInputArray);

    if (_userInput == reversedInput)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool isPalindromeDifferentWay()
  {
    char[] userInputArray = _userInput.ToCharArray();
    char[] reversedInputArray = _userInput.ToCharArray();
    Array.Reverse(reversedInputArray);

    for(int i = 0; i < userInputArray.Length; i++)
    {
      if(userInputArray[i] == reversedInputArray[i])
      {
        continue;
      }
      else
      {
        return false;
      }
    }

    return true;
  }

  // public string ReverseString(string input)
  // {
  //   char[] arr = input.ToCharArray();
  //   Array.Reverse(arr);
  //   return new string(arr);
  // }
}

public class Program
{
  public static void Main()
  {
    // Console.WriteLine("Enter a word to find out if it's a palindrome");
    // string stringWord = Console.ReadLine();
    // // char[] arrayWord = stringWord.ToCharArray();
    // // string[] splitWord = arrayWord.Split();
    // // string[] word = stringWord;
    //
    // Console.WriteLine(Palindrome.ReverseString(stringWord));
    Console.WriteLine("Enter something:");
    string response = Console.ReadLine();

    Palindrome pal = new Palindrome(response);
    bool result = pal.isPalindrome();
    Console.WriteLine("This is a palindrome: " + result);
  }
}
