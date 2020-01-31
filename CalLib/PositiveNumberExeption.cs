using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLib
{
    /// <summary>
    /// Coustom Application Execption
    /// </summary>
    public class PositiveNumberExeption : ApplicationException
    {
        /// <summary>
        /// Constructor calls base class Constructor and passes coustom message in it.
        /// </summary>
        public PositiveNumberExeption() : base("Positve Number Observed"){}
        
    }
}
