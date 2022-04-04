using System.Linq;
using MyResume.Domain.Entities;

namespace MyResume.Domain.Repositories.Abstract
{
    public interface ITextFieldRepository
    {
        //сделать выборку всех текстовых полей
        IQueryable<TextField> GetTextFields(); 

        // выбрать текстовое поле по идентификатору
        TextField GetTextFieldById(System.Guid id);

        // выбрать текстовое поле по кодовому слову
        TextField GetTextFieldByCodeWord(string codeWord);

        //сохранить изменения в бд
        void SaveTextField(TextField entity);

        //удалить
        void DeleteTextField(System.Guid id);
    }
}
