namespace FormationCSharpInterNantes.TellDontAsk
{
    internal interface IAccountRepository
    {
        Account FindById(int accountId);

        void Save(Account account);
    }
}
