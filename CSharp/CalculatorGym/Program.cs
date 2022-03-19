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
      System.Console.WriteLine("Select the desired option:\n Body Mass Index = 1");
      option = Console.ReadLine();
      if (option == "1")
      {
        BodyMassIndex body = new BodyMassIndex();
        body.BMI();
        body.HW();
      }

    }
  }
}
