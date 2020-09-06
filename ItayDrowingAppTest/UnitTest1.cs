using DAL;
using DAL.Converters;
using DAL.DALImlementations;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using EntityAndBoundary.Entity;
using ItayDrowingApp.Logic.Services;
using ItayDrowingApp.Logic.ServicesContracts;
using NUnit.Framework;
using System.Net.Http;

namespace ItayDrowingAppTest
{
    //public class Tests
    //{
    //    IDataAccessLayer dal;
    //    IUserService userService;
    //    IDocumentService documentService;
    //    UserEntity user;
    //    DocumentEntity document;
    //    DocumentEntity document1;
    //    IDocumentDAL documentDAL;
    //    [SetUp]
    //    public void Setup()
    //    {
            
    //        dal = new OracleDataAccessLayer("Data Source=localhost:1521/xe;User Id=Itay;Password=1234;");
    //        documentDAL = new DocumentDAL(dal);
    //        userService = new UserServiceImple(new UserConverter(), new UserDAL(dal));
    //        documentService = new DocumentServiceImple(new DocumentDAL(dal), new DocumentConverter());
    //        //user = userService.CreateUser(new NewUserBoundaey() { UserName = "name", Email = "email" });
    //        //document = 
    //    }

    //    [Test]
    //    public void Test1()
    //    {
    //        Assert.Pass();
    //    }
    //}
}