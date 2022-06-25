using System.Threading.Tasks;

namespace HadrielWonda.AspNetCore.Authentication.Basic.Tests
{
    internal class NegativeBasicCredentialVerifier : IBasicCredentialVerifier
    {
        public Task<bool> Authenticate(string username, string password) => Task.FromResult(false); 
    }
}
