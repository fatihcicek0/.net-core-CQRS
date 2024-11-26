using CQRS_.net_core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Domain.Entities
{
    public class Brand:EntityBase
    {
        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
