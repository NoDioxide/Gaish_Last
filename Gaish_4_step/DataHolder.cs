using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaish_4_step
{
    internal class DataHolder
    {
        public static event EventHandler PaymentButtonClicked;

        public static void OnPaymentButtonClicked()
        {
            PaymentButtonClicked?.Invoke(null, EventArgs.Empty);
        }
    }
}
