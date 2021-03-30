using ElbayaNPresentation.Presenters.Setting.FirmDetial;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Views.Settings.Firm
{
    public partial class frmFirmDetail : MetroFramework.Forms.MetroForm, IViewFirmDetail
    {
        public frmFirmDetail()
        {
            InitializeComponent();
            _instance = this;
            Presenter = new PresenterFirmDetail(this);
            Presenter.OnLoad();
        }
        private static frmFirmDetail _instance;
        public static frmFirmDetail Instance { get 
            {
                if (_instance == null)
                    _instance = new frmFirmDetail();
                return _instance;
            }
        }

        public PresenterFirmDetail Presenter { get; set; }
        public Guna2TextBox FirmName { get => txtFirmName; set => txtFirmName = value; }
        public Guna2TextBox FirmEmail { get => txtFirmEmail; set => txtFirmEmail = value; }
        public Guna2TextBox FirmMobile { get => txtFirmMobile; set => txtFirmMobile = value; }
        public Guna2TextBox FirmPhone { get => txtFirmPhone; set => txtFirmPhone = value; }
        public Guna2TextBox FirmAddress { get => txtFirmAddress; set => txtFirmAddress = value; }
        public Guna2TextBox FirmNeturework { get => txtFirmNutrework; set => txtFirmNutrework = value; }
        public Guna2TextBox InvoiceNote { get => txtInvoiceNote; set => txtInvoiceNote = value; }
        public DateTimePicker StartDay { get => dtpStartDay; set => dtpStartDay = value; }
        public DateTimePicker EndDay { get => dtpEndDay; set => dtpEndDay = value; }
        public Guna2Button Save { get => btnSave; set => btnSave = value; }
        public Guna2Button UploadPicture { get => btnUploadPicture; set => btnUploadPicture = value; }
        public PictureBox FirmLogo { get => pbFirmLogo; set => pbFirmLogo = value; }
        public string LogoURL { get; set; }
    }
}
