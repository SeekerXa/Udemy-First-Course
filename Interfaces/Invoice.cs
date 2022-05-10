using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Invoice : IPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }

        private int quantity;
        private decimal pricePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;

        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
              if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),value,$"{nameof(value)} must be >=0");
                }
              quantity = value;
            }
        }

        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be >=0");
                }
                pricePerItem = value;
            }
        }

        public override string ToString()
        {
            return $"Invoice:\n part number: {PartNumber} ({PartDescription})\n" +
                $"quantity: {Quantity}\nprice per item: {PricePerItem:C}";
        }

        public decimal GetPaymentAmount()
        {
            return Quantity * pricePerItem;
        }

    }
}
