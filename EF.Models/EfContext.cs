using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Models
{
    class EfContext:DbContext
    {
        public EfContext():base("EfContext")
        {

        }
    }
}
