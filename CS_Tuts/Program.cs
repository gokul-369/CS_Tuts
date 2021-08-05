using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class app
    {
        public int n1, n2, res;
        public static int d, m, y;
        static app()
        {
            DateTime dt = DateTime.Now;
            d = dt.Day;
            m = dt.Month;
            y = dt.Year;
            Console.WriteLine("Day is {0} and month is {1} and year is {2}", d, m, y);
        }
        public app()
        {
            Console.WriteLine("Enter the 2 nos: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

        }
        public app(int a, int b)
        {
            n1 = a;
            n2 = b;
        }

        public app(app a)
        {
            n1 = a.n1;
            n2 = a.n2;
        }
        public void  showdate()
        {
            Console.WriteLine("Day is {0} and month is {1} and year is {2}", d, m, y);
        }


     
        //public void SetData(int a, int b)
        //{
        //    n1 = a;
        //    n2 = b;
        //}

        //public void Getdata()
        //{
        //    n1 = int.Parse(Console.ReadLine());
        //    n2 = int.Parse(Console.ReadLine());
        //}

        public int Cal()
        {

            res = n1 + n2;
            return res;
        }

        private void hide()
        {
            res = n1 * n2;
        }
        public void disc()
        {
            hide();
            Console.WriteLine("I am showing the res as :{0}",res);
        }

        public void show()
        {
            Console.WriteLine("The sum of {0} and {1} is : {2}", n1, n2, res);
        }
        public void disp1(int v)
        {
            v = v * v;
            Console.WriteLine("call by val and v is {0}", v);
        }
        public void disp2(ref int v)
        {
            v = v * v;
            Console.WriteLine("call by  ref and v is {0}", v);
        }

        //static void Main(string[] args)
        //{

        ////    string name;
        ////    int age;
        ////    Console.WriteLine("Enter the Name:");
        ////    name = Console.ReadLine();
        ////    Console.WriteLine("Enter the Age:");
        ////    age = int.Parse(Console.ReadLine());
        ////    Console.WriteLine("The name of the student is " + name + " And he is " + age + " years old");
        ////    Console.Read();


        ////    int myint = 9;
        ////    Double mydouble = 3.69;
        ////    int e = (int)mydouble;
        ////    bool mybool = true;
        ////    Console.WriteLine(myint + " and " + mydouble);
        ////    Console.WriteLine("int occupies " + sizeof(int));
        ////    Console.WriteLine("int16 occupies " + sizeof(Int16));
        ////    Console.WriteLine("int32 occupies " + sizeof(Int32));
        ////    Console.WriteLine("int64 occupies " + sizeof(Int64));

        ////    Console.WriteLine(Convert.ToString(myint));
        ////    Console.WriteLine(Convert.ToString(mybool));
        ////    Console.WriteLine(Convert.ToInt32(mydouble));
        ////    Console.WriteLine(Convert.ToDouble(myint));
        ////    Console.WriteLine(e);


        ////    int m1, m2, m3, m4, m5, total;
        ////    float avg;

        ////    Console.WriteLine("Enter five subjects' marks: ");
        ////    m1 = int.Parse(Console.ReadLine());
        ////    m2 = int.Parse(Console.ReadLine());
        ////    m3 = int.Parse(Console.ReadLine());
        ////    m4 = int.Parse(Console.ReadLine());
        ////    m5 = int.Parse(Console.ReadLine());

        ////    total = m1 + m2 + m3 + m4 + m5;
        ////    avg = (float)total / 5;

        ////    Console.WriteLine("The total is: " + total + " And the average is: " + avg);



        ////    Console.WriteLine(4 == 4);
        ////    Console.WriteLine(4 < 5);
        ////    Console.WriteLine(2 > 3);
        ////    Console.WriteLine(6 != 4);

        ////    Console.WriteLine((4 == 4) && (5 > 8));
        ////    Console.WriteLine((4 == 4) || (5 > 8));

        ////    int a = 3;
        ////    Console.WriteLine(a += 3);
        ////    Console.WriteLine(a -= 1);
        ////    Console.WriteLine(a /= 2);
        ////    Console.WriteLine(a %= 3);

        ////    Console.WriteLine(a++);
        ////    Console.WriteLine(a);
        ////    Console.WriteLine(++a);
        ////    Console.WriteLine(a);
        ////    Console.WriteLine(a--);
        ////    Console.WriteLine(a);
        ////    Console.WriteLine(--a);
        ////    Console.WriteLine(a);




        ////    int a1 = 100, b = 20, c = 30;
        ////    if (a1 == b && a1 == c)
        ////    {
        ////        if (b == c)
        ////        {
        ////            Console.WriteLine("All are equal");
        ////        }

        ////    }

        ////    else if (a1 > b && a1 > c)
        ////    {
        ////        Console.WriteLine(a1 + " is greater");
        ////    }
        ////    else if (b > a1 && b > c)
        ////    {
        ////        Console.WriteLine(b + " is greater");

        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine(c + " is greater");

        ////    }




        ////    int num1, num2, res, opt;
        ////    Console.WriteLine("enter First number:");
        ////    num1 = int.Parse(Console.ReadLine());
        ////    Console.WriteLine("enter Second number:");
        ////    num2 = int.Parse(Console.ReadLine());
        ////menus:
        ////    Console.WriteLine("-----press 1 to add------ \n-----press 2 to sub-----\n----- press 3 to multiply-----");
        ////    Console.WriteLine("enter the option: ");
        ////    opt = int.Parse(Console.ReadLine());

        ////    switch (opt)
        ////    {
        ////        case 1:
        ////            res = num1 + num2;
        ////            Console.WriteLine("Result is: " + res);
        ////            break;
        ////        case 2:
        ////            res = num1 - num2;
        ////            Console.WriteLine("Result is: " + res);
        ////            break;
        ////        case 3:
        ////            res = num1 * num2;
        ////            Console.WriteLine("Result is: " + res);
        ////            break;
        ////        default:
        ////            Console.WriteLine("Invalid option choose valid options");
        ////            goto menus;

        ////    }

        ////    int num, large = 0;

        ////    for (int i = 0; i <= 9; i++)
        ////    {
        ////        Console.WriteLine("Enter a Number:");
        ////        num = int.Parse(Console.ReadLine());
        ////        if (num > large)
        ////        {
        ////            large = num;
        ////        }
        ////    }
        ////    Console.WriteLine("The largest of the 10 numbers is: " + large);

        ////    int i1 = 1, table = 12, res1;
        ////    do
        ////    {
        ////        res1 = table * i1;
        ////        Console.WriteLine("{0}*{1}={2}", table, i1, res);
        ////        i1++;
        ////    } while (i1 <= 10);


        ////    int i2 = 1, nums;
        ////    while (i2 < 10)
        ////    {
        ////        Console.WriteLine("Enter the  number: ");
        ////        nums = int.Parse(Console.ReadLine());
        ////        if (nums % 2 == 0)
        ////        {
        ////            Console.WriteLine("{0} is even", nums);
        ////        }
        ////        else
        ////        {
        ////            Console.WriteLine("{0} is odd", nums);

        ////        }
        ////        i2++;
        ////    }

        ////    int[] arr1 = { 1, 3, 5, 6, 7, 9, 0 };
        ////    Console.WriteLine("My Unsorted array: ");
        ////    foreach (int n in arr1)
        ////    {
        ////        Console.WriteLine(n);

        ////    }
        ////    Array.Sort(arr1);
        ////    Console.WriteLine("My sorted array: ");
        ////    foreach (int n in arr1)
        ////    {
        ////        Console.WriteLine(n);
        ////    }

        ////    int[] arr2 = new int[5];
        ////    Console.WriteLine("enter 5 nos");
        ////    for (int i = 0; i < 5; i++)
        ////    {
        ////        arr2[i] = int.Parse(Console.ReadLine());
        ////    }
        ////    Console.WriteLine("array contents are:");
        ////    foreach (int i in arr2)
        ////    {
        ////        Console.WriteLine(i);
        ////    }

        ////    int[][] arr = new int[4][];
        ////    arr[0] = new int[] { 11, 21, 43 };
        ////    arr[1] = new int[] { 3, 5, 6, 7, 8, 75 };
        ////    arr[2] = new int[] { 3, 5, 6, 7, 8, 75, 87, 88 };
        ////    arr[3] = new int[] { 3, 5, 6, 7, 8, 75, 87, 88 };


        ////    Console.WriteLine(arr.Length);
        ////    for (int i = 0; i < arr.Length; i++)
        ////    {
        ////        for (int j = 0; j < arr[i].Length; j++)
        ////        {
        ////            Console.Write(arr[i][j] + " ");
        ////        }
        ////        Console.WriteLine();
        ////    }

        //    Console.Read();

        //}
    }

    class val
    {
        public int side,lenth=10,breadth=20;
        public void getdata()
        {
            Console.WriteLine("Enter the Side :");
            side = int.Parse(Console.ReadLine());
        }
    }

    class square : val
    {
        public int res;
         public void area_sq()
        {
            res = side * side;
            Console.WriteLine("The area of Square is {0}", res);
        }
    }

    class cube: val
    {
        public int res1;
        public void area_cu()
        {
            res1 = side * side * side;
            Console.WriteLine(" the area of cube is {0}", res1);
        }
    }
     
    class marks
    {
        public int m1=92, m2=89;

        public void showmarks()
        {
            Console.WriteLine("the marks are {0} and {1}", m1, m2);
            Console.WriteLine("total is {0} out of 200", m1 + m2);
        }
    }

    class info : marks
    {
        string name;
        int rollno;

        public void getinfo()
        {
            Console.WriteLine("enter the name and rollno:");
            name = Console.ReadLine();
            rollno = int.Parse(Console.ReadLine());
        }

        public void showinfo()
        {
            Console.WriteLine("The name of student is {0} and his rno is {1}", name, rollno);
            showmarks();
        }
    }
    class results : info
    {
        public void  getall()
        {
            getinfo();
        }
       public void show_results()
        {
            Console.WriteLine("-------------results--------------");
                showinfo();
        }
    }

    class a
    {
        protected string name;
        public a(string n)
        {
            name = n;
        }
    }
    class b:a
    {
        int age;
        public b(string n,int a) : base(n)
        {
            age = a;
        }

        public void disp()
        {
            Console.WriteLine("name:{0} and age is {1}",name, age);
        }
    }

    interface test
    {
        void greet();
    }
    interface test1
    {
        void greetmore();
    }

    abstract class test3
    {
        protected int a = 20;
        public abstract void show();
    }
    class imp : test3
    {
        int b = 20, c;
        public override void show()
        {
            c = a + b;
            Console.WriteLine(c);
        }
    }
    class tester : test, test1
    {
        public void greet()
        {
            Console.WriteLine("hello");
        }

        public void greetmore()
        {
            Console.WriteLine("helllllllo");
        }
    }

        class mainClass
        {
            public static void Main(string[] args)
            {

            imp i = new imp();
            i.show();

            //tester t1 = new tester();
            //test t = (test)t1;
            //test1 t2 = (test1)t1;
            //t.greet();
            //t2.greetmore();
            //t1.greet();
            //t1.greetmore();

            //b ob = new b("gokul", 20);
            //ob.disp();

            //results s1 = new results();
            //s1.getinfo();
            //s1.show_results();

            //cube o1 = new cube();
            //square o = new square();
            //o.getdata();
            //o.area_sq();
            //o1.getdata();
            //o1.area_cu();

            //int val = 30;
            //app obj = new app(20,60);
            //obj.disc();
            //Console.WriteLine(obj.n1);
            
            //app o = new app();
            //Console.WriteLine("val of v b4 calling is {0}", val);
            //o.disp1(val);
            //Console.WriteLine("val of v after calling is {0}", val);
            //Console.WriteLine("val of v b4 calling is {0}", val);
            //o.disp2(ref val);
            //Console.WriteLine("val of v after calling is {0}", val);
            //o.showdate();

            //app o1 = new app();
            //app o2 = new app(10, 30);
            //app o3 = new app(o2);
            ////o1.Getdata();
            ////o1.SetData(10, 20);
            //o1.Cal();
            //o2.Cal();
            //o3.Cal();
            //o1.show();
            //o2.show();
            //o3.show(); 


            Console.Read();
            }
        }
    
}

