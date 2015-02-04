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
using System.Diagnostics;


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
        private void Riot_Static_API_Request()
        {
            strAPI_Key = txtAPI_Key.Text;
            for(int Ndx = 1; Ndx <= 200; Ndx++)
            {
                try
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    while(true)
                    {
                        if(stopwatch.ElapsedMilliseconds >= 20)
                        {
                            break;
                        }
                    }

                    string url = "https://na.api.pvp.net/api/lol/static-data/na/v1.2/champion/" + Ndx.ToString() + "?locale=en_US&champData=stats&api_key=" + strAPI_Key;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream resStream = response.GetResponseStream();
                    StreamReader objreader = new StreamReader(resStream);
                    string sresponse = "";
                    while (sresponse != null)
                    {
                        sresponse = objreader.ReadLine();
                        if (sresponse != null)
                            txtOutput.AppendText(sresponse);
                    }
                    txtOutput.AppendText("\r\n" + "\r\n");
                }
                catch { }
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            Riot_Static_API_Request();
        }

        private void btnSumid_Click(object sender, EventArgs e)
        {
            Riot_Get_Sum_ID(txtUsr.Text);
        }
        
        private void Riot_Get_Sum_ID(string strUsrname)
        {
            char[] splChar = {':',',' };
            strAPI_Key = txtAPI_Key.Text;
            
            try
            {                
                string url = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" + strUsrname + "?api_key=" + strAPI_Key;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader objreader = new StreamReader(resStream);
                string sresponse = "";
                while (sresponse != null)
                {
                    sresponse = objreader.ReadLine();
                    string[] strFull = sresponse.Split(splChar);
                    string strSumid = strFull[2];
                    
                    if (sresponse != null)
                        txtOutput.AppendText(strSumid);
                }
                txtOutput.AppendText("\r\n");
                txtOutput.AppendText("\r\n");
            }
            catch { }

        }
    }
}
