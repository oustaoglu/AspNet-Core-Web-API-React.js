﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Shared.DTOs
{
    public class CartUpdateDto
    {
        public int CartId { get; set; }
        public List<CartItemDto> CartItems { get; set; }
    }
}
