using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Core.Managers.Interfaces;

public interface IBmiManager
{
    Bmi GetBmi(Person person);
}