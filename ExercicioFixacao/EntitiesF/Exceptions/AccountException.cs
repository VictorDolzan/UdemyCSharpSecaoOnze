using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoOnze.ExercicioFixacao.EntitiesF.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string externalMessage) : base(externalMessage)
        {
            
        }
    }
}