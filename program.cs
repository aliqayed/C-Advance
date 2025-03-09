using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //class student
    //{

    //}
    //class mastersudent : student
    //{

    //}
    //struct test
    //{

    //}

    struct complex
    {
        public int real { get; set; }
        public int img { get; set; }
        public complex( int real=1 , int img=1)
        {
            this.real = real;
            this.img = img;
        }
        public override string ToString()
        {
            return $"{real}+{img}i";
        }
    }
    class studdent
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        //public studdent()
        //{

        //}
        public studdent( int id =0, string name = null  ,int age=0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"id={id},name={name},age={age}";
        }

        public override bool Equals(object obj)
        {
            //if (obj is studdent)
            //{
            //    studdent s = (studdent)obj;
            //    return (s.id == id && s.name == name && s.age == age);
            //}
            //else
            //    return false;


            studdent s = obj as studdent;
            if (s != null)
                return (s.id == id && s.name == name && s.age == age);
            else
                return false;
        }
        public override int GetHashCode()
        {
            return id;
        }
    }

    class master : studdent
    {
       
    }
  
     class calc
    {
        //public static void swap (ref studdent s1 ,ref studdent s2)
        //{
        //    studdent temp = s1;
        //    s1 = s2;
        //    s2 = temp;
        //}

        //public static int sum(int x , int y , ref int sub)
        //{
        //  //  sub = x - y;
        //    return x + y;
        //}

        //public static int sum(int a, int b, out int sub ,out int mul)
        //{
        //     sub = a - b;
        //    mul = a * b;
        //    return a + b;
        //}

        //public static int sum (int a , int b , int c=0 , int d=0)
        //{
        //    return a + b +c+d;
        //}

        public static int sum( params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
 class Program
    {
        static void Main(string[] args)
        {
            #region object 
            //test t;
            //object o = new object();
            //object o = new int();
            //int x = 1;
            //object o = 1;


            //object o = 1;
            ////  o = "ali";
            //o++;
            //object[] arr = new object[4];
            //arr[0] = 1;
            //arr[1] = "ali amed";
            //arr[2] = 2.2f;
            //arr[3] = new test();

            //arr[0]++;

            //student[] s = new student[2];
            //s[0] = new student();
            //s[1] = new mastersudent();



            //int x = 1;
            //object o = x; //boxing

            //int y = (int)o; //unboxing


            //tostring 
            //equal
            //gethashcode
            //gettype


            //studdent s = new studdent(1, "ali", 20);
            //Console.WriteLine(s.ToString());

            //equal

            //complex c = new complex(1, 2);
            //complex c2 = new complex(1, 2);
            //if (c.Equals(c2))
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //}

            // studdent s = new studdent(1, "ali", 20);
            // studdent s2 = new studdent(1, "ali", 20);
            // //s = s2;
            ////equals ,==
            // if (s.Equals(s2))
            // {
            //     Console.WriteLine("equal");
            // }
            // else
            // {
            //     Console.WriteLine("not equal");
            // }

            //studdent s = new studdent(1, "ali", 20);

            //Console.WriteLine(s.GetType());
            #endregion
            #region paramater ,defualt ,in out ,params 
            //studdent x = new studdent(1, "ali", 20);
            //studdent y = new studdent(2, "mohamed", 22);
            //calc.swap(ref x,ref y);
            //Console.WriteLine(x.ToString());
            //Console.WriteLine(y.ToString());

            //value 

            //by value   (intx) //no change
            //ref   (ref int  x) //change


            //ref 
            //by value (student s) //change data done  , change ref xxxx
            //by ref (ref student s) // any change


            //in ,out 

            //int x = 7, y = 5;
            //int sub=0;
            //Console.WriteLine( calc.sum(x, y, ref sub));
            //Console.WriteLine(sub);

            //int x = 7, y = 5;
            //int s = 10;
            //int m;
            //Console.WriteLine(calc.sum(x, y, out s, out m));
            //Console.WriteLine(s);
            //Console.WriteLine(m);
            //Console.WriteLine(calc.sum(1,2,3));
            //Console.WriteLine(calc.sum(1,2));
            //Console.WriteLine(calc.sum(1,2,3,4));
            //studdent s = new studdent(1, "ali");
            //studdent s2 = new studdent(1, "ali",22);
            //studdent s3 = new studdent(1);
            //studdent s4 = new studdent();

            //complex c = new complex();
            //Console.WriteLine(c.ToString());

            //Console.WriteLine(  calc.sum(new int[] { 1, 2, 3, 4, 5, 6 }));
            //Console.WriteLine(   calc.sum(1, 4, 5, 6, 7, 4, 6, 7));
            #endregion
            #region  exceptionhandling
            #region is , as

            //master s = new master();

            //if(s is object)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //complex c = new complex(1, 2);
            //studdent s1 = new studdent(1, "ali", 20);
            //studdent s2 = new studdent(1, "ali", 20);
            //if (s1.Equals(c))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

            ////object s = new studdent(1, "ali", 22);
            ////master c = s as master;

            #endregion
            #region tryparse
            //Console.WriteLine("enter number");
            ////    int x = int.Parse(Console.ReadLine());
            //int x;
            //Console.WriteLine(   int.TryParse(Console.ReadLine(), out x));
            //Console.WriteLine($"x={x}");
            #endregion
            #region check ,uncheck
            //-5 -4 -3 -2 -1 0 1 2 3 4 5
            //8
            checked
            {
                long x = int.MaxValue;
                x += 30;

                unchecked
                {
                    int y = (int)x;
                    Console.WriteLine(y);

                }

            }

            #endregion


            #region try , catch

            #endregion


            #endregion
        }
    }
}
