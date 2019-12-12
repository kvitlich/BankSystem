using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_C
{
    public static class DataFiller
    {

        public static void FillData()
        {
            Account account = new Account
            {
                FullName = "Tahibaev Dias Asetovich",
                IIN = "030914525252",
                PhoneNumber = "87474579887",
                Score = "200",
                ScoreDate = "32/3",
                ScoreName = "Kvitclih",
                ScoreNumber = "3435343243243421",
            };
            using (var context = new BankSystemDbContext()) 
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }
    }

    
}
