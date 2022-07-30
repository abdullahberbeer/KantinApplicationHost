using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KantinAPI.DTO.Order
{
    public class AddOrderItemDto
    {
        public int PersonId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
