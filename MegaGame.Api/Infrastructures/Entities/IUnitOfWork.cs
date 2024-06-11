using Microsoft.EntityFrameworkCore.Storage;

namespace MegaGame.Api.Infrastructures.Entities
{
    public interface IUnitOfWork
    {
        IDbContextTransaction Begin();

        void Complete();

        void Rollback();
    }
}
