using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Core.Services.Interfaces;

public interface IBmiService
{
    Bmi ProcessBmi(Person person);
}

