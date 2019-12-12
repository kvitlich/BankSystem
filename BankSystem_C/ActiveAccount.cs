using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace BankSystem_C
{
    public class ActiveAccount
    {
        public static Account currentAccount { get; private set; } = null;

        public bool EnterByIIN(string IIN)
        {
            int iin = 0;
            if (!(IIN.Length == 12 && Int32.TryParse(IIN, out iin)))
            {
                return false;
            }
            using (BankSystemDbContext context = new BankSystemDbContext())
            {
                currentAccount = context.Accounts.Where(x => x.IIN == iin.ToString()).FirstOrDefault();
                if (currentAccount == null)
                {
                    return false;
                }
            }
            return true;

        }

        public bool ExecuteTransaction(string IIN, string summ)
        {
            int iin = 0;
            int summTo = 0;
            if (currentAccount == null && IIN.Length != 12 && !Int32.TryParse(IIN, out iin) && !Int32.TryParse(summ, out summTo))
            {
                return false;
            }
            Account destinationAccount = null;
            using (BankSystemDbContext context = new BankSystemDbContext())
            {
                destinationAccount = context.Accounts.Where(x => x.IIN.Equals(iin.ToString())).FirstOrDefault();
                using (var transaction = context.Database.BeginTransaction())
                {
                    string generatedCode = new Random().Next(1000, 9999).ToString();
                    destinationAccount = context.Accounts.Where(x => x.Id.Equals(destinationAccount.Id)).FirstOrDefault();
                    if (Int32.Parse(context.Accounts.Where(x => x.Id.Equals(currentAccount.Id)).FirstOrDefault().Score) < summTo &&
                        destinationAccount == null)
                    {
                        transaction.Rollback();
                    }
                    TwilioClient.Init(
                        Environment.GetEnvironmentVariable("AC203945a5a6475a7f6800c371f929f84f"),
                        Environment.GetEnvironmentVariable("2c1e7d9fdb6cd6bf30c77703a84c7863")
                        );
                    MessageResource.Create(
                        to: new Twilio.Types.PhoneNumber(destinationAccount.ToString()),
                        from: new Twilio.Types.PhoneNumber("(626) 774-5837"),
                        body: generatedCode
                        );
                    transaction.Commit();
                }
            }

            return true;
        }


    }
}
