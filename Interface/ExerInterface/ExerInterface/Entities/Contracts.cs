﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExerInterface.Entities
{
    internal class Contracts
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<Installment> Installments { get; set; }

        public Contracts(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            Value = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}