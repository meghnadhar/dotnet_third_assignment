using System;
using Calculation;

namespace perimeter
{   
   
    class Program
    {
        static void Main()
        { float len,bdth,s,s1,s2,b;
          Console.WriteLine("Select the object whose perimeter you want to calculate: 1.Rectangle 2.Square  3.Triangle");
          int a=int.Parse(Console.ReadLine());
          
          if(a==1){
               Console.WriteLine("Enter the length and breadth of the rectangle: ");
                len=float.Parse(Console.ReadLine());
                bdth=float.Parse(Console.ReadLine());
                if(len<=0 || bdth<=0){
                    Console.WriteLine("Length and Breadth should not be negative");
                }
               else{ Maths obj1= new Maths(len,bdth);
                float peri1=obj1.Cal_Perimeter(len,bdth);
                Console.WriteLine("The perimeter of the rectangle is {0}",peri1);}
          }
        else if(a==2){
               Console.WriteLine("Enter the side of the square: ");
                s=float.Parse(Console.ReadLine());
                if(s<=0){
                    Console.WriteLine("Side should not be negative");
                }
                else{Maths obj2= new Maths(s);
                float peri2=obj2.Cal_Perimeter(s);
                Console.WriteLine("The perimeter of the square is {0}",peri2);}
          }
          else if(a==3){
               Console.WriteLine("Enter the side1,side2 and baseside of the triangle: ");
                s1=float.Parse(Console.ReadLine());
                s2=float.Parse(Console.ReadLine());
                b=float.Parse(Console.ReadLine());
                if(s1<=0 || s2<=0 || b<=0){
                    Console.WriteLine("Neither of the sides nor the base can be negative");
                }
                else{Maths obj3= new Maths(s1,s2,b);
                float peri3=obj3.Cal_Perimeter(s1,s2,b);
                Console.WriteLine("The perimeter of the triangle is {0}",peri3);}
          }
        else{
            Console.WriteLine("You entered incorrect option");}
        }

          }
           





        }
    

