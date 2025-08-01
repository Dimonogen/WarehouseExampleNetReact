using Microsoft.AspNetCore.Mvc;
using Warehouse.Contracts.Application;
using Warehouse.Domain.Models;

namespace Warehouse.Api.Controllers;

/// <summary>
/// ���������� ��� ��������
/// </summary>
[ApiController]
[Route("[controller]")]
public class ResourceController : BaseCrudController<ResourceEntity>
{
    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="crudService"></param>
    public ResourceController(ILogger<ResourceController> logger, ICrudService<ResourceEntity> crudService)
        : base(logger, crudService)
    {
    }
}
