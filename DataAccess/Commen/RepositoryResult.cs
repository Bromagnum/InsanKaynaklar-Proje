using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Commen
{
    public class RepositoryResult<T>
    {
        public bool Success { get; set; }

        public T Entity { get; set; }

        public string ErrorMessage { get; set; }

    }
}
