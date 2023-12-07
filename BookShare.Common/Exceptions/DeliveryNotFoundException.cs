using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Exceptions
{
    public sealed class DeliveryNotFoundException : Exception
    {
        public DeliveryNotFoundException(string deliveryId)
            : base($"There is no delivery with id: {deliveryId} ")
        { 

        }
    }
}
