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
    public partial class Application
    {
        partial void ClientDetail_CanRun(ref bool result, int ClientId)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess)
                || User.HasPermission(Permissions.GuestAccess);
        }

        partial void EditableQuery1Grid_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }

        partial void EditableQuery2Grid_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }

        partial void EditableSettlementSetGrid_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }

        partial void RedactClient_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }

        partial void RedactRoom_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess);

        }

        partial void RedactRoomType_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess);

        }

        partial void RedactSettlement_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }

        partial void RedactSex_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess);

        }

        partial void SearchClientSet_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess)
                || User.HasPermission(Permissions.GuestAccess);

        }

        partial void SearchRoomSet_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess)
                || User.HasPermission(Permissions.GuestAccess);

        }

        partial void SearchSettlementSet_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }

        partial void SettlementSetListDetail_CanRun(ref bool result)
        {
            // Присвоение результату значения нужного поля
            result = User.HasPermission(Permissions.AllAccess)
                || User.HasPermission(Permissions.EmployeeAccess);

        }
    }
}
