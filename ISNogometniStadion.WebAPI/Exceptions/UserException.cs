using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Exceptions
{
    public class UserException:Exception
    {
        public UserException(string msg):base(msg)
        {

        }
    }
}
