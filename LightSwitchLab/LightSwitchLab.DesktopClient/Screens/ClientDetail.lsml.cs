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
    public partial class ClientDetail
    {
        partial void Client_Loaded(bool succeeded)
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.Client);
        }

        partial void Client_Changed()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.Client);
        }

        partial void ClientDetail_Saved()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.Client);
        }
    }
}