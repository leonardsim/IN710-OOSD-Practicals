using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworking
{
    public partial class Form1 : Form
    {
        //Declare Subject and Observers
        SocialSubject subject;
        SocialObserver main;
        FriendObserver fO1;
        FriendObserver fO2;
        FriendObserver fO3;
        FriendObserver fO4;

        public Form1()
        {
            InitializeComponent();

            //Initialise attributes
            subject = new SocialSubject();

            main = new SocialObserver(lbMain, subject);
            fO1 = new FriendObserver(lbFriend1, subject);
            fO2 = new FriendObserver(lbFriend2, subject);
            fO3 = new FriendObserver(lbFriend3, subject);
            fO4 = new FriendObserver(lbFriend4, subject);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            subject.UserStatus = tbStatus.Text.ToString();

            subject.NotifyObservers();
        }
    }
}
