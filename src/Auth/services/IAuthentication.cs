
namespace Auth
{
    public interface IAuthentication
    {
		Task<AuthenticationModel> RegisterAsync(RegisterationModel model);
		Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
		Task<AuthenticationModel> UnregisterAsync(TokenRequestModel model);
		Task<string> SetRoleAsync(SetRoleModel model);
        Task<User> GetByEmail(string mail);
		IEnumerable<User> GetAll();
    }

}
