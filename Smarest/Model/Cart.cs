﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smarest.Model
{
    public class Cart
    {
        public string Id {get;set;}

        [ForeignKey("Item")]
        public string ItemId { get; set; }
        public Item Items { get; set; }


        public int ItemQuantity {get;set;}

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }


        [ForeignKey("Table")]
        public string TableId { get; set; }
        public Table Table { get; set; }

    }
}
