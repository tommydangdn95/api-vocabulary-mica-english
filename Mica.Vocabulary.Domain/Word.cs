using Core.Models;
using System;

namespace Mica.Vocabulary.Domain
{
    public class Word : Term
    {
        public string Sysnonym { get; set; }
        public string Mean { get; set; }
    }
}
