namespace ExercicioAbstract.Entitites
{
    public abstract class Taxes
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Taxes(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Calculo();
    }
}
