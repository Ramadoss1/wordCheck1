using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace intel.IT.WordChecker
{
    public interface ICharaacter
    {
        bool isBroad();
        bool isSlender();
        bool isConsonant();

    }

    public interface ILangaugeWord
    {
        bool isValidWord(); 
    }

    class lCharacter : ICharaacter
    {
        private char _lCharacter;

        char[] broadVowels = { 'a', 'o', 'u' };
        char[] slenderVowels = { 'e', 'i' };
        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

        public lCharacter(char _iChar)
        {
            this._lCharacter = _iChar;
        }

        public bool isBroad()
        {
            return broadVowels.Contains(_lCharacter);
        }

        public bool isSlender()
        {
            return slenderVowels.Contains(_lCharacter);
        }

        public bool isConsonant()
        {
            return consonants.Contains(_lCharacter);
        }
        public override String ToString()
        {
            return _lCharacter + "";
        }
    }

    public class LanguageWord : ILangaugeWord
    {
        private List<lCharacter> _word = new List<lCharacter>();

        public LanguageWord(String iWord)
        {
            char[] cArray = iWord.ToLower().ToCharArray();
            List<char> cList = cArray.OfType<char>().ToList();
            _word = cList.Select(character => new lCharacter(character)).ToList();
        }

        public override String ToString()
        {
            String value = "";
            foreach (lCharacter _lCharacter in _word)
            {
                value += _lCharacter.ToString();
            }
            return value;
        }

        public bool isValidWord()
        {
            bool invalidWord = false;
            lCharacter oneDown = null;
            lCharacter twoDown = null;
            foreach (lCharacter _lCharacter in _word)
            {
                // OXI
                if (oneDown != null && twoDown != null && twoDown.isBroad() && oneDown.isConsonant() && _lCharacter.isSlender())
                {
                    invalidWord = true;
                }
                // IXO
                if (oneDown != null && twoDown != null && twoDown.isSlender() && oneDown.isConsonant() && _lCharacter.isBroad())
                {
                    invalidWord = true;
                }
                if (oneDown != null && oneDown.isConsonant() && _lCharacter.isConsonant())
                {
                    oneDown = _lCharacter;
                }
                else
                {
                    twoDown = oneDown;
                    oneDown = _lCharacter;
                }
                //Console.WriteLine(twoDown + " " + oneDown + " " + _lCharacter);
                //return _lCharacter.isConsonant();
            };
            return !invalidWord;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word : ");
            String iWord = Console.ReadLine();
            string cWord = iWord; 
            LanguageWord lWord = new LanguageWord(iWord);
            if (lWord.isValidWord())
                Console.WriteLine(iWord + " is an valid word");
            else
                Console.WriteLine(iWord + " is an invalid word");
        }
    }
}
