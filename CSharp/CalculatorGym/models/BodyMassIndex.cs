namespace CalculatorGym.models
{
    public class BodyMassIndex
    {
       private Double Height, Weight;

       public double height
       {
           get
           {
               return Height;
           }

           set
           {
               Height = value;
           }
       }

       public double weight
       {
           get
           {
               return Weight;
           }
           
           set
           {
               Weight = value;
           }
        }

        public void BMI()
        {
            double bmi; 
            System.Console.WriteLine("Body Mass Index Table: \n Below   18.49          => Below Weight \n Between 18.5 and 24.99 => Normal Weight \n Between 25.0 and 29.99 => About Weight \n Between 30.0 and 34.99 => Obesity(Degree 1) \n Between 35.0 and 39.99 => Obesity(Degree 2) \n Above   40.0           => Morbid Obesity" );
            System.Console.WriteLine("Enter with your Height:");
            height = double.Parse(Console.ReadLine());
            if(height < 0)
            {
                System.Console.WriteLine("Invalid Value");
                System.Console.WriteLine("Enter com um valor valido");
                height = double.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Enter with your Weight:");
            weight = double.Parse(Console.ReadLine());
            bmi = weight/(height*height);
            if(bmi < 18.5)
            {
                System.Console.WriteLine("You this below weight, your body mass index is {0}", bmi);
            } 
            else if(bmi < 25)
            {
                System.Console.WriteLine($"You this normal weight, your body mass index is {bmi}");
            } 
            else if(bmi < 30)
            {
                System.Console.WriteLine($"You this about weight, your body mass index is {bmi}");
            }
            else if(bmi < 35)
            {
                System.Console.WriteLine($"You this degree obesity 1, your body mass index is {bmi}");
            }
            else if(bmi < 40)
            {
                System.Console.WriteLine($"You this degree obesity 2, your body mass index is {bmi}");
            }
            else
            {
                System.Console.WriteLine($"You this with morbid obesity, your body mass index is = {bmi}");
            }
        }

        public void HW()
        {
            System.Console.WriteLine($"Height = {Height}, Weight = {Weight}");
        }
    }  
}