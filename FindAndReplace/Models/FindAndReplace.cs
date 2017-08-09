using System;
using System.Collections.Generic;

namespace FindAndReplace.Models
{
  public class FindAndReplaceClass
  {
    private string _sentence;
    private string _find;
    private string _replace;

    public FindAndReplaceClass(string sentence)
    {
      _sentence = sentence;
      _find = "cat";
      _replace = "dog";
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetFind(string newFind)
    {
      _find = newFind;
    }

    public string GetFind()
    {
      return _find;
    }

    public void SetReplace(string newReplace)
    {
      _replace = newReplace;
    }

    public string GetReplace()
    {
      return _replace;
    }

    public string GetNewSentence()
    {
      string[] splitSentence = _sentence.Split(' ');
      for (int i = 0; i < splitSentence.Length; i++)
      {
        // i am walking my cat to teh cathedral
        if (splitSentence[i].IndexOf(_find) != -1)
        {
          if (splitSentence[i].Length > _find.Length)
          {
            Console.WriteLine("got inside substring area {0}", i);
            splitSentence[i] = splitSentence[i].Substring(0, (splitSentence[i].IndexOf(_find))) + _replace + splitSentence[i].Substring((splitSentence[i].IndexOf(_find) + _find.Length), splitSentence[i].Length - _find.Length - splitSentence[i].Substring(0, (splitSentence[i].IndexOf(_find))).Length);
          }
          else
          {
            splitSentence[i] = _replace;
          }
        }
        Console.WriteLine(splitSentence[i]);
        // if (splitSentence[i] == _find)
        // {
        //   splitSentence[i] = _replace;
        // }
      }
      return String.Join(" ", splitSentence);
    }
  }
}
