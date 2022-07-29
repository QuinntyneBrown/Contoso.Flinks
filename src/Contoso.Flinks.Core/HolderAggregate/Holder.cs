namespace Contoso.Flinks.Core
{
    public class Holder
    {
        public Guid HolderId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Session> Sessions { get; set; } = new();
    }
}
