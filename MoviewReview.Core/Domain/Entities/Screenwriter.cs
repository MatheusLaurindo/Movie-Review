using MovieReview.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Core.Domain.Entities
{
    public class Screenwriter : Person
    {
        public Screenwriter(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            Titles = new();
        }
    }
}
