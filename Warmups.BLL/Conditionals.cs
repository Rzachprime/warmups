using System; 

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if(aSmile == true && bSmile == true || aSmile == false && bSmile == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if( isWeekday == true && isVacation == true || isWeekday == false || isVacation == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SumDouble(int a, int b)
        {
            if(a == b)
            {
                return (a + b) * 2;
            }
            else
            {
                return a + b;
            }
        }
        
        public int Diff21(int n)
        {
            if(n > 21)
            {
                return (n - 21) * 2;
            }
            else
            {
                return 21 - n;
            }
        }
        
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if(isTalking == true && (hour < 7 || hour > 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Makes10(int a, int b)
        {
            if(a + b == 10 || a == 10 || b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool NearHundred(int n)
        {
            if(n > 89 && n < 111 || n > 189 && n < 211)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool PosNeg(int a, int b, bool negative)
        {
            if((negative = true && a < 0 && b < 0) || ((a < 0 && b > 0) || (a > 0 && b < 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string NotString(string s)
        {
            if(s.Length == 1)
            {
                string x = $"not {s}";
                return x;
            }
            else if (s.Substring(0,3) == "not")
            {
                return s;
            }
            else
            {
                string x = $"not {s}";
                return x;
            }
                
        }
        
        public string MissingChar(string str, int n)
        {
            if (n == 0)
            {
                string x = $"{str.Substring(1)}";
                return x;
            }
            else
            {
                string x = $"{str.Substring(0, n)}{str.Substring(n + 1)}";
                return x;
            }
        }
        
        public string FrontBack(string str)
        {
            if(str.Length == 1)
            {
                return str;
            }
            else
            {
                string x = $"{str.Substring(str.Length - 1)}{str.Substring(1, str.Length - 2)}{str.Substring(0, 1)}";
                return x;
            }
        }
        
        public string Front3(string str)
        {
            if(str.Length < 3)
            {
                string x = $"{str}{str}{str}";
                return x;
            }
            else
            {
                string x = $"{str.Substring(0, 3)}{str.Substring(0, 3)}{str.Substring(0, 3)}";
                return x;
            }
        }
        
        public string BackAround(string str)
        {
            string x = $"{str.Substring(str.Length - 1)}{str}{str.Substring(str.Length - 1)}";
            return x;
        }
        
        public bool Multiple3or5(int number)
        {
            if(number % 3 == 0 || number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool StartHi(string str)
        {
            if(str.Length == 1)
            {
                return false;
            }
            else if (str.Length < 3 && str.Substring(0, 2) == "hi")
            {
                return true;
            }
            else if(str.Substring(0, 3)== "hi "|| str.Substring(0,3)== "hi,")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool IcyHot(int temp1, int temp2)
        {
           if ((temp1 > 100 && temp2 < 0) || (temp1 < 0 && temp2 > 100))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Between10and20(int a, int b)
        {
            if((a > 9 && a < 21) || (b > 9 && b < 21))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool HasTeen(int a, int b, int c)
        {
            if((a > 12 && a < 20) || (b > 12 && b < 20) || (c > 12 && c < 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool SoAlone(int a, int b)
        {
            if (((a>12 && a<20) && (b<12 || b>20)) || ((b > 12 && b < 20) && (a < 12 || a > 20)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string RemoveDel(string str)
        {
            if(str.Substring(1,3)== "del")
            {
                string x = $"{str.Substring(0, 1)}{str.Substring(4)}";
                return x;
            }
            else
            {
                return str;
            }
        }
        
        public bool IxStart(string str)
        {
            if(str.Substring(1,2)== "ix")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string StartOz(string str)
        {
           
            if(str.Substring(0,1) != "o" && str.Length == 1)
            {
                string x = "";
                return x;
            }
            else if(str.Substring(0,1) == "o" && str.Substring(1,1)== "z")
            {
                string x = "oz";
                return x;
            }
            else if(str.Substring(0,1) == "o")
            {
                string x = "o";
                return x;
            }
            else if(str.Substring(1,1) == "z")
            {
                string x = "z";
                return x;
            }
            else
            {
                string x = "";
                return x;
            }
        }
        
        public int Max(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        
        public int Closer(int a, int b)
        {
            int aresult = 0;
            int bresult = 0;
            if (a > 10)
            {
                aresult = a - 10;
            }
            else if (a < 10)
            {
                aresult = 10 - a;
            }
            if (b > 10)
            {
                bresult = b - 10;
            }
            else if (b < 10)
            {
                bresult = 10 - b;
            }
            if (aresult > bresult)
            {
                return b;
            }
            else if (bresult > aresult)
            {
                return a;
            }
            else
            {
                return 0;
            }
        }
        
        public bool GotE(string str)
        {
            int count = 0;
            for(int i = 0; i < str.Length; i++ )
            {
                if(str.Substring(i,1) == "e")
                {
                    count++;
                }

            }
            if(count <= 3 && count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string EndUp(string str)
        {
            if(str.Length< 3)
            {
                string x = str.ToUpper();
                return x;

            }
            else
            {
                string x = $"{str.Substring(0, str.Length-3 )}{ str.Substring(str.Length - 3).ToUpper()}";
                return x;
            }
        }
        
        public string EveryNth(string str, int n)
        {
            string x = "";
            for(int i = 0; i < str.Length; i = i + n)
            {
                x = x + $"{str.Substring(i, 1)}";
                
            }
            return x;
        }
    }
}
