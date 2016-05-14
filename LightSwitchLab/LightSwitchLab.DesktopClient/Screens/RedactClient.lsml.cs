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
    public partial class RedactClient
    {
        partial void Exel_import_Execute()
        {
            // Добавьте сюда свой код.
            ExcelImporter.Importer.ImportFromExcel(this.ClientSet);

        }
    }
}
