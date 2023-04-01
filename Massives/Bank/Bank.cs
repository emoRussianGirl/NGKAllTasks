using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    //Банк.
    public class Bank
    {
        public decimal Money { get; set; }

        public Report[,] Reports { get; set; }

        //Конструктор по умолчанию, для содания пустого банка.
        public Bank()
        {
            Money = 0;
            Reports = new Report[0, 0];
        }

        //Конструктор для инициализации банка деньгами и отчетами
        public Bank(decimal money, Report[,] reports)
        {
            Money = money;
            Reports = reports;
        }

        //Индексатор, отдающий очтеты по их порядковому номеру и id
        public Report this[int index, int id]
        {
            get
            {
                return Reports[index, id];
            }

            set
            {
                Reports[index, id] = value;
            }
        }

        //Янвное приведение к типу decimal, получение денег банка.
        public static explicit operator decimal(Bank bank)
        {
            return bank.Money;
        }


    }
    
    //Отчет
    public class Report
    {
        public int Id { get; set; }

        //Поле инт
        public int Money { get; set; }

        public Report(int id, int money)
        {
            Id = id;
            Money = money;
        }
    }
}
