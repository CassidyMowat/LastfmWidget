using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastFmWidget{

    public partial class MainWindow : Form{

        private string apiKey = "773fbc4130ba98c24aff91aceca3d25b";
        private string userName = "";

        public MainWindow(){
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){

        }


        private void label1_Click(object sender, EventArgs e){

        }

        private void btnContinue_Click(object sender, EventArgs e){

            if(tbUserName.Text.Length > 0){
                userName = tbUserName.Text;
                Console.WriteLine(userName);

                getRecentTracks();
            }
            else {
                Console.WriteLine("Username Empty");
            }

        }


        private void getRecentTracks() {

            String url = "http://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&limit=5&user=" + userName + "&api_key=" + apiKey + "&format=json";

            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                //Stream resStream = response.GetResponseStream();
                
                using (Stream stream = response.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();
                    Console.WriteLine(responseString);
                }

            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }

    }
}
