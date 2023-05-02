using ZenShop.MVC.Core.Domains.Common;
using ZenShop.MVC.Shared.Helper;

namespace ZenShop.MVC.Core.Domains.Entities
{
    public class Product : AuditEntity, ISoftDelete
    {
        public Product()
        {
        }

        public Product(string name)
        {
            Id = GuidHelper.NewSeqGuid();
            Name = name;
        }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}