namespace FormationCSharpInterNantes.TellDontAsk
{
    internal class Account
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public Account(int id, double balance)
        { 
            Id = id; 
            Balance = balance; 
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount) throw new ArgumentException("Error : not enough money !");
            Balance -= amount;
        }
    }
}
