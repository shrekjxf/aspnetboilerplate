using Abp.Domain.Uow;
using Microsoft.AspNet.OData;

namespace Abp.AspNetCore.OData.Controllers
{
    public abstract class AbpODataController : ODataController
    {
        public IUnitOfWorkManager UnitOfWorkManager { get; set; }
    }
}
