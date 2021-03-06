﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Transactions
{
    public class AccountTransaction : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TransactionType { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
    }
}
