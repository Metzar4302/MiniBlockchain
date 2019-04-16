namespace MiniBlockChain
{
    public class Transaction
    {
        public string User { get; set; }
        public string Value { get; set; }

        public Transaction(string user, string val){
            this.User = user;
            this.Value = val;
        }

        public override string ToString(){
            return $"{User}:{Value}";
        }
    }
}