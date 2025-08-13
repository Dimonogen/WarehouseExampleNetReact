using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Controllers.Base;
using Warehouse.Contracts.Application;
using Warehouse.Domain.Models;

namespace Warehouse.Api.Controllers;

/// <summary>
/// ��������
/// </summary>
[ApiController]
[Route("[controller]")]
public class ShipmentController : BaseCrudController<ShipmentEntity>
{
    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="crudService"></param>
    public ShipmentController(ILogger<ShipmentController> logger, ICrudService<ShipmentEntity> crudService)
        : base(logger, crudService)
    {
    }
}
