namespace Insta360.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            getInfoButton = new Button();
            responseTextBox = new TextBox();
            button1 = new Button();
            setOptionsButton = new Button();
            hdrCheckBox = new CheckBox();
            imageRadio = new RadioButton();
            videoRadio = new RadioButton();
            startCaptureButton = new Button();
            takePictureButton = new Button();
            SuspendLayout();
            // 
            // getInfoButton
            // 
            getInfoButton.Location = new Point(12, 109);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(142, 57);
            getInfoButton.TabIndex = 0;
            getInfoButton.Text = "Get Info";
            getInfoButton.UseVisualStyleBackColor = true;
            getInfoButton.Click += getInfoButton_Click;
            // 
            // responseTextBox
            // 
            responseTextBox.Location = new Point(377, 47);
            responseTextBox.Multiline = true;
            responseTextBox.Name = "responseTextBox";
            responseTextBox.ReadOnly = true;
            responseTextBox.Size = new Size(336, 358);
            responseTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(160, 109);
            button1.Name = "button1";
            button1.Size = new Size(142, 57);
            button1.TabIndex = 3;
            button1.Text = "Get State";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // setOptionsButton
            // 
            setOptionsButton.Location = new Point(12, 219);
            setOptionsButton.Name = "setOptionsButton";
            setOptionsButton.Size = new Size(142, 57);
            setOptionsButton.TabIndex = 4;
            setOptionsButton.Text = "Set Options";
            setOptionsButton.UseVisualStyleBackColor = true;
            setOptionsButton.Click += setOptionsButton_Click;
            // 
            // hdrCheckBox
            // 
            hdrCheckBox.AutoSize = true;
            hdrCheckBox.Location = new Point(254, 236);
            hdrCheckBox.Name = "hdrCheckBox";
            hdrCheckBox.Size = new Size(62, 24);
            hdrCheckBox.TabIndex = 5;
            hdrCheckBox.Text = "HDR";
            hdrCheckBox.UseVisualStyleBackColor = true;
            // 
            // imageRadio
            // 
            imageRadio.AutoSize = true;
            imageRadio.Location = new Point(160, 219);
            imageRadio.Name = "imageRadio";
            imageRadio.Size = new Size(72, 24);
            imageRadio.TabIndex = 6;
            imageRadio.TabStop = true;
            imageRadio.Text = "Image";
            imageRadio.UseVisualStyleBackColor = true;
            // 
            // videoRadio
            // 
            videoRadio.AutoSize = true;
            videoRadio.Location = new Point(160, 252);
            videoRadio.Name = "videoRadio";
            videoRadio.Size = new Size(69, 24);
            videoRadio.TabIndex = 7;
            videoRadio.TabStop = true;
            videoRadio.Text = "Video";
            videoRadio.UseVisualStyleBackColor = true;
            // 
            // startCaptureButton
            // 
            startCaptureButton.Location = new Point(160, 323);
            startCaptureButton.Name = "startCaptureButton";
            startCaptureButton.Size = new Size(142, 57);
            startCaptureButton.TabIndex = 8;
            startCaptureButton.Text = "Start Capture";
            startCaptureButton.UseVisualStyleBackColor = true;
            startCaptureButton.Click += startCaptureButton_Click;
            // 
            // takePictureButton
            // 
            takePictureButton.Location = new Point(12, 323);
            takePictureButton.Name = "takePictureButton";
            takePictureButton.Size = new Size(142, 57);
            takePictureButton.TabIndex = 9;
            takePictureButton.Text = "Take Picture";
            takePictureButton.UseVisualStyleBackColor = true;
            takePictureButton.Click += takePictureButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 456);
            Controls.Add(takePictureButton);
            Controls.Add(startCaptureButton);
            Controls.Add(videoRadio);
            Controls.Add(imageRadio);
            Controls.Add(hdrCheckBox);
            Controls.Add(setOptionsButton);
            Controls.Add(button1);
            Controls.Add(responseTextBox);
            Controls.Add(getInfoButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getInfoButton;
        private TextBox responseTextBox;
        private Button button1;
        private Button setOptionsButton;
        private CheckBox hdrCheckBox;
        private RadioButton imageRadio;
        private RadioButton videoRadio;
        private Button startCaptureButton;
        private Button takePictureButton;
    }
}