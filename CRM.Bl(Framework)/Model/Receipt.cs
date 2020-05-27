using System;
using System.Collections;
using System.Collections.Generic;

namespace CRM.Model
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime  Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"№{ReceiptId} от {Created.ToString("dd.MM.yyyy hh:mm:ss")}";
        }

    }
}
