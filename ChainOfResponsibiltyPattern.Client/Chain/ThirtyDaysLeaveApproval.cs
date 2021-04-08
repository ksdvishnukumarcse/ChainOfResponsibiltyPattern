using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltyPattern.Client.Chain
{
    public class ThirtyDaysLeaveApproval : AbstractionHandler
    {
        public override object HandleRequest(object value, string name)
        {
            int? days = value as int?;
            if (days <= 30 && days > 20)
            {
                return $"For the Employee {name} leave Request, Account manager can approve the leave Request";
            }
            else
            {
                return base.HandleRequest(value, name);
            }
        }
    }
}
