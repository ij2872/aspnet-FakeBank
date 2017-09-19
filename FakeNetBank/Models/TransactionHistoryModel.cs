using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FakeNetBank.Models
{
    public class TransactionHistoryModel
    {
        public decimal Balance { get; set; }

        public DateTime createdOn { get; set; }
    }
}