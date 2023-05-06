using Sim23.Data.Entities.Identity;

namespace Sim23.Abstract
{
    public interface IJwtTokenService
    {
        Task<string> CreateToken(UserEntity user);
    }
}
