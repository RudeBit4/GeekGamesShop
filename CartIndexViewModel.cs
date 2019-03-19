using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeekGameStore.Domain.Entities;

namespace GeekGameStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}