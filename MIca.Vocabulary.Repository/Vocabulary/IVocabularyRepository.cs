using Mica.Vocabulary.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mica.Vocabulary.Repository.Vocabulary
{
    public interface IVocabularyRepository
    {
        IEnumerable<Word> GetList();
        Word Get(int id);
        void Create(Word word);
        void Update(Word word);
        void Delete(int id);
    }
}
