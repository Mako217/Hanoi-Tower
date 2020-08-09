using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace Hanoi_Tower
{
    class Program
    {
        static void Main()
        {
            Stack A = new Stack();
            Stack B = new Stack();
            Stack C = new Stack();
            bool flag = true;

            Console.WriteLine("Please type number of elements");

            int n = Int32.Parse(Console.ReadLine());

            Console.Clear();

            for(int z = 0; z<n; z++)
            {
                A.Push(n - z);
            }

            object[] goal = A.ToArray();

            int i = 0;
            
            object[] a = A.ToArray();
            object[] b = B.ToArray();
            object[] c = C.ToArray();

            foreach (object obj in a.Reverse<object>())
            {
                Console.Write(obj);
            }
            Console.WriteLine();
            foreach (object obj in b.Reverse<object>())
            {
                Console.Write(obj);
            }
            Console.WriteLine();
            foreach (object obj in c.Reverse<object>())
            {
                Console.Write(obj);
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Moves:  " + i);
            Console.WriteLine();
            Console.WriteLine("Minimum moves:  " + (Math.Pow(2,n) - 1));


            while (flag)
            {
                Console.Clear();
                char[] j = Convert.ToString(i, 2).ToCharArray();
                char[] k = Convert.ToString(i + 1, 2).ToCharArray();
                i++;
                int toChange = 1;
                for(int x = k.Length - 1; x >= 0; x--)
                {
                    if(k.Length > j.Length)
                    {
                        toChange =k.Length;
                        break;
                    }
                    else if(k[x] - 48 == 1 && j[x] - 48 == 0)
                    {
                        break;
                    }
                    toChange++;
                }

                if (n % 2 != 0)
                {
                    if (A.Count > 0 && (int)A.Peek() == toChange)
                    {
                        if (C.Count == 0 || (int)C.Peek() > (int)A.Peek())
                        {
                            C.Push(A.Pop());
                        }
                        else if (B.Count == 0 || (int)B.Peek() > (int)A.Peek())
                        {
                            B.Push(A.Pop());
                        }
                    }
                    else if (B.Count > 0 && (int)B.Peek() == toChange)
                    {
                        if (A.Count == 0 || (int)A.Peek() > (int)B.Peek())
                        {
                            A.Push(B.Pop());
                        }
                        else if (C.Count == 0 || (int)C.Peek() > (int)B.Peek())
                        {
                            C.Push(B.Pop());
                        }
                    }
                    else if (C.Count > 0 && (int)C.Peek() == toChange)
                    {
                        if (B.Count == 0 || (int)B.Peek() > (int)C.Peek())
                        {
                            B.Push(C.Pop());
                        }
                        else if (A.Count == 0 || (int)A.Peek() > (int)C.Peek())
                        {
                            A.Push(C.Pop());
                        }
                    }
                }
                else
                {
                    if (A.Count > 0 && (int)A.Peek() == toChange)
                    {
                        if (B.Count == 0 || (int)B.Peek() > (int)A.Peek())
                        {
                            B.Push(A.Pop());
                        }
                        else if (C.Count == 0 || (int)C.Peek() > (int)A.Peek())
                        {
                            C.Push(A.Pop());
                        }
                    }
                    else if (B.Count > 0 && (int)B.Peek() == toChange)
                    {
                        if (C.Count == 0 || (int)C.Peek() > (int)B.Peek())
                        {
                            C.Push(B.Pop());
                        }
                        else if (A.Count == 0 || (int)A.Peek() > (int)B.Peek())
                        {
                            A.Push(B.Pop());
                        }
                    }
                    else if (C.Count > 0 && (int)C.Peek() == toChange)
                    {
                        if (A.Count == 0 || (int)A.Peek() > (int)C.Peek())
                        {
                            A.Push(C.Pop());
                        }
                        else if (B.Count == 0 || (int)B.Peek() > (int)C.Peek())
                        {
                            B.Push(C.Pop());
                        }
                    }
                }

                a = A.ToArray();
                b = B.ToArray();
                c = C.ToArray();

                foreach (object obj in a.Reverse<object>())
                {
                    Console.Write(obj);
                }
                Console.WriteLine();
                foreach (object obj in b.Reverse<object>())
                {
                    Console.Write(obj);
                }
                Console.WriteLine();
                foreach (object obj in c.Reverse<object>())
                {
                    Console.Write(obj);
                }
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Moves:  " + i);
                Console.WriteLine();
                Console.WriteLine("Minimum moves:  " + (Math.Pow(2, n) - 1));


                if (C.Count == goal.Count())
                {
                    
                    for(int x = 0; x < C.Count; x++)
                    {
                        if(c[x] != goal[x])
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    
                }
                Thread.Sleep(200);



            }

            
        }

    }
}
