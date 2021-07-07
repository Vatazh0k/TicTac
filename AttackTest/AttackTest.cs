using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTac.DAL.GameStorage;
using TicTac.WebApi.Clients.GameProces;

namespace AttackTest
{
    [TestClass]
    public class AttackTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Attack();
            var b = Collection.Get();
            b.Games.Add(1, new TicTac.Domain.Model.Game());
            a.PutSign(1.ToString(),2.ToString(),3.ToString());
        }
    }
}
