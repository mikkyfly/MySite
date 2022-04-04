using System.Linq;
using MyResume.Domain.Entities;

namespace MyResume.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository //все тоже самое для наших услуг
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(System.Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(System.Guid id);
    }
}
