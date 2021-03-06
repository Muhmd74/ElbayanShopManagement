using ElbayanServices.Repository.Firms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Setting.FirmDetial
{
    public class PresenterFirmDetail
    {
        private readonly IViewFirmDetail _view;
        private readonly FirmService Firm = new FirmService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterFirmDetail(IViewFirmDetail view)
        {
            _view = view;
        }
        public void OnLoad()
        {
            _view.Save.Click += new EventHandler(SaveFrimData);
            _view.UploadPicture.Click += new EventHandler(UploadPicture);
            GetFirmById();
        }
        private void SaveFrimData(object sender, EventArgs e)
        {
            if (_view.FirmName.Text != string.Empty)
            {
                Firm.UpdateFirm(new ElbayanServices.Repository.Firms.Dtos.FirmDto
                {
                    Name = _view.FirmName.Text,
                    Phone = Convert.ToInt32(_view.FirmPhone.Text),
                    Mobile = Convert.ToInt32(_view.FirmMobile.Text),
                    Email = _view.FirmEmail.Text,
                    Address = _view.FirmAddress.Text,
                    NatureWork = _view.FirmNeturework.Text,
                    MessageInvoice = _view.InvoiceNote.Text,
                    Start = _view.StartDay.Value,
                    End = _view.EndDay.Value,
                    LogoInvoice = _view.LogoURL
                });
                MessageBox.Show("تمت عملية الحفظ بنجاح");
            }
            else
            {
                MessageBox.Show("لا بد من إدخال اسم الشركة ");
            }
        }
        private void UploadPicture(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "ملفات الصور (*.jpg; *.jpeg; *.gif; *.png; *.bmp;) | *.jpg; *.jpeg; *.gif; *.png; *.bmp;";
            if (image.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(image.FileName))
            {
                _view.FirmLogo.Image = new Bitmap(image.FileName);
                _view.LogoURL = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\ProductImage\", Path.GetFileName(image.FileName));
                if (File.Exists(_view.LogoURL))
                {
                    File.Delete(_view.LogoURL);
                }
                //File.Move(@"c:\test\SomeFile.txt", @"c:\test\Test\SomeFile.txt");
                File.Copy(image.FileName, _view.LogoURL);
            }
        }

        // To Update Firm Data
        // - Load By Id
        private Guid GetFirmById()
        {
            var firm = Firm.Get();
            if (firm != null)
            {
                _view.FirmName.Text = firm.Name;
                _view.FirmEmail.Text = firm.Email;
                _view.FirmNeturework.Text = firm.NatureWork;
                _view.FirmMobile.Text = firm.Mobile.ToString();
                _view.FirmPhone.Text = firm.Phone.ToString();
                _view.FirmAddress.Text = firm.Address;
                _view.StartDay.Value = firm.Start;
                _view.EndDay.Value = firm.End;
                _view.LogoURL = firm.LogoInvoice;
                _view.FirmLogo.Image = new Bitmap(_view.LogoURL);
                _view.InvoiceNote.Text = firm.MessageInvoice;
            }
            return firm.Id;
        }
    }
}
