using Financials;
using System;
using System.Collections;
using System.Text;

namespace EnhancedInvoice
{
    class EnhancedInvoice : Invoice
    {
        //TODO
        public EnhancedInvoice(DateTime date, uint number, string currency, string recipient)
        {
            Date = date;
            Number = number;
            Currency = currency;
            Recipient = recipient;
        }

        public double TotalSum
        {
            get
            {
                double output = 0;
                foreach (EnhancedInvoiceItem e in Items)
                {
                    output += e.SumPrice;
                }
                return output;
            }
        }

        public override string ToString()
        {
            return Date + " " + Number + " " + Currency + " " + Recipient;
        }

       public EnhancedInvoiceItem this[int index]
        {

            // The get accessor.
            get
            {
                return (EnhancedInvoiceItem)items[index];
            }

        }


}

    class EnhancedInvoiceItem : InvoiceItem
    {
        //TODO
        public EnhancedInvoiceItem (uint stocknumber, uint quantity, string description, double unitPrice)
        {
            Stocknumber = stocknumber;
            Quantity = quantity;
            Description = description;
            UnitPrice = unitPrice;
        }
    }
}
