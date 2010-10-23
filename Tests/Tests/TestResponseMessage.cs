/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2008/5/1
 * Time: 20:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using Lextm.SharpSnmpLib.Security;
using NUnit.Framework;
using Lextm.SharpSnmpLib.Messaging;

#pragma warning disable 1591
namespace Lextm.SharpSnmpLib.Tests
{
    [TestFixture]
    public class TestResponseMessage
    {
        [Test]
        public void TestMethod()
        {
            ISnmpMessage message = MessageFactory.ParseMessages(Resources.getresponse, new UserRegistry())[0];
            Assert.AreEqual(SnmpType.ResponsePdu, message.Pdu.TypeCode);
            ISnmpPdu pdu = message.Pdu;
            Assert.AreEqual(SnmpType.ResponsePdu, pdu.TypeCode);
            ResponsePdu response = (ResponsePdu)pdu;
            Assert.AreEqual(new Integer32(0), response.ErrorStatus);
            Assert.AreEqual(0, response.ErrorIndex.ToInt32());
            Assert.AreEqual(1, response.Variables.Count);
            Variable v = response.Variables[0];
            Assert.AreEqual(new uint[] { 1, 3, 6, 1, 2, 1, 1, 6, 0 }, v.Id.ToNumerical());
            Assert.AreEqual("Shanghai", v.Data.ToString());
        }
    }
}
#pragma warning restore 1591
