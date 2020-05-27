namespace CRM.Bl.Model
{
    public class Sell
    {
        public int SellId { get; set; }
        public int ProductId { get; set; }
        public int ReceiptId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Receipt Receipt { get; set; }

    }
}
