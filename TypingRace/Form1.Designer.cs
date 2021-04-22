namespace TypingRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_word = new System.Windows.Forms.TextBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.lbl_mins = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_Keyboard_728976.png");
            // 
            // txt_word
            // 
            this.txt_word.Location = new System.Drawing.Point(164, 297);
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(304, 22);
            this.txt_word.TabIndex = 0;
            this.txt_word.TextChanged += new System.EventHandler(this.txt_word_TextChanged);
            this.txt_word.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(12, 12);
            this.txt_text.Multiline = true;
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(655, 226);
            this.txt_text.TabIndex = 1;
            // 
            // lbl_mins
            // 
            this.lbl_mins.AutoSize = true;
            this.lbl_mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mins.Location = new System.Drawing.Point(258, 358);
            this.lbl_mins.Name = "lbl_mins";
            this.lbl_mins.Size = new System.Drawing.Size(87, 32);
            this.lbl_mins.TabIndex = 2;
            this.lbl_mins.Text = "00:00";
            this.lbl_mins.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(548, 556);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(119, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(264, 368);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(81, 22);
            this.txt_tempo.TabIndex = 4;
            this.txt_tempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tempo_KeyPress);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(245, 410);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(119, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(261, 341);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(56, 17);
            this.lbl_tempo.TabIndex = 6;
            this.lbl_tempo.Text = "Tempo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 591);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_mins);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.txt_word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Typing Race";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_word;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Label lbl_mins;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_tempo;
    }
}

