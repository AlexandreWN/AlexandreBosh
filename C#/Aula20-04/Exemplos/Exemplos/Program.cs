using System;
/*
Creeper creeper = new Creeper();
SpiderMount mount = new SpiderMount();
creeper.Render();
mount.Enemy = creeper;

public abstract class Enemy
{
    public abstract void Render();
}

public class Spider : Enemy
{
    public override void Render()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Spider");
    }
}
public class Creeper : Enemy
{
    public override void Render()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Creeper");
    }
}

public class SpiderMount : Enemy
{
    public override void Render()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mount");
    }
}
*/

Function f = new Constant()
{
    Value = 8
};
Console.WriteLine(f.Derive().Derive());

/*TEMPLATE METOD*/
public abstract class Function
{
    public abstract double this[double x] { get; }

    protected abstract string tostring();

    public override string ToString()
    {
        return "f(x) = " + tostring();
    }

    public abstract Function Derive();
}

public class Constant : Function
{
    public double Value { get; set; }

    public override double this[double x] => Value;

    public override Function Derive()
    {
        Constant constant = new Constant();
        constant.Value = 0;
        return constant;
    }

    protected override string tostring()
        => Value.ToString();
  
}