
/* Online C# Compiler and Editor https://www.tutorialspoint.com/compile_csharp_online.php */
/* Online C# Compiler and Editor https://www.w3schools.com/cs/trycs.php?filename=demo_compiler */
using System.IO;
using System;
namespace AbsFactory
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
      if(price > 1 && price <= 2) return new  EC1();
      else   if(price > 2 && price >=2.5) return new EC2();
      return null;
    }
  }
   public class LCarFactory:IcarFactory
  {
    public Icar getInstance(int price)
    {
      if(price > 3 && price <= 3.5) return new LC1();
      else   if(price > 3.5 && price >=4) return new LC2();
        return null;
    }
  }
  public class AbstractFactory
  {
    public IcarFactory getFactory(string value)
    {
      if(value=="EC") return new ECarFactory();
      else  if(value=="LC") return new LCarFactory();
       return null;
    }
  }
class Program
{
    static void Main()
    {
             AbstractFactory ab=new AbstractFactory();
      IcarFactory IcarFactory=ab.getFactory("EC");
      Icar car=IcarFactory.getInstance(20);
      Console.WriteLine ("EC car speed :"+car.getspeed());
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
    }
}
}
