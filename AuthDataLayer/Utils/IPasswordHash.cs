namespace AuthDataLayer.Utils
{
    public interface IPasswordHash
    {
        string GetHash(string password);
    }
}