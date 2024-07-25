﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Worker.Entities.Enums;

namespace Exercicio_Worker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary {  get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract) 
        {
                Contracts.Remove(contract); 
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)//percorrer a lista
            {
                if(contract.Data.Year == year && contract.Data.Month == month)
                {
                    sum = sum + contract.TotalValue();
                }
            }
            return sum;
        }
        
    }
}