using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            //return "Hello " + name + "!";
            return $"Hello {name}!";
        }

        public string Abba(string a, string b)
        {
            return $"{a}{b}{b}{a}";
        }

        public string MakeTags(string tag, string content)
        {
            return $"<{tag}>{content}</{tag}>";
        }

        public string InsertWord(string container, string word)
        {
            return container.Insert(2, word);
        }

        public string MultipleEndings(string str)
        {
            // length returns the strings length. subtract 2 and use that as the starting position. hello has value 5 from length. Subtract 2 to get 3. position starts at 0 though so 3 is the second l for string purposes.
            int a = str.Length - 2;
            return $"{str.Substring(a)}{str.Substring(a)}{str.Substring(a)}";
        }

        public string FirstHalf(string str)
        {
            // divide the length in half. start at position 0 and count the first b letters. this includes 0 so helloworld would have 10 letters and show hello which is posistions 0-4.
            int b = str.Length / 2;
            return str.Substring(0, b);
        }

        public string TrimOne(string str)
        {
            int c = str.Length - 2;
            return str.Substring(1, c);
        }

        public string LongInMiddle(string a, string b)
        {
           if (a.Length > b.Length)
            {
                return $"{b}{a}{b}";
            }else
            {
                return $"{a}{b}{a}";
            }
        }

        public string RotateLeft2(string str)
        {
            string a = str.Substring(0, 2);
            string b = str.Substring(2);
            string c = $"{b}{a}";
            return c;
        }

        public string RotateRight2(string str)
        {
            string a = str.Substring(str.Length -2, 2);
            string b = str.Substring(0, str.Length - 2);
            string c = $"{a}{b}";
            return c;
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == true)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1);
            }
        }

        public string MiddleTwo(string str)
        {
            return str.Substring((str.Length / 2) - 1, 2);
        }

        public bool EndsWithLy(string str)
        {
            if(str.Length < 2)
            {
                return false;
            }
            else if (str.Substring(str.Length-2) == "ly")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FrontAndBack(string str, int n)
        {
            string a = str.Substring(0, n);
            string b = str.Substring(str.Length - n);
            return $"{a}{b}";
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (str.Length -1 <= n )
            {
                return str.Substring(0, 2);
            }
            else
            {
                return str.Substring(n, 2);
            }
        }

        public bool HasBad(string str)
        {
            if(str.Length < 2)
            {
                return false;
            }
           else if (str.Substring(0, 3)== "bad" || str.Substring(1,3) == "bad")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AtFirst(string str)
        {
            if (str.Length < 2 && str.Length > 0)
            {
                return $"{str.Substring(0)}@";
            }
            else if(str.Length < 1)
            {
                return "@@";
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

        public string LastChars(string a, string b)
        {
            if (a.Length < 1 && b.Length < 1)
            {
                return "@@";
            }
            else if (a.Length < 1 && b.Length > 0)
            {
                return $"@{b.Substring(b.Length-1)}";
            }
            else if (a.Length>0 && b.Length< 1)
            {
                return $"{a.Substring(0,1)}@";
            }
            else
            {
                return $"{a.Substring(0, 1)}{b.Substring(b.Length - 1)}";
            }
        }

        public string ConCat(string a, string b)
        {
            if(a.Length < 1 || b.Length < 1)
            {
                return $"{a}{b}";
            }
            else if (a.Substring(a.Length-1) == b.Substring(0, 1))
            {
                return $"{a.Substring(0, a.Length - 1)}{b}";
            }
            else
            {
                return $"{a}{b}";
            }
        }

        public string SwapLast(string str)
        {
           

            if (str.Length < 2)
            {
                return $"{str}";
            }
            else
            {
                string a = str.Substring(str.Length - 2, 1);
                string b = str.Substring(str.Length - 1);
                return $"{str.Substring(0, str.Length - 2)}{b}{a}";
            }
        }

        public bool FrontAgain(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            else if (str.Substring(0,2) == (str.Substring(str.Length-2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return $"{a.Substring(a.Length - b.Length)}{b}";
            }
            else if (a.Length < b.Length)
            {
                return $"{a}{b.Substring(b.Length - a.Length)}";
            }
            else
            {
                return $"{a}{b}";
            }
        }

        public string TweakFront(string str)
        {
            if(str.Length < 1)
            {
                return str;
            }
            else if (str.Substring(0,2)== "ab")
            {
                return str;
            }
            else if (str.Substring(0, 1) == "a")
            {
                return $"a{str.Substring(2)}";
            }
            else if (str.Substring(1,1) == "b")
            {
                return $"b{str.Substring(2)}";
            }
            else
            {
                return $"{str.Substring(2)}";
            }
        }

        public string StripX(string str)
        {
            if(str.Length < 1)
            {
                return str;
            }
            else if(str.Length == 1 && str.Substring(0) == "x")
            {
                return "";
            }
            else if (str.Substring(0, 1) == "x" && str.Substring(str.Length - 1) == "x")
            {
                return $"{str.Substring(1, str.Length - 2)}";
            }
            else if (str.Substring(str.Length-1) == "x")
            {
                return $"{str.Substring(0, str.Length - 1)}";
            }
            else if (str.Substring(0,1) == "x")
            {
                return $"{str.Substring(1)}";
            }
            else
            {
                return str;
            }
        }
    }
}
