using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BuisnessLogic.Core.Models
{
    public class UserIndentityBlo
    {
        public int Id { get; set; }
        public int NumberPrefix { get; set; }
        public int Number { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }

    }
}
