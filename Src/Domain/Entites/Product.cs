using Domain.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites;

public class Product : BaseAuditableEntity, ICommands
    {
        public string Name { get; set;}


    public string Description { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
    public string Summery { get; set; }
}

