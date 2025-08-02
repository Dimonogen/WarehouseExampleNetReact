using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Controllers.Base;
using Warehouse.Contracts.Application;
using Warehouse.Domain.Models;

namespace Warehouse.Api.Controllers;

/// <summary>
/// ���������� ��� ������ ���������
/// </summary>
[ApiController]
[Route("[controller]")]
public class UnitController : BaseArchiveCrudController<UnitEntity>
{
    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="crudService"></param>
    public UnitController(ILogger<UnitController> logger, IArchiveCrudService<UnitEntity> crudService)
        : base(logger, crudService)
    {
    }
}
