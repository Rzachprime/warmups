using System;

namespace Warmups.BLL
{
    public class Arrays
    {

        public bool FirstLast6(int[] numbers)
        {
            if(numbers[0] == 6 || numbers[numbers.Length-1] == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SameFirstLast(int[] numbers)
        {
            if(numbers[0] == numbers[numbers.Length-1] && numbers.Length >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int[] MakePi(int n)
        {
            // not my answer
            double pi = Math.PI;
            var str = pi.ToString().Remove(1, 1);
            var chararray = str.ToCharArray();
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(chararray[i].ToString());
            }
            return numbers;
        }
        
        public bool CommonEnd(int[] a, int[] b)
        {
           if (a[0] == b[0] || a[a.Length -1] == b[b.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int Sum(int[] numbers)
        {
            int a = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                a = a + numbers[i];

            }
            return a;
        }
        
        public int[] RotateLeft(int[] numbers)
        {
            var numbers2 = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int a = i+1;
                // must be <=... have to be less than the max index but allow for low value arrays...
                if (i <= numbers.Length - 2)
                {
                    numbers2[i] = numbers[a];
                }
                else
                {
                    numbers2[i] = numbers[0];
                }
            }
            return numbers2;
        }

        public int[] Reverse(int[] numbers)
        {
            var numbers2 = new int[numbers.Length];

            for (int i = 0 ; i <= numbers.Length - 1; i++)
            {
                int a = (numbers.Length - 1) - i;

                if(i < numbers.Length)
                {
                    numbers2[a] = numbers[i];
                }
            }
            return numbers2;
        }

            public int[] HigherWins(int[] numbers)
        {
            if(numbers[0] > numbers[numbers.Length - 1])
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[0];
                }

            }
            else
            {
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    numbers[i] = numbers[numbers.Length-1];
                }
            }
            return numbers;
        }
        
        public int[] GetMiddle(int[] a, int[] b)
        {
            var c = new int[2];
            c[0] = a[1];
            c[1] = b[1];
            return c;
        }
        
        public bool HasEven(int[] numbers)
        {
            int a = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    a++;
                }
            }
            if(a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int[] KeepLast(int[] numbers)
        {
            var numbers2 = new int[numbers.Length * 2];
            numbers2[numbers2.Length - 1] = numbers[numbers.Length - 1];
            return numbers2;
        }
        
        public bool Double23(int[] numbers)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    a++;
                }
                if (numbers[i] == 3)
                {
                    b++;
                }
            }
            if(a == 2 || b == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int[] Fix23(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2 && numbers[i+1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }
        
        public bool Unlucky1(int[] numbers)
        {
            if(numbers[0] == 1 && numbers[1]== 3 || numbers[1] == 1 && numbers[2] == 3 || numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int[] Make2(int[] a, int[] b)
        {
            var c = new int[a.Length + b.Length];
            var d = new int[2];
            int e = a.Length + b.Length;
            for(int i = 0; i < e; i++)
            {
                if(a.Length == 0)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        c[j] = b[j];
                    }
                }
                else if(a.Length > 1  || b.Length == 0)
                {
                    for(int l = 0; l < 2; l++)
                    {
                        c[l] = a[l];
                    }
                }
                else if (a.Length < 2 && a.Length > 0)
                {
                    for(int m = 0; m < 2; m++)
                    {
                        if(m == 0)
                        {
                            c[m] = a[m];
                        }
                        else
                        {
                            c[m] = b[0];
                        }

                    }

                }
            }
            for(int k = 0; k < 2; k++)
            {
                d[k] = c[k];
            }
            return d;
        }

    }
}
