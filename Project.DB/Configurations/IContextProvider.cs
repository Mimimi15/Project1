
namespace Project.DB.Configurations
{
    public interface IContextProvider
    {
        IProjectDbContext Context { get; }
    }
}
