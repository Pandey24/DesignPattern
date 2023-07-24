
/* Online C# Compiler and Editor */
using System.IO;
using System;
namespace fa
{
public interface Icar
  {
    int getspeed();
  }
 public class EC1:Icar
  {
    public int getspeed()
    {
      return 100;
    }
  }
 public  class EC2:Icar
  {
    public int getspeed()
    {
      return 150;
    }
  }
  public  class LC1:Icar
  {
    public int getspeed()
    {
      return 200;
    }
  }
public class LC2:Icar
  {
    public int getspeed()
    {
      return 250;
    }
  }
  public interface IcarFactory
  {
    Icar  getInstance(int price);
  }
  public class ECarFactory:IcarFactory
  {
    public Icar getInstance(int price)
    {
      if(price > 1 && price <= 2) return EC1;
      else   if(price > 2 && price >=2.5) return EC2;
      return null;
    }
  }
   public class LCarFactory:IcarFactory
  {
    public Icar getInstance(int price)
    {
      if(price > 3 && price <= 3.5) return LC1;
      else   if(price > 3.5 && price >=4) return LC2;
        return null;
    }
  }
  public class AbstractFactory
  {
    public IcarFactory getFactory(string value)
    {
      if(value=="EC") return ECarFactory;
      else  if(value=="LC") return LCarFactory;
       return null;
    }
  }
class Program
{
    static void Main()
    {
           AbstractFactory ab=new AbstractFactory();
      IcarFactory=ab.getFactory("EC");
      Icar car=IcarFactory.getInstance(2.5);
      Console.WriteLine ("EC car speed :"+car.getspeed());
        Console.WriteLine("Hello, World!");
    }
}
}
