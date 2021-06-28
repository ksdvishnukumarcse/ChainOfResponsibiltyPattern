namespace ChainOfResponsibiltyPattern.Client.Chain
{
    public class TenDaysLeaveApproval : AbstractionHandler
    {
        public override object HandleRequest(object value, string name)
        {
            int? days = value as int?;
            if (days <= 10)
            {
                return $"For the Employee {name} leave Request, Project Tech Lead can approve the leave Request";
            }
            else
            {
                return base.HandleRequest(value, name);
            }
        }
    }
}
