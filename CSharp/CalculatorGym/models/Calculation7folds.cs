namespace CalculatorGym.models
{
    public class Calculation7folds
    {
        private double[] sevenmFolds = new double[7];
        
        private double DC{ get; set; } 
        private double FM{ get; set; } 
        private double MM{ get; set; }
        private double PFM{ get; set; } 
        private double Weight{ get; set; }

        private int Age{ get; set; }

        private const double aDC= 1.112, bDC= 0.00043499, cDC= 0.00000055, dDC= 0.00028826;
        
        private const double aPFM= 4.95, bPFM= 4.50;

        private const int cPFM= 100;
        // private int age
        // { 
        //     get
        //     {
        //         return Age;
        //     } 
            
        //     set
        //     {
        //         Age = value;
        //     }
        // }

        // private double dc
        // {
        //     get
        //     {
        //         return DC;
        //     }

        //     set
        //     {
        //         DC = value;
        //     }
        // }

        // private double fm
        // {
        //     get
        //     {
        //         return FM;
        //     }

        //     set
        //     {
        //         FM = value;
        //     }
        // }

        // private double pfm
        // { 
        //     get
        //     {
        //         return PFM;
        //     } 
            
        //     set
        //     {
        //         PFM = value;
        //     }
        // }

        // private double weight
        // {
        //     get
        //     {
        //         return Weight;
        //     }

        //     set
        //     {
        //         Weight = value;
        //     }
        // }

        public void Calculator()
        {
            System.Console.WriteLine("Enter with your Age");
            Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter with your Weight");
            Weight = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the triceps");
            sevenmFolds[0] = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the subEscapular");
            sevenmFolds[1] = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the peitoral");
            sevenmFolds[2] = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the axiliar média");
            sevenmFolds[3] = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the abdominal");
            sevenmFolds[4] = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the supra ilíaca");
            sevenmFolds[5] = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter value of the coxa");
            sevenmFolds[6] = double.Parse(Console.ReadLine());
        }

        public void BodyDensity()
        {
            System.Console.WriteLine();
            DC = Math.Round((aDC - bDC * sevenmFolds.Sum() + cDC * (sevenmFolds.Sum()* sevenmFolds.Sum()) - dDC * Age), 5);
            System.Console.WriteLine("Your body density is, {0};", DC);
        }
        
        public void PercentFatMass()
        {
            System.Console.WriteLine();
            PFM = Math.Round(((aPFM / DC) - bPFM) * cPFM, 2);
            System.Console.WriteLine($"Your percent fat mass is, {PFM}"); 
        }

        public void FatMass()
        {
            System.Console.WriteLine();
            FM = Math.Round((Weight * PFM / cPFM), 2);
            System.Console.WriteLine($"Your fat mass is, {FM}");
        }

        public void LeanMass()
        {
            System.Console.WriteLine();
            MM = Math.Round((Weight - FM), 2);
            System.Console.WriteLine("Your lean mass is, {0}", MM);           
        }
    }
}