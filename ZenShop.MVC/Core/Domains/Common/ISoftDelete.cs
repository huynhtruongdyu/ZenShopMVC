namespace ZenShop.MVC.Core.Domains.Common
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}