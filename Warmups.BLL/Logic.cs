using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            if(cigars > 39 && cigars < 61 && !isWeekend)
            {
                return true;
            }
            else if (cigars > 39 && isWeekend)
            {
                return true;
            }
            else { return false; }
        }
        
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if((yourStyle > 2 && dateStyle > 2) && (yourStyle > 7 || dateStyle > 7))
            {
                return 2;
            }
            else if (yourStyle > 2 && dateStyle > 2)
            {
                return 1;
            }
            else { return 0; }
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
           if( temp > 59 && temp < 101 && isSummer)
            {
                return true;
            }else if(temp > 59 && temp < 91)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if((isBirthday && speed > 65 && speed < 86) || (!isBirthday && speed > 60 && speed < 81))
            {
                return 1;
            }
            else if((isBirthday && speed > 85) || (!isBirthday && speed > 80))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        
        public int SkipSum(int a, int b)
        {
            if(a + b > 19 || a + b < 10)
            {
                return a + b;
            }
            else
            {
                return 20;
            }
        }
        
        public string AlarmClock(int day, bool vacation)
        {
            if(!vacation && day >0 && day < 6)
            {
                return "7:00";
            }
            else if((vacation && day > 0 && day <6)||(day == 0 || day == 6))
            {
                return "10:00";
            }
            else
            {
                return "off";
            }
        }
        
        public bool LoveSix(int a, int b)
        {
            if(a == 6 || b == 6 || a + b == 6 || b - a == 6 || a - b == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool InRange(int n, bool outsideMode)
        {
            if ((!outsideMode && n > 0 && n < 11) || (outsideMode && (n <= 1 || n >= 10)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public bool SpecialEleven(int n)
        {
            if(n % 11 == 0 || n % 11 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Mod20(int n)
        {
            if(n % 20 == 1 || n % 20 == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return false;
            }
            else if(n % 3 == 0)
            {
                return true;
            }
            else if (n % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
        
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if ((isAsleep) || (isMorning && !isMom))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public bool TwoIsOne(int a, int b, int c)
        {
            if(a + b == c || a + c ==b || b + c == a)
            {
                return true;
            }else
            {
                return false;
            }
                
        }
        
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if((!bOk && c > b && b > a) || (bOk && c > b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
           if((equalOk && c >= b && b >= a) || (!equalOk && a < b && b < c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool LastDigit(int a, int b, int c)
        {
            if(a % 10 == b % 10 || a % 10 == c % 10 || b % 10 == c % 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (!noDoubles)
            {
                return die1 + die2;
            }
            else
            {
                if(die1 == die2)
                {
                    if (die1 + 1 > 6)
                    {
                        die1 = 1;
                    }
                    else if (die2 + 1 > 6)
                    {
                        die2 = 1;
                    }
                    else
                    {
                        die1 = die1 + 1;
                    }
                    return die1 + die2;
                }
                else
                {
                    return die1 + die2;
                }
            }
        }

    }
}
