using Lextm.SharpSnmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Lextm.SharpSnmpLib.Messaging;
using Lextm.SharpSnmpLib;
using System.Net;
using SharpSnmpLib.UI.WF.Interfaces;
using System.Security.Cryptography;

namespace SharpSnmpLib.UI.WF.Classes
{
    /// <summary>
    /// 
    /// </summary>
    internal class Communication : ISnmp
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="oid"></param>
        /// <returns></returns>
        public static IList<Variable> GetOid(string ip, int port, string community, string oid)
        {
            var result = Messenger.Get(VersionCode.V1,
                           new IPEndPoint(IPAddress.Parse(ip), port),
                           new OctetString(community),
                           new List<Variable> { new Variable(new ObjectIdentifier(oid)) },
                           60000);
            return result ?? null;
        }

        public static IList<Variable> BulkWalk(string ip, int port, string community, string oid)
        {
            var result = new List<Variable>();
            Messenger.BulkWalk(VersionCode.V2,
                              new IPEndPoint(IPAddress.Parse(ip), port),
                              new OctetString(community),
                              null,
                              new ObjectIdentifier(oid),
                              result,
                              60000,
                              10,
                              WalkMode.Default,
                              null,
                              null);
            return result;
        }
    }
}
