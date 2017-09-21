using System;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            string x = "";
            for(int i = 1; i <= n; i++)
            {
                x = x + $"{str}";
            }
            return x;
        }

        public string FrontTimes(string str, int n)
        {
            string x = "";
            if(str.Length < 3)
            {
                for(int i = 1; i <= n; i++)
                {
                    x = x + $"{str}";
                }
            }
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    x = x + $"{str.Substring(0,3)}";
                }

            }
            return x;
        }

        public int CountXX(string str)
        {
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(i == str.Length - 1)
                {

                }
                else if(str.Substring(i,2) == "xx")
                {
                    count++;
                }
            }
            return count;
        }

        public bool DoubleX(string str)
        {
            int count = 0;
            int notfirstx = 0;
            for(int i = 0; i < str.Length; i++)
            {
                int a = i + 1;
                if(i == str.Length - 1)
                { }
                else if(str.Substring(i,1) == "x" && str.Substring(a, 1) != "x")
                {
                    notfirstx++;
                }
                else if(str.Substring(i,1) == "x" && str.Substring(i+1,1)== "x" && notfirstx == 0 && count == 0)
                {
                    count++;
                }
                
            }
            if(count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string EveryOther(string str)
        {
            string x = "";
            for(int i = 0; i < str.Length; i = i + 2)
            {
                x = x + $"{str.Substring(i, 1)}";
            }
            return x;
        }

        public string StringSplosion(string str)
        {
            string x = "";
            for(int i = 0; i < str.Length; i++)
            {
                x = x + $"{str.Substring(0, 1 + i)}";
            }
            return x;
        }

        public int CountLast2(string str)
        {
            int count = 0;
            if (str.Length < 3)
            {
                return 0;
            }
            else
            {
                string test = $"{str.Substring(str.Length - 2, 2)}";
                for(int i = 0; i < str.Length -2; i++)
                {
                    if(str.Substring(i,2) == test)
                    {
                        count++;
                    }
                }
            }
            return count;

        }

        public int Count9(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    count++;
                }
            }
            return count;
        }

        public bool ArrayFront9(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < 4; i++)
            {
                if(numbers[i] == 9)
                {
                    count++;
                }
            }
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Array123(int[] numbers)
        {
            bool count = false;
            if (numbers.Length < 3)
            {

            }
            else
            {
                for (int i = 0; i <= numbers.Length - 3; i++)
                {
                    if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                    {
                        count = true;
                    }
                }
            }
            return count;
        }

        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            int c = 0;
            if(a.Length > b.Length)
            {
                c = b.Length;
            }
            else
            {
                c = a.Length;
            }
            for (int i = 0; i < c - 1; i++)
            {
                if (a.Substring(i, 2) == b.Substring(i, 2))
                {
                    count++;
                }
            }
            return count;
        }

        public string StringX(string str)
        {
            string x = $"{str.Substring(0,1)}";
            for(int i = 1; i < str.Length-1; i++)
            {
                if (str.Substring(i,1) == "x") { }
                else
                {
                    x = x + $"{str.Substring(i, 1)}";
                }
            }
            x = x + $"{str.Substring(str.Length - 1, 1)}";
            return x;
        }

        public string AltPairs(string str)
        {
            int count = 0;
            string x = "";
            for (int i = 0; i < str.Length; i = i + 2)
            {
                if (count == 0)
                {
                    x = $"{str.Substring(0, 2)}";
                    count++;
                }
                else
                {
                    if(count % 2 != 0)
                    {
                        count++;
                    }
                    else if((str.Length -1)-i > 0)
                    {
                        x = x + $"{str.Substring(i, 2)}";
                        count++;
                    }
                    else
                    {
                        x = x + $"{str.Substring(i, 1)}";
                    }
                }
            }
            return x;
        }

        public string DoNotYak(string str)
        {
            string x = "";
            for(int i = 0; i < str.Length -1;)
            {
                if (i >= str.Length - 2)
                {
                    x = x + $"{str.Substring(i)}";
                    break;
                }
                else if(str.Substring(i, 3) != "yak" && i < str.Length-2)
                {
                    x = x + $"{str.Substring(i, 3)}";
                    i = i + 3;
                }
                else if (str.Substring(i,3) == "yak")
                {
                    i = i + 3;
                }
            }
            return x;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i <= numbers.Length - 2 && numbers[i] == 6 && (numbers[i+1] == 6 || numbers[i + 1] == 7))
                {
                    count++;
                }
            }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            bool count = true;
            for(int i = 0; i < numbers.Length; i++)
            if(i < numbers.Length -2 && numbers[i] == numbers[i+1] && numbers[i] == numbers[i + 2])
            {
                count = false;
            }
            return count;
        }

        public bool Pattern51(int[] numbers)
        {
            bool count = false;
            for(int i = 0; i < numbers.Length - 2; i++)
            {
                if(numbers[i+1] == numbers[i]+5 && numbers[i+2] == numbers[i]-1)
                {
                    count = true;
                }
            }
            return count;
        }

    }
}
