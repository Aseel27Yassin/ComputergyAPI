using ComputergyAPI.Contexts;
using ComputergyAPI.DTOs.Authentications;
using ComputergyAPI.Entities;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class AuthenticationService : IAuthentication
    {
        private readonly ComputergyDbContext _computergyDbContext;  //dependancy injection

        public AuthenticationService(ComputergyDbContext computergyDbContext)
        {
            _computergyDbContext = computergyDbContext;
        }
        public async Task<bool> ResetPersonPassword(ResetPersonPasswordInputDTO input)
        {
            var user = _computergyDbContext.Persons.Where(u => u.Email == input.Email && u.OTP == input.OTP  
               && u.ExpirationOTP > DateTime.Now && u.IsLoggedIn == false).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            if(input.Password != input.ConfirmPassword)
            {
                return false;
            }

            user.Password = input.ConfirmPassword;
            user.OTP = null;
            user.ExpirationOTP = null;

          
            //send code via email

            _computergyDbContext.Update(user);
            _computergyDbContext.SaveChanges();

            return true;
        }
        

        public async Task<bool> SendOTP(string email)
        {
            var user = _computergyDbContext.Persons.Where(u => u.Email == email && u.IsLoggedIn == false ).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            Random otp = new Random();
            user.OTP = otp.Next(11111,99999).ToString();
            user.ExpirationOTP = DateTime.Now.AddMinutes(4);
            //send otp via email

            _computergyDbContext.Update(user);
            _computergyDbContext.SaveChanges();

            return true;
        }

        public async Task<string> SignIn(SignInInputDTO input)
        {
            var user = _computergyDbContext.Persons.Where(u => u.Email == input.Email && u.Password == input.Password && u.IsLoggedIn == false).SingleOrDefault();
            if(user == null)
            {
                return "User not foudnd";
            }
            Random random = new Random();
            var otp = random.Next(11111,99999);
            user.OTP = otp.ToString();
            user.ExpirationOTP = DateTime.Now.AddMinutes(10);
            //send code via email

            _computergyDbContext.Update(user);
            _computergyDbContext.SaveChanges();

            return "Check your email, OTP has been sent!";
        }


        public async Task<bool> SignOut(int userId)
        {
            var user = _computergyDbContext.Persons.Where(u => u.Id == userId && u.IsLoggedIn == true).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            user.LastLoginTime = DateTime.Now;
            user.IsLoggedIn = false;

            _computergyDbContext.Update(user);
            _computergyDbContext.SaveChanges();

            return true;
        }

        public async Task<string> SignUp(SignUpInputDTO input)
        {
           Person person = new Person();
            person.Email = input.Email;
            person.Password = input.Password;
            person.FirstName= input.FirstName;
            person.LastName= input.LastName;
            person.CreatedBy = "System";
            person.CreationDate=DateTime.Now;


            Random random = new Random();
            var otp = random.Next(11111, 99999);
            person.OTP = otp.ToString();
            person.ExpirationOTP = DateTime.Now.AddMinutes(10);

            _computergyDbContext.Persons.Add(person);
            _computergyDbContext.SaveChanges();

            //send otp code via email 

            return "Verifying your emaill using otp";
        }

        public async Task<string> Verification(VerificationInputDTO input)
        {
            //Applying 2 factor authentication 
            var user = _computergyDbContext.Persons.Where(u => u.Email == input.Email && u.OTP == input.OTPCode 
            && u.IsLoggedIn == false && u.ExpirationOTP > DateTime.Now).SingleOrDefault();
            if (user == null)
            {
                return "User not foudnd";
            }
           
            if(input.IsSignup)
            {
                user.IsVerified = true;
            }
            else
            {
                user.LastLoginTime = DateTime.Now;
                user.IsLoggedIn = true;
            }
            user.ExpirationOTP = null;
            user.OTP = null;

            _computergyDbContext.Update(user);
            _computergyDbContext.SaveChanges();

            return "Login success, Token!";
        }
    }
}
