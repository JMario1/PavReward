using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PavRewards.Models;

namespace PavRewards.Data
{
    public class DashboardService
    {
        private static readonly Card card = new Card
        {
           Name = "John Doe",
           Number = "**** **** ** 3783",
           Expiry = "05/22"
        };

        private static readonly List<Transaction> transactions = new List<Transaction>
        {
            new Transaction {Name="Earned 10 Points at ABC Supermarket", Type=TransactionType.Credit, Amount=200, Date= new DateTime(2022, 09, 11, 14, 00, 58)},
            new Transaction {Name="Spent 100 points at Xyz Botique", Type=TransactionType.Debit, Amount=150, Date= new DateTime(2022, 08, 07, 15, 49, 58)},
            new Transaction {Name="Earned 20 points at GKD", Type=TransactionType.Credit, Amount=200, Date= new DateTime(2022, 09, 10, 8, 50, 58)},
            new Transaction {Name="Spent 50 points at Spar", Type=TransactionType.Debit, Amount=150, Date= new DateTime(2022, 09, 09, 15, 34, 58)},
            new Transaction {Name="Earned 10 Points at ABC Supermarket", Type=TransactionType.Credit, Amount=200, Date= new DateTime(2022, 09, 11, 14, 00, 58)},
            new Transaction {Name="Spent 100 points at Xyz Botique", Type=TransactionType.Debit, Amount=150, Date= new DateTime(2022, 08, 07, 15, 49, 58)},
            new Transaction {Name="Earned 20 points at GKD", Type=TransactionType.Credit, Amount=200, Date= new DateTime(2022, 09, 10, 8, 50, 58)},
            new Transaction {Name="Spent 50 points at Spar", Type=TransactionType.Debit, Amount=150, Date= new DateTime(2022, 09, 09, 15, 34, 58)},
        };

        private static readonly List<int> series = new List<int>
        { 100, 400, 300, 450, 800, 1200, 300, 250, 200,100, 150, 700, 450, 500, 640, 280, 270, 450, 800, 1200, 450, 500, 640, 280, 270, 450, 300, 250, 200,100
        };

        public Task<Dashboard> GetDashboardAsync()
        {
            return Task.FromResult(new Dashboard
            {
                Balance = 2500,
                Card = card,
                Recent = transactions.Take(10).ToList(),
                EarnedPoints = new ChartInfo
                {
                    Type=SeriesType.Earning, 
                    PointChange=900,
                    Series = series
                },
                SpendPoints = new ChartInfo
                {
                    Type=SeriesType.Spending, 
                    PointChange=300,
                    Series = series
                },
                
            });
        }

        public Task<Dictionary<string, Tuple<int, int>>> GetMonthlyPointsAsync(int year)
        {
            if (year == 2022)
            {
                return Task.FromResult(new Dictionary<string, Tuple<int, int>>
                {
                {"Jan", new Tuple<int, int>(450, 150)},
                {"Feb", new Tuple<int, int>(750, 350)},
                {"Mar", new Tuple<int, int>(400, 650)},
                {"Apr", new Tuple<int, int>(750, 350)},
                {"May", new Tuple<int, int>(450, 150)},
                {"Jun", new Tuple<int, int>(750, 300)},
                {"Jul", new Tuple<int, int>(350, 250)},
                {"Aug", new Tuple<int, int>(450, 150)},
                {"Sep", new Tuple<int, int>(750, 350)},
                {"Oct", new Tuple<int, int>(450, 180)},
                {"Nov", new Tuple<int, int>(950, 350)},
                {"Dec", new Tuple<int, int>(500, 150)},
                });
            }
            return Task.FromResult(new Dictionary<string, Tuple<int, int>>
            {
               {"Jan", new Tuple<int, int>(250, 150)},
               {"Feb", new Tuple<int, int>(250, 150)}
            });
        }
    }
}