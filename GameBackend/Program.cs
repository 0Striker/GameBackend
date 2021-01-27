using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            
            Admin admin1 = new Admin() {Name = "Asım Baki",Authority = "Kurucu",DateOfJoin = "23.10.2003", TcNo ="xxx4567890" };
            Admin admin2 = new Admin() { Name = "Berke", Authority = "Admin", DateOfJoin = "20.01.2002", TcNo = "xxxxxx7890" };

            userManager.AddAdmin(admin1);
            userManager.DeleteAdmin(admin2);

            DefaultUser user1 = new DefaultUser() { Name = "Serhat", Authority = "Üye", DateOfBirth = "21.12.2004", Id = 1, TcNo = "12xxxxxxxx" };
            DefaultUser user2 = new DefaultUser() { Name = "Selen", Authority = "Üye", DateOfBirth = "21.12.2000", Id = 1, TcNo = "1xxxxxxxxx" };
            DefaultUser user3 = new DefaultUser() { Name = "Kerem", Authority = "Üye", DateOfBirth = "11.02.2001", Id = 1, TcNo = "1xxxxxyzxxx" };
            DefaultUser user4 = new DefaultUser() { Name = "Engin", Authority = "Üye", DateOfBirth = "??.??.1985", Id = 1, TcNo = "1zxxxxyzxxx" };

            userManager.AddDefaultUser(user1);
            userManager.DeleteDefaultUser(user2);
            userManager.UpdateDefaultUser(user3);
            userManager.MakeAdmin(user4);

            SellingManager sellingManager = new SellingManager();

            sellingManager.Sell(user1);
            sellingManager.CampaingSale(user2);



        }
    }
}
