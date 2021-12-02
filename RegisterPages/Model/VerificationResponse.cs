using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterPages.Model
{
    interface VerificationResponse
    {
         void OnWaVerificationSucceed(object source, EventArgs e);
         void OnEmailVerificationSucceed(object source, EventArgs e);
    }
}