using System.Security.Cryptography.X509Certificates;

namespace WebApplication1.Models
{
    public class Meccs
    {
        public int Id { get; set; }
        public int Fordulo { get; set; }
        public int hazaiGol { get; set; }
        public int vendegGol { get; set; }
        public int hazaiGolFelidoben { get; set; }
        public int vendegGolFelidoben { get; set; }
        public string hazaiCsapatnev { get; set; }
        public string vendegCsapatnev { get; set; }
    }
}
