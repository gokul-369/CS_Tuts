using System;
using System.Collections;
using System.Threading;

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
        public void showdate()
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
            Console.WriteLine("I am showing the res as :{0}", res);
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
        public int side, lenth = 10, breadth = 20;
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
    class cube : val
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
        public int m1 = 92, m2 = 89;

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
        public void getall()
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
    class b : a
    {
        int age;
        public b(string n, int a) : base(n)
        {
            age = a;
        }

        public void disp()
        {
            Console.WriteLine("name:{0} and age is {1}", name, age);
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
    class fun
    {
        public void func()
        {
            Console.WriteLine("Function without parameters");
        }
        public void func(int a)
        {
            Console.WriteLine("Function with parameter and the parameter is {0}", a);
        }

        public void func(long a)
        {
            Console.WriteLine("Function with parameter with long type and parameter is {0} ", a);
        }

        public void func(long a, int b)
        {
            Console.WriteLine("Function with 2 parameter with long and int type and parameters are {0} and {1} ", a, b);
        }
        public void func(int a, long b)
        {
            Console.WriteLine("Function with 2 parameter with int and long type and parameters are {0} and {1} ", a, b);
        }

    }
    class op
    {
        public int a;

        public op(int n)
        {
            a = n;
        }

        public static op operator +(op obj, op obj1)
        {
            return new op(obj.a + obj1.a);
        }

        public static op operator -(op obj)
        {
            obj.a = -obj.a;
            return obj;
        }
        public void show()
        {
            Console.WriteLine("value is :{0}", a);
        }


    }
    class one
    {
        virtual public void show()
        {
            Console.WriteLine("Hello from class one");
        }
    }
    class two : one
    {
        public override void show()
        {
            Console.WriteLine("Hello from two");
        }
    }
    class three : one
    {
        public override void show()
        {
            Console.WriteLine("Hello from three");
        }
    }
    class demo
    {
        public static int a = 10;

        public void fun()
        {
            a = a + 10;
        }
        public void show()
        {
            Console.WriteLine(a);
        }
    }
    class addnumbers
    {
        int res;
        public addnumbers()
        {
            res = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                res = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught {0}", e);
            }
            finally
            {
                Console.WriteLine("Result is {0}", res);
            }
        }
    }
    class AgeException : ApplicationException
    {
        public AgeException(string msg) : base(msg)
        {

        }
    }
    class emp
    {
        public int emp_id, age;
        public void validate()
        {
            Console.WriteLine("Enter emp id and age:");
            emp_id = int.Parse(Console.ReadLine());
            age = int.Parse(Console.ReadLine());

            if (age < 21 && age > 58)
            {
                Console.WriteLine("Emp id is {0} and age is {1}", emp_id, age);
            }
            else
            {
                throw (new AgeException("You must be older than 21 and younger than 58"));
            }
        }

    }
    delegate void arithop(int x, int y);
    delegate void show();
    class mathop
    {
        public static void s1()
        {
            Console.WriteLine("Spain");
        }
        public static void s2()
        {
            Console.WriteLine("Madrid");
        }

        public static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
    class threadtest
    {
        public void DoTest()
        {
            Thread T1 = new Thread(new ThreadStart(Increment));
            Thread T2 = new Thread(new ThreadStart(Decrement));
            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;
            T1.Start();
            T2.Start();
        }
        public void Decrement()
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Decrement ={0}", i);

            }
        }
        public void Increment()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Increment ={0}", i);
                //Thread.Sleep(1000);
            }
        }

    }

    class mainClass
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();


            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Apple");
            //ht.Add(2, "Ball");
            //ht.Add(3, "Cat");
            //ht.Add(4, "Dog");
            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(k + ":" + ht[k]);
            //}

            //SortedList sl = new SortedList();
            //sl.Add(5, "las");
            //sl.Add(2, "bloke");
            //sl.Add(3, "lad");
            //sl.Add(4, "guy");
            //sl.Add(1, "gal");
            //foreach (var k in sl.Keys)
            //{
            //    Console.WriteLine(k + ":" + sl[k]);
            //}
            
            //ArrayList n = new ArrayList(sl.Values);
            //n.Reverse();
            //foreach (var i in n)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(n.Count);
            //Console.WriteLine(n.Capacity);

            //ArrayList n = new ArrayList();
            ////n.Add(10);
            //n.Add("chennai");
            //n.Add("Kochi");
            //n.Add("Bengaluru");
            //n.Add("Amristar");
            //n.Insert(0, "Darjiling");
            //n.Sort();
            //n.Reverse();
            //foreach (var i in n){
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(n.Capacity);

            //threadtest t = new threadtest();
            //t.DoTest();

            //arithop op1 = new arithop(mathop.add);
            //arithop op2 = new arithop(mathop.sub);
            //op1(4,8);
            //op2(19, 10);
            //show op3 = new show(mathop.s1);
            //op3();
            //Console.WriteLine();
            //show op4 = new show(mathop.s2);
            //op4();
            //Console.WriteLine();
            //show op5 = op3 + op4;
            //op5();
            //Console.WriteLine();
            //show op6 = op3 - op4;
            //op6();

            //emp e1 = new emp();
            //try
            //{
            //    e1.validate();
            //}
            //catch (AgeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //int a, b, c;
            //b = 18;
            //c = 2;
            //int[] arr = new int[4];
            //try
            //{
            //    a = b / c;
            //    arr[9] = 7;

            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //addnumbers o1 = new addnumbers();
            //o1.division(9, 0);

            //demo w = new demo();
            //demo w1 = new demo();
            //w.show();
            //w1.show();
            //w.fun();
            //w.show();
            //w1.show();

            //one obj = new one();
            //obj.show();
            //obj = new two();
            //obj.show();
            //obj = new three();
            //obj.show();

            //op o1 = new op(4);
            //op o2 =new op(5);
            //op o3;
            //o1.show();
            //o2.show();
            //o3 = o1 + o2;
            //o3.show();
            //o3 = -o3;
            //o3.show();

            //fun ob = new fun();
            //ob.func();
            //ob.func(3);
            //ob.func(8L);
            //ob.func(8L, 3);
            //ob.func(3, 8L);

            //imp i = new imp();
            //i.show();

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

