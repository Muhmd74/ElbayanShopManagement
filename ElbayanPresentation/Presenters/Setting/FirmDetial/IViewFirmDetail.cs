using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Setting.FirmDetial
{
    public interface IViewFirmDetail
    {
        PresenterFirmDetail Presenter { get; set; }
        Guna2TextBox FirmName { get; set; }
        Guna2TextBox FirmEmail { get; set; }
        Guna2TextBox FirmMobile { get; set; }
        Guna2TextBox FirmPhone { get; set; }
        Guna2TextBox FirmAddress { get; set; }
        Guna2TextBox FirmNeturework { get; set; }
        Guna2TextBox InvoiceNote { get; set; }
        DateTimePicker StartDay { get; set; }
        DateTimePicker EndDay { get; set; }
        Guna2Button Save { get; set; }
        Guna2Button UploadPicture { get; set; }
        PictureBox FirmLogo { get; set; }
        string LogoURL { get; set; }
    }
}
