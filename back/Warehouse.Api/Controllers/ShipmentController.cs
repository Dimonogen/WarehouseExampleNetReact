using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Controllers.Base;
using Warehouse.Application.Services;
using Warehouse.Contracts.Api.Response;
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
    public ShipmentController(ILogger<ShipmentController> logger, ShipmentService crudService)
        : base(logger, crudService)
    {
    }

    /// <summary>
    /// �������� ��������� �� ��������� ��� �� ���������
    /// </summary>
    /// <param name="id"></param>
    /// <param name="newStateCode">approve ��� disApprove</param>
    /// <returns></returns>
    [HttpPut("ChangeState")]
    public async Task<ActionResult> ChangeState(long id, string newStateCode)
    {
        await (_crudService as ShipmentService)!.ChangeStateAsync(id, newStateCode);
        return Ok(new ResponseDtoEmpty());
    }
}
