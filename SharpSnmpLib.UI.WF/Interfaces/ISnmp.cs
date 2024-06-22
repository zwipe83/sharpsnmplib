using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SharpSnmpLib.UI.WF.Interfaces
{
    internal interface ISnmp
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="oid"></param>
        /// <returns></returns>
        public static abstract IList<Variable> GetOid(string ip, int port, string community, string oid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="version"></param>
        /// <param name="endpoint"></param>
        /// <param name="community"></param>
        /// <param name="table"></param>
        /// <param name="list"></param>
        /// <param name="timeout"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static abstract IList<Variable> BulkWalk(string ip, int port, string community, string oid);
    }
}
