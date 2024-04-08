using Insta360.NET.API;
using Insta360.NET.API.Models.Enums;
using Insta360.NET.API.Models.Responses;
using Newtonsoft.Json;

namespace Insta360.Desktop
{
    public partial class MainForm : Form
    {
        private API Api;

        public MainForm()
        {
            InitializeComponent();
            Api = new API();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void getInfoButton_Click(object sender, EventArgs e)
        {
            var result = await Api.GetInfoAsync();
            responseTextBox.Text = JsonConvert.SerializeObject(result);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await Api.GetStateAsync();
            responseTextBox.Text = JsonConvert.SerializeObject(result);
        }

        private async void setOptionsButton_Click(object sender, EventArgs e)
        {
            var hdr = hdrCheckBox.Checked ? HDR.hdr : HDR.off;
            SetOptionsResponse result;

            if (videoRadio.Checked)
            {
                result = await Api.SetOptionsAsync(CaptureModes._other, hdr);
            }
            else if (imageRadio.Checked)
            {
                result = await Api.SetOptionsAsync(CaptureModes.image, hdr);
            }
            else
            {
                throw new NotImplementedException();
            }

            responseTextBox.Text = JsonConvert.SerializeObject(result);

        }

        private async void takePictureButton_Click(object sender, EventArgs e)
        {
            var hdr = hdrCheckBox.Checked ? HDR.hdr : HDR.off;
            var result = await Api.TakePictureAsync(hdr);
            responseTextBox.Text = JsonConvert.SerializeObject(result);
        }

        bool isCapturing = false;
        private async void startCaptureButton_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                var result = await Api.StopCaptureAsync();

                if (result.IsDone)
                {
                    isCapturing = false;
                    startCaptureButton.Text = "Start Capture";
                }

                responseTextBox.Text = JsonConvert.SerializeObject(result);
            }
            else
            {
                var hdr = hdrCheckBox.Checked ? HDR.hdr : HDR.off;
                var result = await Api.StartCaptureAsync(hdr);

                if (result.IsDone)
                {
                    isCapturing = true;
                    startCaptureButton.Text = "Stop Capture";
                }

                responseTextBox.Text = JsonConvert.SerializeObject(result);
            }
        }

    }
}
