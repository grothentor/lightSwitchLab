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
    public partial class EditableSettlementSetGrid
    {
        partial void Export_Execute()
        {
            List<String> names = new List<string>();
            names.Add("Name");
            names.Add("S_Name");
            names.Add("Phone");

            List<String> names2 = new List<string>();
            names2.Add("NofBeds");
            names2.Add("Cost");
            names2.Add("RoomType");

            IdClient = SettlementSet.SelectedItem.IdClient.Id;
            RoomId = SettlementSet.SelectedItem.IdRoom.Id;

            //OfficeIntegration.Excel.Export(ClientSet,
            //   @"C:\Users\Alexandr\Documents\settlements.xlsx", "Sheet1", "B6", names);
            //// сохранение и закрытие книги dynamic xl;
            //OfficeIntegration.Excel.Export(RoomSet,
            //   @"C:\Users\Alexandr\Documents\settlements.xlsx", "Sheet1", "E6", names2);

            OfficeIntegration.Excel.Export(SettlementSet,
               @"C:\Users\Alexandr\Documents\settlements.xlsx", "Sheet1", "B2");

        }
    }
}
