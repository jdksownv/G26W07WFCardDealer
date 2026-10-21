namespace G26W07WFCardDealer
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
            Card1 = new PictureBox();
            btnDeal = new Button();
            Card2 = new PictureBox();
            Card3 = new PictureBox();
            Card4 = new PictureBox();
            Card5 = new PictureBox();
            RankText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card5).BeginInit();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.Image = Properties.Resources.red_joker;
            Card1.Location = new Point(12, 12);
            Card1.Name = "Card1";
            Card1.Size = new Size(206, 296);
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(12, 314);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(206, 23);
            btnDeal.TabIndex = 1;
            btnDeal.Text = "카드분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += OnDeal;
            // 
            // Card2
            // 
            Card2.Image = Properties.Resources.red_joker;
            Card2.Location = new Point(224, 12);
            Card2.Name = "Card2";
            Card2.Size = new Size(206, 296);
            Card2.SizeMode = PictureBoxSizeMode.Zoom;
            Card2.TabIndex = 2;
            Card2.TabStop = false;
            // 
            // Card3
            // 
            Card3.Image = Properties.Resources.red_joker;
            Card3.Location = new Point(436, 12);
            Card3.Name = "Card3";
            Card3.Size = new Size(206, 296);
            Card3.SizeMode = PictureBoxSizeMode.Zoom;
            Card3.TabIndex = 3;
            Card3.TabStop = false;
            // 
            // Card4
            // 
            Card4.Image = Properties.Resources.red_joker;
            Card4.Location = new Point(648, 12);
            Card4.Name = "Card4";
            Card4.Size = new Size(206, 296);
            Card4.SizeMode = PictureBoxSizeMode.Zoom;
            Card4.TabIndex = 4;
            Card4.TabStop = false;
            // 
            // Card5
            // 
            Card5.Image = Properties.Resources.red_joker;
            Card5.Location = new Point(860, 12);
            Card5.Name = "Card5";
            Card5.Size = new Size(206, 296);
            Card5.SizeMode = PictureBoxSizeMode.Zoom;
            Card5.TabIndex = 5;
            Card5.TabStop = false;
            // 
            // RankText
            // 
            RankText.Location = new Point(224, 314);
            RankText.Name = "RankText";
            RankText.ReadOnly = true;
            RankText.Size = new Size(841, 23);
            RankText.TabIndex = 6;
            RankText.TextChanged += RankText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 427);
            Controls.Add(RankText);
            Controls.Add(Card5);
            Controls.Add(Card4);
            Controls.Add(Card3);
            Controls.Add(Card2);
            Controls.Add(btnDeal);
            Controls.Add(Card1);
            Name = "Form1";
            Text = "카드딜러";
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Card1;
        private Button btnDeal;
        private PictureBox Card2;
        private PictureBox Card3;
        private PictureBox Card4;
        private PictureBox Card5;
        private TextBox RankText;
    }
}
