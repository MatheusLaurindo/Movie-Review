﻿using MoviewReview.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Domain.Entities
{
    public class Actor : Person
    {
        public List<Cast> Casts { get; set; }
    }
}
