using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OfferService.Data.Entities;
using OfferService.Data.Repositories;

namespace OfferService.Data.UnitOfWork
{
    public class OfferUnit : IOfferUnit
    {
        private OfferDataBaseContext _dbcontext;

        public OfferUnit(OfferDataBaseContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IRepositoryOffer RepositoryOffer
        {
            get; private set;
        }

        public async Task Complete()
        {
            await _dbcontext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }
    }
}
