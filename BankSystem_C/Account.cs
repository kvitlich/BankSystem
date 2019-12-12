using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_C
{
    public class Account
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string IIN { get; set; }
        public string ScoreName { get; set; }
        public string ScoreNumber { get; set; }
        public string ScoreDate { get; set; }
        public string Score { get; set; }
    }
}
