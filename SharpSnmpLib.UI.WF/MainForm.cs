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
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            lblDescription.Text = "Description: ";
            lblCount.Text = "Count: ";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetOid_Click(object sender, EventArgs e)
        {
            var result = Communication.GetOid(this.txtIpAddress.Text, int.Parse(this.txtPort.Text), "public", "1.3.6.1.2.1.1.1.0"); //SysDescr

            if (result[0] != null && result[0].Data != null)
            {
                lblDescription.Text = $"Description: {result[0].Data.ToString()}";
            }
        }

        private void btnBulkWalk_Click(object sender, EventArgs e)
        {
            var result = Communication.BulkWalk(this.txtIpAddress.Text, int.Parse(this.txtPort.Text), "public", "1.3");
            lstBulkWalkResult.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lstBulkWalkResult.View = View.Details;
            lstBulkWalkResult.Columns.Add("OIDs");
            lstBulkWalkResult.Items.Clear();
            int count = 0;
            foreach (var item in result) 
            {
                lstBulkWalkResult.Items.Add(item.ToString());
                count++;
            }
            lstBulkWalkResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            lstBulkWalkResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lblCount.Text = count.ToString();
        }
    }
}
