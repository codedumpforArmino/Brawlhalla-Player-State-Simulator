namespace Brawlhalla_Player_State_Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            lbl_StateIndicator = new Label();
            lbl_CurrState = new Label();
            PlayerState_Box = new PictureBox();
            splitContainer3 = new SplitContainer();
            rtb_ReportLog = new RichTextBox();
            btn_VGround = new Button();
            btn_HGround = new Button();
            btn_Recovery = new Button();
            btn_Dodge = new Button();
            btn_Jump = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlayerState_Box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lbl_StateIndicator);
            splitContainer2.Panel1.Controls.Add(lbl_CurrState);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(PlayerState_Box);
            splitContainer2.Size = new Size(266, 450);
            splitContainer2.SplitterDistance = 122;
            splitContainer2.TabIndex = 0;
            // 
            // lbl_StateIndicator
            // 
            lbl_StateIndicator.AutoSize = true;
            lbl_StateIndicator.Location = new Point(12, 57);
            lbl_StateIndicator.Name = "lbl_StateIndicator";
            lbl_StateIndicator.Size = new Size(59, 25);
            lbl_StateIndicator.TabIndex = 1;
            lbl_StateIndicator.Text = "label1";
            // 
            // lbl_CurrState
            // 
            lbl_CurrState.AutoSize = true;
            lbl_CurrState.Location = new Point(72, 9);
            lbl_CurrState.Name = "lbl_CurrState";
            lbl_CurrState.Size = new Size(114, 25);
            lbl_CurrState.TabIndex = 0;
            lbl_CurrState.Text = "Current State";
            // 
            // PlayerState_Box
            // 
            PlayerState_Box.Image = Properties.Resources.grounded;
            PlayerState_Box.Location = new Point(29, 18);
            PlayerState_Box.Name = "PlayerState_Box";
            PlayerState_Box.Size = new Size(209, 294);
            PlayerState_Box.SizeMode = PictureBoxSizeMode.CenterImage;
            PlayerState_Box.TabIndex = 0;
            PlayerState_Box.TabStop = false;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(rtb_ReportLog);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btn_VGround);
            splitContainer3.Panel2.Controls.Add(btn_HGround);
            splitContainer3.Panel2.Controls.Add(btn_Recovery);
            splitContainer3.Panel2.Controls.Add(btn_Dodge);
            splitContainer3.Panel2.Controls.Add(btn_Jump);
            splitContainer3.Size = new Size(530, 450);
            splitContainer3.SplitterDistance = 310;
            splitContainer3.TabIndex = 0;
            // 
            // rtb_ReportLog
            // 
            rtb_ReportLog.Location = new Point(34, 12);
            rtb_ReportLog.Name = "rtb_ReportLog";
            rtb_ReportLog.Size = new Size(470, 295);
            rtb_ReportLog.TabIndex = 0;
            rtb_ReportLog.Text = "";
            // 
            // btn_VGround
            // 
            btn_VGround.Location = new Point(259, 71);
            btn_VGround.Name = "btn_VGround";
            btn_VGround.Size = new Size(112, 34);
            btn_VGround.TabIndex = 9;
            btn_VGround.Text = "V. Ground";
            btn_VGround.UseVisualStyleBackColor = true;
            // 
            // btn_HGround
            // 
            btn_HGround.Location = new Point(141, 71);
            btn_HGround.Name = "btn_HGround";
            btn_HGround.Size = new Size(112, 34);
            btn_HGround.TabIndex = 8;
            btn_HGround.Text = "H. Ground";
            btn_HGround.UseVisualStyleBackColor = true;
            btn_HGround.Click += btn_HGround_Click;
            // 
            // btn_Recovery
            // 
            btn_Recovery.Location = new Point(327, 31);
            btn_Recovery.Name = "btn_Recovery";
            btn_Recovery.Size = new Size(112, 34);
            btn_Recovery.TabIndex = 7;
            btn_Recovery.Text = "Recovery";
            btn_Recovery.UseVisualStyleBackColor = true;
            btn_Recovery.Click += btn_Recovery_Click;
            // 
            // btn_Dodge
            // 
            btn_Dodge.Location = new Point(209, 31);
            btn_Dodge.Name = "btn_Dodge";
            btn_Dodge.Size = new Size(112, 34);
            btn_Dodge.TabIndex = 6;
            btn_Dodge.Text = "Dodge";
            btn_Dodge.UseVisualStyleBackColor = true;
            btn_Dodge.Click += btn_Dodge_Click;
            // 
            // btn_Jump
            // 
            btn_Jump.Location = new Point(91, 31);
            btn_Jump.Name = "btn_Jump";
            btn_Jump.Size = new Size(112, 34);
            btn_Jump.TabIndex = 5;
            btn_Jump.Text = "Jump";
            btn_Jump.UseVisualStyleBackColor = true;
            btn_Jump.Click += btn_Jump_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlayerState_Box).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private PictureBox PlayerState_Box;
        private Label lbl_StateIndicator;
        private Label lbl_CurrState;
        private SplitContainer splitContainer3;
        private Button btn_VGround;
        private Button btn_HGround;
        private Button btn_Recovery;
        private Button btn_Dodge;
        private Button btn_Jump;
        private RichTextBox rtb_ReportLog;
    }
}
