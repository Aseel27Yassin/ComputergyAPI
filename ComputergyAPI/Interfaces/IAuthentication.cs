using ComputergyAPI.DTOs.Authentications;

namespace ComputergyAPI.Interfaces
{
    public interface IAuthentication
    {
        //define signature for the targeted method 
        Task<string> SignUp(SignUpInputDTO input);

        Task<string> SignIn(SignInInputDTO input);

        Task<string> Verification(VerificationInputDTO input);

        Task<bool> SendOTP(string email);

        Task<bool> ResetPersonPassword(ResetPersonPasswordInputDTO input);

        Task<bool> SignOut(int userId);
    }
}
 