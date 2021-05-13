using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTests
{
    public static class IsoWord
    {
        public static Letter GetLetter(this List<Letter> letterList, char findMe)
        {
            foreach (Letter letter in letterList)
            {
                if (letter.TheLetter == findMe)
                {
                    return letter;
                }
            }
            return null;
        }
        public static void IncrementValue(this Letter let)
        {
            let.Value += 1;
        }
        public static IsomorphObj GetIsoObject(this List<IsomorphObj> isoList, string isoString)
        {
            foreach(IsomorphObj item in isoList)
            {
                if(item.IsomorphString == isoString)
                {
                    return item;
                }
            }
            return null;
        }
    }
    public class Letter : IComparable
    {
        public Letter(char letter, int val)
        {
            this.TheLetter = letter;
            this.Value = val;
        }
        public char TheLetter { get; set; }
        public int Value { get; set; }
        public int CompareTo(object obj)
        {
            return String.Compare(this.TheLetter.ToString(), ((Letter)obj).TheLetter.ToString());
        }
    }
    public class IsomorphObj : IComparable
    {
        public IsomorphObj(string isoString, string word)
        {
            this.IsomorphString = isoString;
            this.WordList = new List<string> { word };
        }
        public string IsomorphString { get; set; }
        public List<string> WordList { get; set; }
        public void AddWord(string word)
        {
            this.WordList.Add(word);
            this.WordList.Sort();
        }
        public int CompareTo(object obj)
        {
            return String.Compare(IsomorphString, ((IsomorphObj)obj).IsomorphString);
        }
    }
    public class IsoMorph
    {
        public static void IsIsomorphic(string path)
        {
            List<string> words = new List<string>();
            List<IsomorphObj> exactIsomorphs = new List<IsomorphObj>();
            List<IsomorphObj> looseIsomorphs = new List<IsomorphObj>();
            foreach(var word in words)
            {
                var exactIso = GenerateExactIso(word);
                IsomorphObj obj = exactIsomorphs.GetIsoObject(exactIso);
                if(obj != null)
                {
                    obj.AddWord(word);
                }
                else
                {
                    exactIsomorphs.Add(new IsomorphObj(exactIso, word));
                }
                var looseIso = GenerateLooseIso(word);
                IsomorphObj obje = looseIsomorphs.GetIsoObject(looseIso);
                if (obje != null)
                {
                    obje.AddWord(word);
                }
                else
                {
                    looseIsomorphs.Add(new IsomorphObj(looseIso, word));
                }

            }
            exactIsomorphs.Sort();

            List<Letter> letterList = new List<Letter>();
            letterList.Add(new Letter('c',1));
            letterList.Sort();
            Letter found = letterList.GetLetter('c');
            if(found != null)
            {
                found.IncrementValue();
            }
            else
            {

            }
        }
        public static string GenerateExactIso(string word)
        {
            List<Letter> foundLetter = new List<Letter>();
            int index;
            foreach (char c in word)
            {

            }
            return "1 2";
        }
        public static string GenerateLooseIso(string word)
        {
            List<Letter> foundLetter = new List<Letter>();
            int index;
            foreach(char c in word)
            {

            }
            return "1 2";
        }

    }
}
