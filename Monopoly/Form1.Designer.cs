namespace Monopoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            RollDiceButton = new Button();
            EndTurnButton = new Button();
            label1 = new Label();
            ShoePiece = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShoePiece).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 800);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RollDiceButton
            // 
            RollDiceButton.Location = new Point(899, 21);
            RollDiceButton.Name = "RollDiceButton";
            RollDiceButton.Size = new Size(75, 23);
            RollDiceButton.TabIndex = 1;
            RollDiceButton.Text = "Roll Dice";
            RollDiceButton.UseVisualStyleBackColor = true;
            // 
            // EndTurnButton
            // 
            EndTurnButton.Location = new Point(980, 21);
            EndTurnButton.Name = "EndTurnButton";
            EndTurnButton.Size = new Size(77, 23);
            EndTurnButton.TabIndex = 2;
            EndTurnButton.Text = "End turn";
            EndTurnButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // ShoePiece
            // 
            ShoePiece.BackColor = Color.Transparent;
            ShoePiece.Image = (Image)resources.GetObject("ShoePiece.Image");
            ShoePiece.InitialImage = (Image)resources.GetObject("ShoePiece.InitialImage");
            ShoePiece.Location = new Point(123, 64);
            ShoePiece.Name = "ShoePiece";
            ShoePiece.Size = new Size(36, 29);
            ShoePiece.SizeMode = PictureBoxSizeMode.StretchImage;
            ShoePiece.TabIndex = 4;
            ShoePiece.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 826);
            Controls.Add(ShoePiece);
            Controls.Add(label1);
            Controls.Add(EndTurnButton);
            Controls.Add(RollDiceButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShoePiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button RollDiceButton;
        private Button EndTurnButton;
        private Label label1;
        private PictureBox ShoePiece;
    }
}
