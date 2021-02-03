using LuBank.Domain.Interfaces;
using LuBank.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Infra.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LuBankDataContext _context;

        public UnitOfWork(LuBankDataContext context)
        {
            _context = context;
        }

        public bool Commit()
            => _context.SaveChanges() > 0;

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
