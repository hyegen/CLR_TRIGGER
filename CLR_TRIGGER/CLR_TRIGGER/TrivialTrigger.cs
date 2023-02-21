using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

public partial class Triggers
{        
    // Enter existing table or view for the target and uncomment the attribute line
    // [Microsoft.SqlServer.Server.SqlTrigger (Name="TrivialTrigger", Target="Table1", Event="FOR UPDATE")]
    public static void TrivialTrigger ()
    {
        SqlTriggerContext TrContext = SqlContext.TriggerContext;

        switch (TrContext.TriggerAction)
        {
            case TriggerAction.Insert:
                SqlContext.Pipe.Send("Veri eklendi.");
                break;
            case TriggerAction.Update:
                SqlContext.Pipe.Send("You updated data.");
                break;
            case TriggerAction.Delete:
                SqlContext.Pipe.Send("You deleted data.");
                break;
        }
    }
}

