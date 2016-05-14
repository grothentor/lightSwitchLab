using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Settlement
    {
        partial void Joined_Validate(EntityValidationResultsBuilder results)
        {
            if (Joined > Eviction.AddHours(12))
                results.AddPropertyError("<Дата весления должна быть позже даты заселения, и должен оплатить минимум 12 часов>");
        }
    }
}
