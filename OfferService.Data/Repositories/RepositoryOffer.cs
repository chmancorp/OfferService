using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OfferService.Data.Entities;

namespace OfferService.Data.Repositories
{
    public class RepositoryOffer : IRepositoryOffer
    {
        private readonly OfferDataBaseContext _dbContext;
        public async Task SaveOffer(OfferDb offerData)
        {
            await _dbContext.AddAsync(offerData);
        }
    }
}
