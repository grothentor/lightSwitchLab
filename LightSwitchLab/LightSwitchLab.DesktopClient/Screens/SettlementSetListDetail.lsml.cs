using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class SettlementSetListDetail
    {
        partial void WordExport_Execute()
        {
            // Добавьте сюда свой код.
            OfficeIntegration.Word.Export(@"C:\Users\Alexandr\Documents\Settlement.docx", "Settlements", 1, true, 
                SettlementSet);

        }
    }
}
