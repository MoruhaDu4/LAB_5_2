namespace Lab_5_2
{
    public interface IParent
    {
        string Info();
        double Metod();
    }

    public class Child1 : IParent
    {
        private double pole1;
        private double pole2;

        
        public Child1(double income, double taxRate)
        {
            pole1 = income;
            pole2 = taxRate;
        }

        
        public string Info()
        {
            return $"Дохiд: {pole1}, Ставка податку: {pole2}%";
        }

        
        public double Metod()
        {
            return (pole1 * pole2) / 100;
        }
    }

    public class Child2 : IParent
    {
        private double pole3;
        private double pole4;
        private double pole5;
        private double pole6; 

        
        public Child2(double revenue, double costPrice, double additionalExpenses, double taxRate)
        {
            pole3 = revenue;
            pole4 = costPrice;
            pole5 = additionalExpenses;
            pole6 = taxRate;
        }

        public string Info()
        {
            return $"Виручка: {pole3}, Собiвартiсть: {pole4}, Додатковi витрати: {pole5}, Ставка податку: {pole6}%";
        }

      public double Metod()
        {
            double profit = pole3 - pole4 - pole5;
            return (profit * pole6) / 100;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                IParent taxpayer;
                string taxpayerType;
                if (random.Next(2) == 0)
                {
                    
                    double income = random.Next(20000, 80000);
                    double taxRate = random.Next(10, 30);
                    taxpayer = new Child1(income, taxRate);
                    taxpayerType = "Фiзична Особа";
                }
                else
                {
                    double revenue = random.Next(50000, 150000);
                    double costPrice = random.Next(30000, 100000);
                    double additionalExpenses = random.Next(1000, 5000);
                    double taxRate = random.Next(15, 25);
                    taxpayer = new Child2(revenue, costPrice, additionalExpenses, taxRate);
                    taxpayerType = "Юридична Особа";
                }


                Console.WriteLine($"{taxpayerType}:"); 
                Console.WriteLine(taxpayer.Info());



                double tax = taxpayer.Metod();
                Console.WriteLine($"Податок: {tax}");
                Console.WriteLine();
            }
        }
    }
}