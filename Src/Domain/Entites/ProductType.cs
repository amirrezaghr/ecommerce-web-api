using Domain.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class ProductType : BaseAuditableEntity,ICommands
    {
        public string Title { get; set; }



        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string Summery { get; set; }
    }
}
