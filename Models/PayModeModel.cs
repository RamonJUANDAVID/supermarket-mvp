﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName]
       public int Id { get; set; }
     public string Name { get; set; }
     public string Observation { get; set; }
    
    }
}
