namespace EchoMessenger
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
            btnSend = new Button();
            lstChat = new ListBox();
            txtInput = new TextBox();
            lblTitle = new Label();
            lblResult = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 192, 0);
            btnSend.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(589, 394);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(93, 46);
            btnSend.TabIndex = 0;
            btnSend.Text = "입력";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lstChat
            // 
            lstChat.Font = new Font("한컴 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(119, 74);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(563, 303);
            lstChat.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("한컴 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(119, 401);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(464, 33);
            txtInput.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(128, 128, 255);
            lblTitle.Location = new Point(119, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 46);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Echo Messenger";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.White;
            lblResult.Font = new Font("한컴 고딕", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblResult.Location = new Point(525, 22);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(157, 31);
            lblResult.TabIndex = 4;
            lblResult.Text = "현재 대화: 0개";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelete.Location = new Point(688, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 59);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "선택 항목 삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.Location = new Point(688, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 63);
            btnClear.TabIndex = 6;
            btnClear.Text = "전체 항목 삭제";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblResult);
            Controls.Add(lblTitle);
            Controls.Add(txtInput);
            Controls.Add(lstChat);
            Controls.Add(btnSend);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private ListBox lstChat;
        private TextBox txtInput;
        private Label lblTitle;
        private Label lblResult;
        private Button btnDelete;
        private Button btnClear;
    }
}
