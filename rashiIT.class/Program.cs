// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("welcome rashi");
//int first = 8;
//int second = 7;
//int result = first + second;
//Console.WriteLine(result);
using rashiIT;
using rashiITclass;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.AccessControl;
using System.Xml.Linq;

//Console.WriteLine("plz enter your number");
//int firstnumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("plz enter your number");
//int secondnumber = Convert.ToInt32(Console.ReadLine());
//int result = firstnumber + secondnumber;
//Console.WriteLine("the sum of two numbers" + result);

//Console.WriteLine("plz enter your number");
//int first = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("plz enter your second number");
//int second = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("plz enter your operation to perform");
//string operation = Console.ReadLine();
//int result = 0;
//if (operation == "sum")
//{
//    result = first + second;
//}
//else if (operation == "subtract")
//{ result = first - second;
//}
//else if (operation == "multiply")
//{ result = first * second;
//}
//else if (operation == "divide")
//{
//    result = first % second;
//}
//else
//    Console.WriteLine("you have enter wrong opertaion");

//Console.WriteLine("the" + operation + "of the two numbers" + result);

//Console.WriteLine ("enter your operation to perform");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 2 == 0  & number % 5 == 0 )
//    Console.WriteLine(number + " is even numbber  and divisible by 5");
//else
//     Console.WriteLine(number + " is odd number  and not divisable by 5");

////homwork...............

//Console.WriteLine("enter first student name");
//string firststudent = Console.ReadLine();
//Console.WriteLine("enter your english marks");
//int english1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your maths marks");
//int maths1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your sst marks");
//int sst1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your science marks");
//int science1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your hindi marks");
//int hindi1 = Convert.ToInt32(Console.ReadLine());
//int result = english1 + maths1 + sst1 + science1 + hindi1;
//Console.WriteLine("the total marks of first student is "  +  result);
//int p1 = result*100/500;
//Console.WriteLine("the percentage of first student is " + p1  + "%");
//if (p1 <= 33)
//    Console.WriteLine("fail");
//else if (p1 <= 60)
//    Console.WriteLine("second");
//else if (p1 >= 60)
//    Console.WriteLine("first");
//Console.WriteLine("enter second student name");
//string secondstudent = Console.ReadLine();
//Console.WriteLine("enter your english marks");
//int english2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your maths marks");
//int maths2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your sst marks");
//int sst2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your science marks");
//int science2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your hindi marks");
//int hindi2 = Convert.ToInt32(Console.ReadLine());
//int result2 = english2 + maths2 + sst2 + science2 + hindi2;
//Console.WriteLine("the total marks of second student is " + result2);

//int p2 = result2*100/500;
//Console.WriteLine("the percentage of second student is " + p2 + "%");
//if (p2 <= 33)
//    Console.WriteLine("fail");
//else if (p2<= 60)
//    Console.WriteLine("second");
//else if (p2 >= 60)
//    Console.WriteLine("first");

//Console.WriteLine("enter third student name");
//string thirdstudent = Console.ReadLine();
//Console.WriteLine("enter your english marks");
//int english3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your maths marks");
//int maths3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your sst marks");
//int sst3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your science marks");
//int science3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter your hindi marks");
//int hindi3 = Convert.ToInt32(Console.ReadLine());
//int result3 = english3 + maths3 + sst3 + science3 + hindi3;
//Console.WriteLine("the total marks of third student is " + result3);
//int p3 = result3 *100/500;
//Console.WriteLine("the percentage of third student is " + p3 + "%");
//if (p3<= 33)
//    Console.WriteLine("fail");
//else if (p3 <= 60)
//    Console.WriteLine("second");
//else if (p3 >= 60)
//    Console.WriteLine("first");

//////////////////////////////////////////////////////MSIL///////////////////////////////////////////////////////////////
///


//bool first = true;
//int a = 7;
//string ram = "rashi is good";
//char harry = 'a';
//DateTime porter = DateTime.Now;
//byte varbyte = 250;
//sbyte varbyte2 = -120;
//Console.WriteLine();/////////
//string varbyte4 = default;////null//
//int i = default(int);
//Console.WriteLine(i);
//Console.WriteLine(first);
//Console.WriteLine(harry);
//Console.WriteLine(varbyte);


