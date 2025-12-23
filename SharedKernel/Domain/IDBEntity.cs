namespace SharedKernel.Domain
{
    public interface IDBEntity;
    public interface IDBEntity<TId>: IDBEntity
    {
        TId Id { get; set; }
    }
}
