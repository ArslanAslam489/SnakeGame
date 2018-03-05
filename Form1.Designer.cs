namespace Snake_game
{
    partial class Snake
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
            this.GameScreen = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.ComboBox();
            this.buttonArray1 = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameScreen
            // 
            this.GameScreen.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GameScreen.Location = new System.Drawing.Point(12, 12);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(495, 401);
            this.GameScreen.TabIndex = 0;
            this.GameScreen.TabStop = false;
            this.GameScreen.Click += new System.EventHandler(this.pictureBox1_Click);
            this.GameScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // speed
            // 
            this.speed.FormattingEnabled = true;
            this.speed.Items.AddRange(new object[] {
            "6",
            "10",
            "14",
            "18",
            "22",
            "26",
            "30",
            "34",
            "38",
            "42",
            "46",
            "50",
            "54",
            "58",
            "62",
            "66",
            "70",
            "74",
            "78",
            "82",
            "86",
            "92",
            "96",
            "100"});
            this.speed.Location = new System.Drawing.Point(513, 12);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(121, 21);
            this.speed.TabIndex = 3;
            this.speed.Text = "Select Speed";
            this.speed.Visible = false;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 426);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameScreen);
            this.Name = "Snake";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonArray1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameScreen;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox speed;
        private Microsoft.VisualBasic.Compatibility.VB6.ButtonArray buttonArray1;
    }
}

