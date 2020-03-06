using LIbraryManagmentRepository.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIbraryManagmentRepository.Data.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllWithAuthor();
        IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate);
        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
