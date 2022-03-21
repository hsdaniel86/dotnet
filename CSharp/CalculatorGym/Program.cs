using CalculatorGym.models;

namespace CalculatorGym
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculator();
    }

    static void Calculator()
    {
      string option;
      System.Console.WriteLine("Select the desired option:\n Body Mass Index = 1 \n Body Density = 2");
      option = Console.ReadLine();
      if (option == "1")
      {
        BodyMassIndex body = new BodyMassIndex();
        body.BMI();
        body.HW();
      }
      else if(option == "2")
      {
        string options;
        Calculation7folds calc = new Calculation7folds();
        calc.Calculator();
        calc.BodyDensity();
        System.Console.WriteLine("You desired calculate percent of fat mass \n for yes type = S if no type = N;");
        options = Console.ReadLine();
        if(options == "S" || options == "s")
        {
          calc.PercentFatMass();
          System.Console.WriteLine("You desired calculate your fat mass \n for yes type = S if no type = N;");
          options = Console.ReadLine();
          if(options == "S")
          {
            calc.FatMass();
            System.Console.WriteLine("You desired calculate your lean mass \n for yes type = S if no type = N;");
            options = Console.ReadLine();
            if(options == "S")
            {
              calc.LeanMass();
            }

          }
            
        }
      }

    }
  }
}
