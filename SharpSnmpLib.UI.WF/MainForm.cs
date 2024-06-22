using Lextm.SharpSnmpLib;
using SharpSnmpLib.UI.WF.Classes;
using static SharpSnmpLib.UI.WF.Classes.Communication;

namespace SharpSnmpLib.UI.WF
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            InitGui();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitGui() 
        {
            lblDescription.Text = "Description: ";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetOid_Click(object sender, EventArgs e)
        {
            var result = Communication.GetOid(this.txtIpAddress.Text, int.Parse(this.txtPort.Text), "1.3.6.1.2.1.1.1.0"); //SysDescr

            if (result[0] != null && result[0].Data != null)
            { 
                lblDescription.Text = $"Description: {result[0].Data.ToString()}";
            }
        }
    }
}
