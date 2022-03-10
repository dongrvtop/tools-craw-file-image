
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChooseFile = new System.Windows.Forms.TextBox();
            this.listStatus = new System.Windows.Forms.RichTextBox();
            this.txtThongKe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(40, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 80);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(375, 76);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 5;
            this.btnChooseFile.Text = "Chọn file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Crawl status";
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Location = new System.Drawing.Point(491, 78);
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.Size = new System.Drawing.Size(367, 20);
            this.txtChooseFile.TabIndex = 7;
            // 
            // listStatus
            // 
            this.listStatus.Location = new System.Drawing.Point(40, 180);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(818, 276);
            this.listStatus.TabIndex = 9;
            this.listStatus.Text = "";
            // 
            // txtThongKe
            // 
            this.txtThongKe.Location = new System.Drawing.Point(40, 462);
            this.txtThongKe.Name = "txtThongKe";
            this.txtThongKe.Size = new System.Drawing.Size(818, 33);
            this.txtThongKe.TabIndex = 10;
            this.txtThongKe.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 516);
            this.Controls.Add(this.txtThongKe);
            this.Controls.Add(this.listStatus);
            this.Controls.Add(this.txtChooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Tool Crawl File Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChooseFile;
        private System.Windows.Forms.RichTextBox listStatus;
        private System.Windows.Forms.RichTextBox txtThongKe;
    }
}

