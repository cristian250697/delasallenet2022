using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Services.Interfaces;

namespace MyCompany.Intranet.Core.Services;

public class ApiBmiService:IBmiService
{
    public Bmi ProcessBmi(Person person)
    {
        var bmi = new Bmi();
        
        bmi.Index = 18.5f;
        bmi.BmiType = BmiType.Low;
        return bmi; 

    }

}
