using System;

namespace FactoryPattern
{
public interface shape
{
 void area();
}
public class circal:shape
{
 public void area(){ Console.WriteLine("Area of circal");   }
}
 
public class squre:shape
{
 public void area(){ Console.WriteLine("Area of squre");   }
}
  
 public class Shapefactory
 {
 public shape getinstance(string value)
 {
 if(value=="circal")
 {
return new circal();
 }
  if(value=="squre")
 {
return new squre();
 }
 return null;
 }
}
  
  class Program
  {
    static void Main(string[] args)
    {
    Shapefactory factory= new Shapefactory();
  shape s=factory.getinstance("squre");
  //shape s =new squre();
   s.area();
      Console.WriteLine("Hello World!");    
    }
  }
}
