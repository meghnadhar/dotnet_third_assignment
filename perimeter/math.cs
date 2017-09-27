using System;
using perimeter;

namespace Calculation{

public class Maths{

    Rectangle rt =new Rectangle();
    Square sq = new Square();
    Triangle tg =new Triangle();

    public Maths(float len,float bdth){
        rt.Length=len;
        rt.Breadth=bdth;
    }
    public Maths(float s){
        sq.side=s;
    }
    public Maths(float s1,float s2,float b){
        tg.side1=s1;
        tg.side2=s2;
        tg.baseside=b;
    }
    public float Cal_Perimeter(float len,float bdth){
        return 2*(len+bdth);
    }
    public float Cal_Perimeter(float s){
        return 4*s;
    }
    public float Cal_Perimeter(float s1,float s2,float b){
        return s1+s2+b;
    }
}
}



