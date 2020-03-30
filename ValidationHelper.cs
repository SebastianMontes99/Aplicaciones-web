using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppUpc
{
    public class ValidationHelper
    {
        public static bool ProductPendingOrDisabled(Enums.Status status)
        {
            var statuslist = new List< Enums.Status > ();
            //validar el estado en que se encuentra el valor //
            statuslist.Add(Enums.Status.Disabled);
            statuslist.Add(Enums.Status.Pending);

            return statuslist.Contains(status);
        }
    }
}
