﻿using LIbraryManagmentRepository.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIbraryManagmentRepository.Data.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllWithBooks();
        Author GetWithBooks(int id);
    }
}
