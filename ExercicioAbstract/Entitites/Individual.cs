namespace ExercicioAbstract.Entitites
{
    class Individual : Taxes
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double healthexpenditures) : base(name, income)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double Calculo()
        {
            double value = 0;
            if(Income >= 20000)
            {
                value = (Income * 0.25) - (HealthExpenditures * 0.5);
            }
            else
            {
                value = (Income * 0.15) - (HealthExpenditures * 0.5);
            }
            return value;
        }
    }
}
