using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Client
    {
        partial void Birthday_Validate(EntityValidationResultsBuilder results)
        {
            if (Birthday > DateTime.Now.AddYears(-18) || Birthday < DateTime.Now.AddYears(-100))
                results.AddPropertyError("Клиент должен быть совершеннолетним и моложе 100 лет");
        }
    }
}
