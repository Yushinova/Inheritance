namespace Terminal
{
    public class AccountEventArgs
    {
        public string MyMassage { get; set; }
        public int Sum { get; }
        public AccountEventArgs(string mes, int sum)
        {
            MyMassage = mes;
            Sum = sum;
        }
    }
}