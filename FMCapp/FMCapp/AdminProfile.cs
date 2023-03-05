using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMCapp
{
    public partial class AdminProfile : UserControl
    {
        public AdminProfile()
        {
            InitializeComponent();
        }
        private string AnameSurname;
        private string AprofilePic;
        private int delNum;
        private int ediNum;
        private int addNum;
        private string adminDate;
        private string crCardNum;
        private string crCardDate;
        private string crCardCvc;
        public string setNameSurn
        {
            get { return AnameSurname; }
            set { AnameSurname = value; AnameSurnameLabel.Text = AnameSurname; }
        }
        public string setProfilePic
        {
            get { return AprofilePic; }
            set { AprofilePic = value; profilePictureBox.ImageLocation = AprofilePic; }
        }
        public int setdelnum
        {
            get { return delNum; }
            set { delNum = value; deletedNumLabel.Text = delNum.ToString(); }
        }
        public int setEdiNum
        {
            get { return ediNum; }
            set { ediNum = value; editedNumLabel.Text = ediNum.ToString(); }
        }
        public int setaddnum
        {
            get { return addNum; }
            set { addNum = value; addedNumLabel.Text = addNum.ToString(); }
        }
        public string setadminDate
        {
            get { return adminDate; }
            set { adminDate = value; adDateLabel.Text += adminDate; }
        }
        public string setcrCardNum
        {
            get { return crCardNum; }
            set { crCardNum = value; cardNumbrLabel.Text = crCardNum; }
        }
        public string setcrCardDate
        {
            get { return crCardDate; }
            set { crCardDate = value; cardDateLabel.Text = crCardDate; }
        }
        public string setcrCardCvc
        {
            get { return crCardCvc; }
            set { crCardCvc = value; CVC.Text = crCardCvc; }
        }
    }
}
