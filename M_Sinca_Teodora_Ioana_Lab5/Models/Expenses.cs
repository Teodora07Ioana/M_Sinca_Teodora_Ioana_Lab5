﻿using System.ComponentModel.DataAnnotations;

namespace M_Sinca_Teodora_Ioana_Lab5.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }

    }
}
