using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Net;
using System.IO;


namespace LeagueOfLearning
{
    public partial class frmLOL : Form
    {
        public frmLOL()
        {
            InitializeComponent();
        }
        string strAPI_Key = "";

        private void frmLOL_Load(object sender, EventArgs e)
        {

        }
        private void Riot_API_Request()
        {
            strAPI_Key = txtAPI_Key.Text;
            string url = "https://na.api.pvp.net/api/lol/static-data/na/v1.2/champion/238?locale=en_US&champData=stats&api_key=" + strAPI_Key;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
        }
    }
}
