using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Tile
  {
    private char _letter;
    private int _score;
    Dictionary<char,int> _tileDictionary= new Dictionary<char,int>{};

    public Tile(char letter)
    {
      _letter = letter;

      _tileDictionary.Add('A',1);
      _tileDictionary.Add('E',1);
      _tileDictionary.Add('I',1);
      _tileDictionary.Add('O',1);
      _tileDictionary.Add('U',1);
      _tileDictionary.Add('L',1);
      _tileDictionary.Add('N',1);
      _tileDictionary.Add('R',1);
      _tileDictionary.Add('S',1);
      _tileDictionary.Add('T',1);
      _tileDictionary.Add('D',2);
      _tileDictionary.Add('G',2);
      _tileDictionary.Add('B',3);
      _tileDictionary.Add('C',3);
      _tileDictionary.Add('M',3);
      _tileDictionary.Add('P',3);
      _tileDictionary.Add('F',4);
      _tileDictionary.Add('H',4);
      _tileDictionary.Add('V',4);
      _tileDictionary.Add('W',4);
      _tileDictionary.Add('Y',4);
      _tileDictionary.Add('K',5);
      _tileDictionary.Add('J',8);
      _tileDictionary.Add('X',8);
      _tileDictionary.Add('Q',10);
      _tileDictionary.Add('Z',10);

      _score = _tileDictionary[_letter];
    }

    public int GetTileScore()
    {
      return _score;
    }
  }

  public class ScrabbleGame
  {
    private char _inputCharacter;
    private string _inputWord;
    private List<char> _inputWordList = new List<char>{};
    private int _wordScore;

    public ScrabbleGame(char inputCharacter)
    {
      _inputCharacter = inputCharacter;
    }

    public ScrabbleGame(string inputWord)
    {
      _inputWord = inputWord.ToUpper();
      foreach(char character in _inputWord)
      {
        _inputWordList.Add(character);
      }
    }

    public string GetInputWord()
    {
      return _inputWord;
    }

    public int GetWordScore()
    {
      foreach(char character in _inputWordList)
      {
        Tile newTile = new Tile(character);
        _wordScore += newTile.GetTileScore();
      }
      return _wordScore;
    }

    public int GetLetterScore()
    {
      Tile newTile = new Tile(_inputCharacter);

      return newTile.GetTileScore();
    }
  }
}
