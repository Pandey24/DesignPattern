//Example: UI Theme Factory (Dark / Light Theme) 2025
//We’ll build a factory that can create Buttons and Checkboxes depending on the theme.
// Product A
public interface IButton
{
    void Render();
}

// Product B
public interface ICheckbox
{
    void Render();
}

// create product

// Dark theme products
public class DarkButton : IButton
{
    public void Render() => Console.WriteLine("Dark Button rendered");
}

public class DarkCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Dark Checkbox rendered");
}

// Light theme products
public class LightButton : IButton
{
    public void Render() => Console.WriteLine("Light Button rendered");
}

public class LightCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Light Checkbox rendered");
}

// ---------------Create Abustract factory
public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

//Concrete Factories
public class DarkThemeFactory : IUIFactory
{
    public IButton CreateButton() => new DarkButton();
    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}

public class LightThemeFactory : IUIFactory
{
    public IButton CreateButton() => new LightButton();
    public ICheckbox CreateCheckbox() => new LightCheckbox();
}

/// client code
public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(IUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void RenderUI()
    {
        _button.Render();
        _checkbox.Render();
    }
}


//main code
using System;
using System.Collections.Generic;

class Program
{
    // Queue to hold data
    static Queue<string> myQueue = new Queue<string>();

    static void Main()
    {
        // Add items (each will be processed immediately)
        AddAndProcess("Task 1");
        AddAndProcess("Task 2");
        AddAndProcess("Task 3");
    }

    // Function to add item and process it
    static void AddAndProcess(string item)
    {
        myQueue.Enqueue(item);
        Console.WriteLine($"Added: {item}");

        // Process immediately
        ProcessItem(myQueue.Dequeue());
    }

    static void ProcessItem(string item)
    {
        Console.WriteLine($"Processing: {item}");
    }
}


