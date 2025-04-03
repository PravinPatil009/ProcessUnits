#region Using directives
using FTOptix.NetLogic;
using FTOptix.MQTTClient;
#endregion

[CustomBehavior]
public class ISA95JobResponseReceiverBehavior : BaseNetBehavior
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
    protected new ISA95JobResponseReceiver Node => (ISA95JobResponseReceiver)base.Node;
#endregion
}
