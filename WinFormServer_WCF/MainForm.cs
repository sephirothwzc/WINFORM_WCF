using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*************************************************************************************
  * CLR 版本：       4.0.30319.33440
  * 类 名 称：       MainForm
  * 机器名称：       SEPHIROTHBF0C
  * 命名空间：       WinFormServer_WCF
  * 文 件 名：       MainForm
  * 创建时间：       15/8/13 10:05:45
  * 作    者：       吴占超
  * 说    明：
  * 修改时间：
  * 修 改 人：
 *************************************************************************************/

namespace WinFormServer_WCF
{
    public partial class MainForm : Form
    {
        System.ServiceModel.ServiceHost m_Host;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                WCFService broadcastSvc = new WCFService();
                m_Host = new System.ServiceModel.ServiceHost(broadcastSvc);
                m_Host.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Host.Close();
        }
    }
}
