namespace WF_DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_start = new System.Windows.Forms.Button();
            this.rtb_cmd = new System.Windows.Forms.RichTextBox();
            this.bt_cmdGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(660, 12);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(96, 29);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // rtb_cmd
            // 
            this.rtb_cmd.Location = new System.Drawing.Point(30, 58);
            this.rtb_cmd.Name = "rtb_cmd";
            this.rtb_cmd.Size = new System.Drawing.Size(404, 170);
            this.rtb_cmd.TabIndex = 2;
            this.rtb_cmd.Text = "";
            this.rtb_cmd.TextChanged += new System.EventHandler(this.rtb_cmd_TextChanged);
            // 
            // bt_cmdGo
            // 
            this.bt_cmdGo.Location = new System.Drawing.Point(621, 76);
            this.bt_cmdGo.Name = "bt_cmdGo";
            this.bt_cmdGo.Size = new System.Drawing.Size(105, 26);
            this.bt_cmdGo.TabIndex = 3;
            this.bt_cmdGo.Text = "go";
            this.bt_cmdGo.UseVisualStyleBackColor = true;
            this.bt_cmdGo.Click += new System.EventHandler(this.bt_cmdGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 327);
            this.Controls.Add(this.bt_cmdGo);
            this.Controls.Add(this.rtb_cmd);
            this.Controls.Add(this.bt_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.RichTextBox rtb_cmd;
        private System.Windows.Forms.Button bt_cmdGo;
    }
}

