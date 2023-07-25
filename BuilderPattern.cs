using System;

namespace BuilderPattern
{

public class Computer
{
public string Processor {get;set;}
public int Ram  {get;set;}
public int Storage  {get;set;}
public string Name {get;set;}
public void Display()
{
Console.WriteLine($"Processor:{Processor}"); 
Console.WriteLine($"Ram:{Ram} GB");   
Console.WriteLine($"Storage:{Storage} GB");  
Console.WriteLine($"Name:{Name}");   
 
}
}
public class ComputerBuilder
{

  private Computer computer = new Computer();

    public ComputerBuilder SetProcessor(string processor)
    {
        computer.Processor = processor;
        return this;
    }
    public ComputerBuilder SetRam(int Ram)
    {
    computer.Ram=Ram;
    return this;
    }
     public ComputerBuilder SetStorage(int Storage)
    {
    computer.Storage=Storage;
    return this;
    }
     public ComputerBuilder SetName(string Name)
    {
    computer.Name=Name;
    return this;
    }
    public Computer Build()
    { 
    return computer;
    }

}
  class Program
  {
    static void Main(string[] args)
    {
    Computer computer =new ComputerBuilder()
    .SetProcessor("intel I core 3")
    .SetRam(8)
    .SetStorage(500)
    .SetName("HP")
    .Build();
    
    computer.Display();
    
    }
  }
}
/*
Run this programm in https://www.w3schools.com/cs/trycs.php?filename=demo_compiler
Output
Processor:intel I core 3
Ram:8 GB
Storage:500 GB
Name:HP


*/