//declaretion of array
//int[] arrayint = new int[5];
//arrayint[0] = 10;
//arrayint[1] = 20;
//arrayint[2] = 30;
//arrayint[3] = 40;
//arrayint[4] = 50;
//Console.WriteLine(arrayint[1]);
//for (int i = 0; i < arrayint.Length; i++)
//    Console.WriteLine(arrayint[i]);
//foreach (int all in arrayint)
//{
//    Console.WriteLine(all);
//}
//int count = 0;
//foreach (int all in arrayint)
//    if (count < 5)
//    {
//        Console.WriteLine(all);
//        count++;
//    }

//int count = 0;
//while (count < 2)
//{
//    Console.WriteLine(arrayint[count]);
//    count++;
//}

//int count = 0;
//do
//{
//    Console.WriteLine(arrayint[count]);
//    count++;
//}
//while (count < 3);

//string[] value = new string[5] { "rashi", "rupal", "neha", "diya", "gopi" };
//Console.WriteLine(value[3]);
//for (int i = 0; i < value.Length; i++)
//    Console.WriteLine(value[i]);
//foreach (string name in value)
//    Console.WriteLine(name);
//int count = 0;
//foreach (string name in value)
//    if (count < 4)
//    {
//        Console.WriteLine(name);
//        count++;
//    }
//int count = 0;
//while (count < 2)
//{
//    Console.WriteLine(value[count]);
//    count++;
//}
//int count = 0;
//do
//{
//    Console.WriteLine(value[count]);
//    count++;
//}
//while (count < 4);




//Console.WriteLine("plz enter your number");
//int number = Convert.ToInt32(Console.ReadLine());
//switch (number)
//{
//    case 1:
//        {
//            Console.WriteLine("this is monday");
//            break;
//        }
//    case 2:
//        {
//            Console.WriteLine("this is tuesday");
//            break;
//        }
//    case 3:
//        {
//            Console.WriteLine("this is wednesday");
//            break;
//        }
//    case 4:
//        {
//            Console.WriteLine("this is thursday");
//            break;
//        }
//    case 5:
//        {
//            Console.WriteLine("this is friday");
//            break;
//        }
//    case 6:
//        {
//            Console.WriteLine("this is saturday");
//            break;
//        }
//    case 7:
//        {
//            Console.WriteLine("this is sunday");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("enter wrong input");
//            break;
//        }
//}

/////////////////////////////////////reverse number//////////////////////////

///////////////while loop//////////////
//Console.WriteLine("plase enter your number");
//int number = Convert.ToInt32(Console.ReadLine());
//int rem = 0;
//int reverse = 0;
//while (number < 0)
//{
//    rem = number % 10;
//    reverse = reverse * 10 + rem;
//    number = number / 10; 

//}
//Console.WriteLine("the reverse number is  " + reverse);

///////////////////////////////do while////////////////////////

//Console.WriteLine("plz enter your number");
//int input = Convert.ToInt32(Console.ReadLine());
//int rem = 0;
//int reverse = 0;
//do
//{ rem = input % 10;
//    reverse = reverse * 10 + rem;
//    input = input / 10;
//}
//while (input > 0);

//Console.WriteLine("the reverse number is "  + reverse);


///////////////////////////////object oriented programming////////////////////

//////////////////value assingment///////////

//car Objcar = new car();

//Objcar.name = "Honda city";

//Console.WriteLine("the car name is : " + Objcar.name);

//Objcar.brand = "honda";

//Console.WriteLine("the brand name is : " + Objcar.brand);

//Objcar.color = "red";

//Console.WriteLine("the color of the car is : " + Objcar.color); 

//Objcar.noofseat = 5;
//Console.WriteLine("the seats in the cars are : "  + Objcar.noofseat);


////////////////////////////method/////////////////////////

//int speed = Objcar.Acclerator(pressure:100);

//Console.WriteLine("speed after passing acclerator is : " + speed);

//int speed2 = Objcar.Break(pressure:100);
//Console.WriteLine("the speed after passing break is : " + speed2);

//int speed3 = Objcar.Clucth(pressure:100);

//Console.WriteLine("the speed after passing clucth is : " + speed3);



