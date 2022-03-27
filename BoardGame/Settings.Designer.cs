
namespace BoardGame {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.easyRadioBtn = new System.Windows.Forms.RadioButton();
            this.medRadioBtn = new System.Windows.Forms.RadioButton();
            this.hardRadioBtn = new System.Windows.Forms.RadioButton();
            this.customRadioBtn = new System.Windows.Forms.RadioButton();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.customPanel = new System.Windows.Forms.Panel();
            this.borderTextboxY = new System.Windows.Forms.TextBox();
            this.borderTextboxX = new System.Windows.Forms.TextBox();
            this.customInt2Lbl = new System.Windows.Forms.Label();
            this.customInt1Lbl = new System.Windows.Forms.Label();
            this.settingsSaveBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.shapePanel = new System.Windows.Forms.Panel();
            this.squareCheckBox = new System.Windows.Forms.CheckBox();
            this.circleCheckBox = new System.Windows.Forms.CheckBox();
            this.triangleCheckBox = new System.Windows.Forms.CheckBox();
            this.difficultyPanel.SuspendLayout();
            this.customPanel.SuspendLayout();
            this.shapePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(105, 54);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(85, 13);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "Difficulty Level : ";
            // 
            // easyRadioBtn
            // 
            this.easyRadioBtn.AutoSize = true;
            this.easyRadioBtn.Checked = true;
            this.easyRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.easyRadioBtn.Name = "easyRadioBtn";
            this.easyRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.easyRadioBtn.TabIndex = 1;
            this.easyRadioBtn.TabStop = true;
            this.easyRadioBtn.Text = "Easy";
            this.easyRadioBtn.UseVisualStyleBackColor = true;
            this.easyRadioBtn.CheckedChanged += new System.EventHandler(this.easyRadioBtn_CheckedChanged);
            // 
            // medRadioBtn
            // 
            this.medRadioBtn.AutoSize = true;
            this.medRadioBtn.Location = new System.Drawing.Point(87, 3);
            this.medRadioBtn.Name = "medRadioBtn";
            this.medRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.medRadioBtn.TabIndex = 2;
            this.medRadioBtn.Text = "Medium";
            this.medRadioBtn.UseVisualStyleBackColor = true;
            this.medRadioBtn.CheckedChanged += new System.EventHandler(this.medRadioBtn_CheckedChanged);
            // 
            // hardRadioBtn
            // 
            this.hardRadioBtn.AutoSize = true;
            this.hardRadioBtn.Location = new System.Drawing.Point(187, 3);
            this.hardRadioBtn.Name = "hardRadioBtn";
            this.hardRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.hardRadioBtn.TabIndex = 3;
            this.hardRadioBtn.Text = "Hard";
            this.hardRadioBtn.UseVisualStyleBackColor = true;
            this.hardRadioBtn.CheckedChanged += new System.EventHandler(this.hardRadioBtn_CheckedChanged);
            // 
            // customRadioBtn
            // 
            this.customRadioBtn.AutoSize = true;
            this.customRadioBtn.Location = new System.Drawing.Point(268, 3);
            this.customRadioBtn.Name = "customRadioBtn";
            this.customRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.customRadioBtn.TabIndex = 4;
            this.customRadioBtn.Text = "Custom";
            this.customRadioBtn.UseVisualStyleBackColor = true;
            this.customRadioBtn.CheckedChanged += new System.EventHandler(this.customRadioBtn_CheckedChanged);
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(123, 114);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(44, 13);
            this.shapeLabel.TabIndex = 5;
            this.shapeLabel.Text = "Shape :";
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficultyPanel.Controls.Add(this.easyRadioBtn);
            this.difficultyPanel.Controls.Add(this.medRadioBtn);
            this.difficultyPanel.Controls.Add(this.hardRadioBtn);
            this.difficultyPanel.Controls.Add(this.customRadioBtn);
            this.difficultyPanel.Location = new System.Drawing.Point(220, 49);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(341, 25);
            this.difficultyPanel.TabIndex = 9;
            // 
            // customPanel
            // 
            this.customPanel.Controls.Add(this.borderTextboxY);
            this.customPanel.Controls.Add(this.borderTextboxX);
            this.customPanel.Controls.Add(this.customInt2Lbl);
            this.customPanel.Controls.Add(this.customInt1Lbl);
            this.customPanel.Location = new System.Drawing.Point(220, 190);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(338, 73);
            this.customPanel.TabIndex = 11;
            this.customPanel.Visible = false;
            // 
            // borderTextboxY
            // 
            this.borderTextboxY.Location = new System.Drawing.Point(134, 39);
            this.borderTextboxY.Name = "borderTextboxY";
            this.borderTextboxY.Size = new System.Drawing.Size(100, 20);
            this.borderTextboxY.TabIndex = 3;
            // 
            // borderTextboxX
            // 
            this.borderTextboxX.Location = new System.Drawing.Point(134, 10);
            this.borderTextboxX.Name = "borderTextboxX";
            this.borderTextboxX.Size = new System.Drawing.Size(100, 20);
            this.borderTextboxX.TabIndex = 2;
            // 
            // customInt2Lbl
            // 
            this.customInt2Lbl.AutoSize = true;
            this.customInt2Lbl.Location = new System.Drawing.Point(15, 42);
            this.customInt2Lbl.Name = "customInt2Lbl";
            this.customInt2Lbl.Size = new System.Drawing.Size(87, 13);
            this.customInt2Lbl.TabIndex = 1;
            this.customInt2Lbl.Text = "Border (y value) :";
            // 
            // customInt1Lbl
            // 
            this.customInt1Lbl.AutoSize = true;
            this.customInt1Lbl.Location = new System.Drawing.Point(15, 13);
            this.customInt1Lbl.Name = "customInt1Lbl";
            this.customInt1Lbl.Size = new System.Drawing.Size(87, 13);
            this.customInt1Lbl.TabIndex = 0;
            this.customInt1Lbl.Text = "Border (x value) :";
            // 
            // settingsSaveBtn
            // 
            this.settingsSaveBtn.Location = new System.Drawing.Point(432, 300);
            this.settingsSaveBtn.Name = "settingsSaveBtn";
            this.settingsSaveBtn.Size = new System.Drawing.Size(116, 53);
            this.settingsSaveBtn.TabIndex = 12;
            this.settingsSaveBtn.Text = "Save";
            this.settingsSaveBtn.UseVisualStyleBackColor = true;
            this.settingsSaveBtn.Click += new System.EventHandler(this.settingsSaveBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(238, 300);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 53);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // shapePanel
            // 
            this.shapePanel.Controls.Add(this.triangleCheckBox);
            this.shapePanel.Controls.Add(this.circleCheckBox);
            this.shapePanel.Controls.Add(this.squareCheckBox);
            this.shapePanel.Location = new System.Drawing.Point(220, 109);
            this.shapePanel.Name = "shapePanel";
            this.shapePanel.Size = new System.Drawing.Size(341, 26);
            this.shapePanel.TabIndex = 14;
            // 
            // squareCheckBox
            // 
            this.squareCheckBox.AutoSize = true;
            this.squareCheckBox.Location = new System.Drawing.Point(3, 4);
            this.squareCheckBox.Name = "squareCheckBox";
            this.squareCheckBox.Size = new System.Drawing.Size(60, 17);
            this.squareCheckBox.TabIndex = 0;
            this.squareCheckBox.Text = "Square";
            this.squareCheckBox.UseVisualStyleBackColor = true;
            // 
            // circleCheckBox
            // 
            this.circleCheckBox.AutoSize = true;
            this.circleCheckBox.Location = new System.Drawing.Point(134, 4);
            this.circleCheckBox.Name = "circleCheckBox";
            this.circleCheckBox.Size = new System.Drawing.Size(52, 17);
            this.circleCheckBox.TabIndex = 1;
            this.circleCheckBox.Text = "Circle";
            this.circleCheckBox.UseVisualStyleBackColor = true;
            // 
            // triangleCheckBox
            // 
            this.triangleCheckBox.AutoSize = true;
            this.triangleCheckBox.Location = new System.Drawing.Point(264, 3);
            this.triangleCheckBox.Name = "triangleCheckBox";
            this.triangleCheckBox.Size = new System.Drawing.Size(64, 17);
            this.triangleCheckBox.TabIndex = 2;
            this.triangleCheckBox.Text = "Triangle";
            this.triangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapePanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.settingsSaveBtn);
            this.Controls.Add(this.customPanel);
            this.Controls.Add(this.difficultyPanel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.difficultyPanel.ResumeLayout(false);
            this.difficultyPanel.PerformLayout();
            this.customPanel.ResumeLayout(false);
            this.customPanel.PerformLayout();
            this.shapePanel.ResumeLayout(false);
            this.shapePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Label customInt2Lbl;
        private System.Windows.Forms.Label customInt1Lbl;
        private System.Windows.Forms.RadioButton easyRadioBtn;
        private System.Windows.Forms.RadioButton medRadioBtn;
        private System.Windows.Forms.RadioButton hardRadioBtn;
        private System.Windows.Forms.RadioButton customRadioBtn;
        private System.Windows.Forms.Panel difficultyPanel;
        private System.Windows.Forms.Panel customPanel;
        private System.Windows.Forms.TextBox borderTextboxY;
        private System.Windows.Forms.TextBox borderTextboxX;
        private System.Windows.Forms.Button settingsSaveBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel shapePanel;
        private System.Windows.Forms.CheckBox triangleCheckBox;
        private System.Windows.Forms.CheckBox circleCheckBox;
        private System.Windows.Forms.CheckBox squareCheckBox;
    }
}