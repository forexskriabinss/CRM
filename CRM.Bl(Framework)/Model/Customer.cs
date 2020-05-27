namespace CRM.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
