using OfferService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OfferService.Data.Repositories
{
    public interface IRepositoryOffer
    {
        Task SaveOffer(OfferDb offerData);
    }
}
