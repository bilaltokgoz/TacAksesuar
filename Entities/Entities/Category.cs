using Core.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Category:IEntity
    {
       
        public string CategoryName  { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
