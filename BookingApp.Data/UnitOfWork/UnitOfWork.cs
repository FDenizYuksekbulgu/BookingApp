
using BookingApp.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookingApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookingAppDbContext _db;
        private IDbContextTransaction _transaction;

        public UnitOfWork(BookingAppDbContext db)
        {
            _db = db;
        }

        public async Task BeginTransaction()
        {
            _transaction = await _db.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction()
        {
            await _transaction.CommitAsync();
        }

        public void Dispose()
        {
            _db.Dispose(); // Garbage Collector'a sen bunu temizleyebilirsin izni verdiğimiz yer. O an silmiyoruz - silinebilir yapıyoruz.

            // GC.Collect();
            // GC.WaitForPendingFinalizers();
            // Bu kodlar Garbage Collector'ı direkt çalıştırır.
        }

        public async Task RollbackTransaction()
        {
            await _transaction.RollbackAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}