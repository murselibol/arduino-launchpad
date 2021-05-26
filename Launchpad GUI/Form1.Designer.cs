namespace launchpad
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
            this.log_textbox = new System.Windows.Forms.TextBox();
            this.source_textbox = new System.Windows.Forms.TextBox();
            this.source_button = new System.Windows.Forms.Button();
            this.music_folder_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.set_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(168, 110);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_textbox.Size = new System.Drawing.Size(188, 210);
            this.log_textbox.TabIndex = 0;
            // 
            // source_textbox
            // 
            this.source_textbox.Location = new System.Drawing.Point(13, 13);
            this.source_textbox.Name = "source_textbox";
            this.source_textbox.ReadOnly = true;
            this.source_textbox.Size = new System.Drawing.Size(231, 22);
            this.source_textbox.TabIndex = 1;
            this.source_textbox.Text = "Select directory";
            // 
            // source_button
            // 
            this.source_button.Location = new System.Drawing.Point(251, 11);
            this.source_button.Name = "source_button";
            this.source_button.Size = new System.Drawing.Size(105, 23);
            this.source_button.TabIndex = 2;
            this.source_button.Text = "SELECT";
            this.source_button.UseVisualStyleBackColor = true;
            this.source_button.Click += new System.EventHandler(this.source_button_Click);
            // 
            // music_folder_box
            // 
            this.music_folder_box.FormattingEnabled = true;
            this.music_folder_box.Location = new System.Drawing.Point(13, 56);
            this.music_folder_box.Name = "music_folder_box";
            this.music_folder_box.Size = new System.Drawing.Size(343, 24);
            this.music_folder_box.TabIndex = 3;
            this.music_folder_box.Text = "Select Music";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PORT: -";
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(15, 151);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(136, 31);
            this.set_button.TabIndex = 5;
            this.set_button.Text = "SET";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(15, 223);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(136, 31);
            this.connect_button.TabIndex = 6;
            this.connect_button.Text = "CONNECT";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 332);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.set_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.music_folder_box);
            this.Controls.Add(this.source_button);
            this.Controls.Add(this.source_textbox);
            this.Controls.Add(this.log_textbox);
            this.Name = "Form1";
            this.Text = "LaunchPad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_textbox;
        private System.Windows.Forms.TextBox source_textbox;
        private System.Windows.Forms.Button source_button;
        private System.Windows.Forms.ComboBox music_folder_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.Button connect_button;
    }
}

