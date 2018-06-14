using OfferService.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfferService.Data.UnitOfWork
{
    public interface IOfferUnit: IUnitOfWork
    {
        IRepositoryOffer RepositoryOffer { get; }
    }
}
