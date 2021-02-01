namespace _test
{
  class Program
  {
    static void Main(string[] args)
    {
      //Interfaces and DI
      new Printer(new ConsolePrint()).Print();
      new Printer(new PaperPrint()).Print();
      new Printer(new PagePrint()).Print();

      //Abstract class
      new Worker1().Do();
      new Worker2().Do();
      new Worker3().Do();

      //Virtual
      new Action().Comp();
      new Action1().Comp();
    }
  }
  interface IPrint
  {
    void Print();
  }
  class ConsolePrint : IPrint
  {
    public void Print()
    {
      System.Console.WriteLine("Console print.");
    }
  }
  class PaperPrint : IPrint
  {
    public void Print()
    {
      System.Console.WriteLine("Paper print.");
    }
  }
  class PagePrint : IPrint
  {
    public void Print()
    {
      System.Console.WriteLine("Page print.");
    }
  }
  class Printer
  {
    private readonly IPrint _printer;
    public Printer(IPrint print)
    {
      _printer = print;
    }
    public void Print()
    {
      _printer.Print();
    }
  }
  ///////////////////////////////////
  abstract class Worker
  {
    public void Do()
    {
      Work();
      Chill();
      WorkHard();
    }
    protected abstract void Work();
    protected abstract void Chill();
    protected abstract void WorkHard();
  }
  class Worker1 : Worker
  {
    protected override void Work()
    {
      System.Console.WriteLine("Work 1.");
    }
    protected override void Chill()
    {
      System.Console.WriteLine("Chill 1.");
    }
    protected override void WorkHard()
    {
      System.Console.WriteLine("WorkHard 1.");
    }
  }
  class Worker2 : Worker
  {
    protected override void Work()
    {
      System.Console.WriteLine("Work 2.");
    }
    protected override void Chill()
    {
      System.Console.WriteLine("Chill 2.");
    }
    protected override void WorkHard()
    {
      System.Console.WriteLine("WorkHard 2.");
    }
  }
  class Worker3 : Worker
  {
    protected override void Work()
    {
      System.Console.WriteLine("Work 3.");
    }
    protected override void Chill()
    {
      System.Console.WriteLine("Chill 3.");
    }
    protected override void WorkHard()
    {
      System.Console.WriteLine("WorkHard 3.");
    }
  }
  ////////////////////////////////////////
  class Action
  {
    public void Comp()
    {
      Act();
      ActV();
    }
    public void Act()
    {
      System.Console.WriteLine("Act.");
    }
    public virtual void ActV()
    {
      System.Console.WriteLine("ActV.");
    }
  }
  class Action1 : Action
  {
    public override void ActV()
    {
      System.Console.WriteLine("ActV 1.");
    }
  }
}
