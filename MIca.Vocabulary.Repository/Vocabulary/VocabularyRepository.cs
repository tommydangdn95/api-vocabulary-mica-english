using Mica.Vocabulary.Domain;
using Mica.Vocabulary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mica.Vocabulary.Repository.Vocabulary
{
    public class VocabularyRepository : IVocabularyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public VocabularyRepository(ApplicationDbContext dbcontext)
        {
            this._dbContext = dbcontext;
        }
        public void Create(Word word)
        {
            this._dbContext.Words.Add(word);
            this._dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Word Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Word> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Word word)
        {
            throw new NotImplementedException();
        }
    }
}
