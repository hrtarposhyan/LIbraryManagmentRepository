using LIbraryManagmentRepository.Data.Interfaces;
using LIbraryManagmentRepository.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIbraryManagmentRepository.Data.Repository
{
    public class CustomerRepository: Repository<Customer>,ICustomerRepository
    {
        public CustomerRepository(LibraryDbContext context) : base(context)
        {

        }
    }
}
