using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibiltyPattern.Client.Chain
{
    public class MoreThanThirtyDaysLeaveApproval : AbstractionHandler
    {
        public override object HandleRequest(object value, string name)
        {
            int? days = value as int?;
            if (days > 30)
            {
                return $"For the Employee {name} leave Request, Project Dev Director only approve the leave Request";
            }
            else
            {
                return base.HandleRequest(value, name);
            }
        }
    }
}
