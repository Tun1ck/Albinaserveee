using Albina.DataAccessCore.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAccessCore.Models
{
    [Table("VirtualExpense")]
    public class VirtualExpenseRto
    {
        [Key] public int Id { get; set; }
        public int? UserId { get; set; }
        public UserRto User { get; set; }
        public string WhereSpend { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public VirtualExpenseStatusRto Status { get; set; }

        public DateTimeOffset CreateDateTime { get; set; }
        public List<DateTimeOffset> ChangeDateTimes { get; set; }
    }
}
