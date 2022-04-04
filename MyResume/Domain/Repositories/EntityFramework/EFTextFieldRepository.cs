using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Entities;
using MyResume.Domain.Repositories.Abstract;
using System.Linq;

namespace MyResume.Domain.Repositories.EntityFramework
{
    public class EFTextFieldRepository : ITextFieldRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldRepository(AppDbContext _context)
        {
            context = _context;
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }

        public TextField GetTextFieldById(System.Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id==default)
            {
                context.Entry(entity).State = EntityState.Added; // new object
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified; 
            }
            context.SaveChanges();
        }

        public void DeleteTextField(System.Guid id)
        {
            context.TextFields.Remove(new TextField() { Id= id });
            context.SaveChanges();
        }

    }
}
