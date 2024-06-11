namespace MegaGame.Api.Infrastructures.Entities
{
    public interface IHasCreationTime
    {
        DateTime CreatedAt { get; set; }
    }
}
