using Api.Domain.Common;
using Api.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entitites
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }
        public Category(int parentId,string name,int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }

        public  int ParentId { get; set; }
        public  string Name { get; set; }
        public  int Priority { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

