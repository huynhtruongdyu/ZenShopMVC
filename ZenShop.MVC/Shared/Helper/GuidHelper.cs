namespace ZenShop.MVC.Shared.Helper
{
    public static class GuidHelper
    {
        public static Guid NewSeqGuid()
        {
            var sgvg = new Microsoft.EntityFrameworkCore.ValueGeneration.SequentialGuidValueGenerator();
            return sgvg.Next(null);
        }
    }
}