#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.OPCUAServer;
using FTOptix.RAEtherNetIP;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.NetLogic;
using FTOptix.Core;
using LogsHandler;
using System.Collections.Generic;
#endregion

public class IIOTDesignTimeConfigurer : BaseNetLogic
{
    /// <summary>
    /// This method will be invoked from the FT Optix Studio manually which performs
    /// Building the IIOT information model based on the OPC UA ISA 95 Job Control V2 Model using excel template
    /// </summary>
    [ExportMethod]
    public void Setup_IIOT_Model()
    {
        IIOTModelBuilder model = new IIOTModelBuilder();
        model.Setup();
    }
}

