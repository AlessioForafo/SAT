#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.CommunicationDriver;
using FTOptix.Alarm;
using FTOptix.S7TiaProfinet;
using FTOptix.S7TCP;
using FTOptix.EventLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.DataLogger;
using FTOptix.ODBCStore;
using FTOptix.Report;
#endregion

public class CreaAllarmi : BaseNetLogic
{
    [ExportMethod]
    public void Method1()
    {
        // Insert code to be executed by the method
        for (int i = 0; i < 10; i++)
        {
            var mioAllarme = InformationModel.Make<DigitalAlarm>("All_SAT_" + i);
            Project.Current.Get("Alarms").Add(mioAllarme);
        }
    }
}
