﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Models.Entity
{
    public class BaseEntity
    {
        [Key]
        public long id { get; set; }
    }
}
