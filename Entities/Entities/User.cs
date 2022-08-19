﻿using Core.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class User:IEntity
    {
        public  int UserId  { get; set; }
        public string UserName  { get; set; }
    }
}
