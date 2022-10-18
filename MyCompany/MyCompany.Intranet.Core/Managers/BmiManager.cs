
using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Managers.Interfaces;
using MyCompany.Intranet.Core.Services.Interfaces;

namespace MyCompany.Intranet.Core.Managers;

public class BmiManager : IBmiManager
{
    private readonly IBmiService _service;

    public BmiManager(IBmiService service)
    {
        _service = service;
    }

    public Bmi GetBmi(Person person)
    {
        return _service.ProcessBmi(person);
    }
}



