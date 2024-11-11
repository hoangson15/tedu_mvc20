namespace My20MVCApp.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
