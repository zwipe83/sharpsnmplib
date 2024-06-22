using Lextm.SharpSnmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static abstract IList<Variable> GetOid(string ip, int port, string oid);
    }
}
