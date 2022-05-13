namespace ExerHerPol3.Entities
{
    abstract internal class TaxPayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayers() { }

        public TaxPayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
                
        
    }
}
