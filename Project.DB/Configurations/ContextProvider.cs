namespace Project.DB.Configurations
{
    public class ContextProvider : IContextProvider
    {
        public IProjectDbContext Context
        {
            get { return new ProjectDbContext(); }
        }
    }
}
