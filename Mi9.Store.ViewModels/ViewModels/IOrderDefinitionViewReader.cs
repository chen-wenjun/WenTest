using System.Collections.Generic;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.ViewModels.ViewModels
{
    public interface IOrderDefinitionViewReader
    {
        IEnumerable<OrderTypeBaseViewModel> ReadAll();

        OrderTypeBaseViewModel ReadByOrderType(string orderType);

        OrderDefinitionEntity ReadByOrderTypeReturnEntity(string orderType);

        OrderTypeBaseViewModel ReadByOrderNumber(int orderNumber);
    }
}