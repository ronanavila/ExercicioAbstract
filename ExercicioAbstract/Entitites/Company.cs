namespace ExercicioAbstract.Entitites
{
    class Company : Taxes
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double income, int numberOfEmployes) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployes;
        }
        public override double Calculo()
        {
            double value = 0.0;
            if (NumberOfEmployees > 10)
            {
                value = Income * 0.14;
            }
            else
            {
                value = Income * 0.16;
            }
            return value;
        }
    }
}
