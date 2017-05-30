using Database.EF.DTO;
using System.Linq;

namespace Database.EF.DAO
{
    public class UserDAO
    {
        ShopDbContext db = null;
        public UserDAO()
        {
            db = new ShopDbContext();
        }

        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserDAO();
                return UserDAO.instance;
            }
            private set
            {
                UserDAO.Instance = null;
            }
        }
        public int Login (string username, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.Username == username);
            if (result == null)
            {
                return 0; // Tài khoản không toàn tại
            }
            else
            {
                if (result.Password == password)
                {
                    return 1; //Đăng nhập thành công
                }
                else
                {
                    return -1; //Sai mật khẩu
                }
            }
        }

        public int CheckUsername(string username)
        {
            var result = db.Users.SingleOrDefault(x => x.Username == username);
            if (result == null)
            {
                return 1;
            }
            else
                return 0;
        }

        public long Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
    }
}
