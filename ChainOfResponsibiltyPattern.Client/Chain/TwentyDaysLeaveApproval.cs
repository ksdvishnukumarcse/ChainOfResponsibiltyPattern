namespace ChainOfResponsibiltyPattern.Client.Chain
{
    public class TwentyDaysLeaveApproval : AbstractionHandler
    {
        public override object HandleRequest(object value, string name)
        {
            int? days = value as int?;
            if (days <= 20 && days > 10)
            {
                return $"For the Employee {name} leave Request, Project Manager can approve the leave Request";
            }
            else
            {
                return base.HandleRequest(value, name);
            }
        }
    }
}
