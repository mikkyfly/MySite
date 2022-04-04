using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyResume.Domain.Repositories.Abstract;

namespace MyResume.Domain
{
    public class DataManager
    {
        public ITextFieldRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldRepository textFieldRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
