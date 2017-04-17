namespace Olx.Services
{
	public class LoginService
	{
		public static User GetDefaultUser()
		{
			return new User()
				   {
					   UserName = "onlymyway@ukr.net",
					   Password = "Password1"
				   };
		}
	}

	public class User
	{
		public string UserName;
		public string Password;
	}
}