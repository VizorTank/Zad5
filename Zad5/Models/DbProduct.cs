using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zad5.Models
{
    public class DbProduct : Product
    {
        public new int Id { get; set; }
    }
}