////////////////////////2nd type of car////////////////////



//Objcar.name = "ford";
//Console.WriteLine("the car name is : " + Objcar.name);
//Objcar.brand = "nexa";
//Console.WriteLine("the brand name is :  " + Objcar.brand);
//Objcar.color = "white";
//Console.WriteLine("the color of the car is : " + Objcar.color);
//Objcar.noofseat = 7;
//Console.WriteLine("the seats are : " + Objcar.noofseat);

////method//
//int pressure = 100;

//int speed4= Objcar.Acclerator(pressure);
//Console.WriteLine("the spped after passing acclerator : " + speed4);
//int speed5 = Objcar.Break(pressure);
//Console.WriteLine("the speed of break is : "  + speed5);
//int speed6 = Objcar.Clucth(pressure);
//Console.WriteLine("the speed of clucth is "  + speed6);

//////////////////3rd type of car///////////////

//Objcar.name = "xuv";
//Console.WriteLine("the care name is : " + Objcar.name);
//Objcar.brand = "nexon";
//Console.WriteLine("the brand name of car is : " + Objcar.brand);
//Objcar.color = "navy blue";
//Console.WriteLine("the color is : " + Objcar.color);
//Objcar.noofseat = 7;
//Console.WriteLine("tne seats are " + Objcar.noofseat);

//int pressure2 = 200;
//int speed7 = Objcar.Acclerator(pressure);
//Console.WriteLine("the speed of acclerator is :  " + speed7);
//int speed8 = Objcar.Break(pressure);
//Console.WriteLine("the speed of break is : " + speed8);
//int speed9 = Objcar.Clucth(-pressure);
//Console.WriteLine("the speed of clucth is : " + speed9);



//////method overloading//////////


//Methods objx = new Methods();
//objx.test();

//objx.Sum(34, 34);

//objx.sumarray(new[] { 10, 20, 30, 41 });


//int[] result = objx.getarray(35, 65);
// foreach(int i in result)
//{
//    Console.WriteLine(i);
//}

//objx.xxx (2, 4, 6, 8, 10,12,14,16,18,20);

////contructor calling//

//Constructor objve = new Constructor();
//objve.color = "black";
//Console.WriteLine("the color is :  "  + objve.color);
//objve.number = 889;
//Console.WriteLine(objve.number);
//Console.WriteLine(objve.number2);


//////////////////////static example///

//staticclass objse = new staticclass();
//Console.WriteLine(objse.num);//55
//objse.num = 67;
//Console.WriteLine(objse.num);//67
//staticclass objse1 = new staticclass();
////objse1.num = 6;
//Console.WriteLine(objse1.num);//55
//staticclass objse2 = new staticclass();
//objse2 = objse;
//Console.WriteLine(objse2.num);//67
//objse = null;
//Console.WriteLine(objse2.num);//67
//Console.WriteLine(objse.num);   

/////////////////////////////static and nonstatic/////

//Console.WriteLine(staticclass.number);
//staticclass.value();
//objse.nonstatic();

//Constructor constructor();

//Constructor . word = "female";

//Constructor objram = new Constructor();
//Constructor objram1 = new Constructor();
//Constructor objram2 = new Constructor();

////////////////////////////////////////////////////INHERITANCE///////////////////////////////

//parents objfam = new parents();
//objfam.parent();
//Console.WriteLine("===================================================");
//child objx = new child();
//objx.chid();
//objx.parent();

//Console.WriteLine("======================================================");
// grandchild objvc  = new grandchild();
//objvc.parent();
//objvc.chid();
//objvc.gc();
////////////////////////method over ride///////////////////

//B objb = new B();
//objb.methodA();

//c objc = new c();
//objc.methodA();


//methodhiding2 obj2 = new methodhiding2();
//obj2.parent();

//methodhiding objn = new methodhiding2();
//objn.parent();

//DateTime rr = new DateTime(2024,2,12);
//Console.WriteLine(rr);



//////////////////INTERFACE//////////////

Honda objq = new Honda();
objq.acclerator();
objq.breakee();
int result = objq.varint(7, 4);
Console.WriteLine(result);
objq.sum(5, 5);

int a = 10;
int b = 20;








Console.ReadLine();
