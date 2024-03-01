using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlDataBase;
using SqlDataBase.Types;

namespace TestRequestSystem;

[TestClass]
public class Users
{
    [TestMethod]
    public void AddUser()
    {
        User user = new()
        {
            UserLogin = "test",
            UserFullName = "test",
            UserPassword = "test",
            UserType = "Admin"
        };

        DataBase.Users.Insert(user);

        User user1 = DataBase.Users.Find("test");

        Assert.IsNotNull(user1);
    }

    [TestMethod]
    public void UpdateUser()
    {
        User user = DataBase.Users.Find("test");

        user.UserFullName = "Второе тестовое имя";
        DataBase.Users.Save();

        User user1 = DataBase.Users.Find("test");

        Assert.IsNotNull(user1);
        Assert.AreEqual("Второе тестовое имя", user1.UserFullName);
    }

    [TestMethod]
    public void DeleteUser()
    {
        User user = DataBase.Users.Find("test");

        DataBase.Users.Delete(user);

        User user1 = DataBase.Users.Find("test");

        Assert.IsNull(user1);
    }
}
