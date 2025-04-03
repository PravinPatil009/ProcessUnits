#region Using directives
using FTOptix.NetLogic;
#endregion

[CustomBehavior]
public class ProcessUnitBehavior : BaseNetBehavior
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined behavior is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined behavior is stopped
    }

#region Auto-generated code, do not edit!
    protected new ProcessUnit Node => (ProcessUnit)base.Node;
#endregion
}
