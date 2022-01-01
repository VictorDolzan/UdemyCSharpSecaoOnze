using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoOnze.ExcecoesPersonalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string externalMessage) : base(externalMessage)
        {
            
        }
    }
}