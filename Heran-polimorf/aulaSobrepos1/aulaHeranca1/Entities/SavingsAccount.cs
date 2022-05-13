namespace aulaSobrep1.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            //1º exemplo - fazendo diferente da regra da superclasse
            //Balance -= amount;
            
            //2º exemplo - aproveitando a regra da superclasse
            base.Withdraw(amount);
            Balance -= 2.0;
        }




    }
}
