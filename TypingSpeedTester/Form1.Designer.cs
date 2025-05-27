namespace TypingSpeedTester
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTestText = new Label();
            txtInput = new TextBox();
            btnStart = new Button();
            btnReset = new Button();
            lblResult = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTestText
            // 
            lblTestText.AutoSize = true;
            lblTestText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTestText.ForeColor = Color.White;
            lblTestText.Location = new Point(0, 0);
            lblTestText.Name = "lblTestText";
            lblTestText.Size = new Size(0, 30);
            lblTestText.TabIndex = 5;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(45, 45, 45);
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(0, 0);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(399, 93);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(40, 167, 69);
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 35);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(220, 53, 69);
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(0, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 35);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(0, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 21);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(696, 426);
            Controls.Add(lblResult);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(txtInput);
            Controls.Add(lblTestText);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "TypeFast";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTestText;
        private TextBox txtInput;
        private Button btnStart;
        private Button btnReset;
        private Label lblResult;
        private System.Windows.Forms.Timer timer1;
    }
}
