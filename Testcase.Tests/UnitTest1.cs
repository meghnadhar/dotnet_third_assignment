using System;
using Xunit;
using Calculation;


namespace Testcase.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange//
            Maths ob1=new Maths(5,6);

            //Act//
            float result_rect= ob1.Cal_Perimeter(5,6);
            
            //Assert//
            Assert.IsType<float>(result_rect);
            Assert.Equal(22,result_rect);
            Assert.NotEqual(23,result_rect);
            
        }
         public void Test2()
        {
            //Arrange//
            Maths ob2=new Maths(6);

            //Act//
            float result_square= ob2.Cal_Perimeter(5,6);
            
            //Assert//
            Assert.IsType<float>(result_square);
            Assert.Equal(24,result_square);
            Assert.NotEqual(23,result_square);
            
        }

         public void Test3()
        {
            //Arrange//
            Maths ob3=new Maths(5,6,7);

            //Act//
            float result_triangle= ob3.Cal_Perimeter(5,6,7);
            
            //Assert//
            Assert.IsType<float>(result_triangle);
            Assert.Equal(22,result_triangle);
            Assert.NotEqual(23,result_triangle);
            
        }
    }
}
