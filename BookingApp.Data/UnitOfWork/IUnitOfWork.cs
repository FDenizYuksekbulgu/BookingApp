namespace BookingApp.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(); // Kaç kayda etki ettiğini geriye döner, o yüzden int.
        Task BeginTransaction(); // Task asenkron metotların void''i gibi düşünülebilir.
        Task CommitTransaction();
        Task RollbackTransaction();

    }
}