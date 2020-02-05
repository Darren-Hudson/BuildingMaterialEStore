using System;
namespace BmesRestApi.Models.Shared
{
    public class BaseObject
    {
        public string Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
