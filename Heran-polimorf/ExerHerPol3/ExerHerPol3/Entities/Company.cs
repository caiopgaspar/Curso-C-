namespace ExerHerPol3.Entities
{
    internal class Company : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public Company () { }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }

    }
}
