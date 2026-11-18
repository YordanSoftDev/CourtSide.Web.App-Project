namespace CourtSide.Data.Seeding
{
    using System.Security.Cryptography;
    using System.Text;

    public class DeterministicGuid
    {
        public static Guid Create(string seed)
        {
            byte[] hash = MD5.HashData(Encoding.UTF8.GetBytes(seed));

            return new Guid(hash);
        }
    }
}
