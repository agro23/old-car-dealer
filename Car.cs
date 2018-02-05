using System;
using System.Collections.Generic;

class Car
{
    private string _Make;
    private string _Model;
    private int _Miles;
    private int _Money; // should I use an int for now or float for decimals?
    private bool _Used;

    public Car(string Make, string Model, int Miles, int Money)
    {
      _Make = Make;
      _Model = Model;
      _Miles = Miles;
      _Money = Money;
      _Used = true;
    }

    public string getMake()
    {
      return _Make;
    }

    public void setMake(string myMake)
    {
      _Make = myMake;
    }

    public string getModel()
    {
      return _Model;
    }

    public void setModel(string myModel)
    {
      _Model = myModel;
    }

    public int getMiles()
    {
      return _Miles;
    }

    public void setMiles(int myMiles)
    {
      _Miles = myMiles;
    }

    public int getMoney()
    {
      return _Money;
    }

    public void setMoney(int myMoney)
    {
      _Money = myMoney;
    }

    public bool getUsed()
    {
      return _Used;
    }

    public void setUsed(bool myUsed)
    {
      _Used = myUsed;
    }

    public string Describe(Car myCar)
    {
      string describeIt = "This " + myCar.getMake()+ " is a";
      if (myCar.getMoney() < 30000)
      {
          describeIt += "n affordable";
      } else if (myCar.getMoney() > 75000)
      {
          describeIt += " fancy";
      } else
      {
          describeIt += "n average";
      }
      describeIt += " vehicle.";
      return describeIt;
    }
}

public class Program
{

    public static void Main()
    {
      Car truck = new Car ("Dodge", "Ram", 54321, 32000);
      Car car1 = new Car ("Saturn", "SL2", 23231, 16000);
      Car car2 = new Car ("Jeep", "Cherokee", 123321, 8000);
      Car car3 = new Car ("DMC", "Delorean", 88, 123546);
      Car truck1 = new Car ("Chevy", "Tahoe", 232323, 15444);

      string carType = "";

      List<Car> Cars = new List<Car>(){truck, car1, car2, car3, truck1};
      foreach (var el in Cars)
      {
          // el.Describe(Car el);
          Console.WriteLine("You're looking at a " +el.getMake()+ " " + el.getModel() + " with " + el.getMiles() + " miles on it." );
          Console.WriteLine("It will only cost you $" + el.getMoney() + ".");
          Console.WriteLine(el.Describe(el));
      }
      Console.WriteLine("Input your maximum price to spend:");
      var maxPrice = Console.ReadLine();
      Console.WriteLine("Input your maximum miles you'd accept.:");
      var maxMile = Console.ReadLine();
      Console.WriteLine("The vehicles that match your needs are: ");
      // List<Car> Cars1 = new List<Car>(){truck, car1, car2, car3, truck1};
      // foreach (var el1 in Cars1)
      // {
      //   var x = el1.getMiles().Parse();
      //   var y = el1.getMoney().Parse();
      //   Console.WriteLine(x,y);
      //
      //   // if (x.Parse < maxMile && y.Parse < maxPrice) {
      //   //   Console.WriteLine("A " + el1.getMake() + " " + el1.getModel());
      //   // }
      // }
      
    }
}
