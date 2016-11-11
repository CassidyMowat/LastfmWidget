using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastFmWidget{

    public partial class UserNameWindow : Form{

        private string userName = "";
        private MainWindow mainWindow;

        public UserNameWindow(){
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
                
                mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else {
                Console.WriteLine("Username Empty");
            }

        }
    }
}
