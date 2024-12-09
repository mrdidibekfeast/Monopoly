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
            MonopolyBoard = new PictureBox();
            RollDiceButton = new Button();
            EndTurnButton = new Button();
            label1 = new Label();
            ShoePiece = new PictureBox();
            TexPiece = new PictureBox();
            WheelBarrowPiece = new PictureBox();
            RaceCarPiece = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MonopolyBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShoePiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TexPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WheelBarrowPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RaceCarPiece).BeginInit();
            SuspendLayout();
            // 
            // MonopolyBoard
            // 
            MonopolyBoard.Image = (Image)resources.GetObject("MonopolyBoard.Image");
            MonopolyBoard.Location = new Point(61, 0);
            MonopolyBoard.Name = "MonopolyBoard";
            MonopolyBoard.Size = new Size(800, 800);
            MonopolyBoard.SizeMode = PictureBoxSizeMode.Zoom;
            MonopolyBoard.TabIndex = 0;
            MonopolyBoard.TabStop = false;
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
            ShoePiece.Location = new Point(770, 704);
            ShoePiece.Name = "ShoePiece";
            ShoePiece.Size = new Size(36, 29);
            ShoePiece.SizeMode = PictureBoxSizeMode.StretchImage;
            ShoePiece.TabIndex = 4;
            ShoePiece.TabStop = false;
            // 
            // TexPiece
            // 
            TexPiece.BackColor = Color.Transparent;
            TexPiece.Image = (Image)resources.GetObject("TexPiece.Image");
            TexPiece.InitialImage = (Image)resources.GetObject("TexPiece.InitialImage");
            TexPiece.Location = new Point(812, 739);
            TexPiece.Name = "TexPiece";
            TexPiece.Size = new Size(36, 29);
            TexPiece.SizeMode = PictureBoxSizeMode.StretchImage;
            TexPiece.TabIndex = 5;
            TexPiece.TabStop = false;
            // 
            // WheelBarrowPiece
            // 
            WheelBarrowPiece.BackColor = Color.Transparent;
            WheelBarrowPiece.Image = (Image)resources.GetObject("WheelBarrowPiece.Image");
            WheelBarrowPiece.InitialImage = (Image)resources.GetObject("WheelBarrowPiece.InitialImage");
            WheelBarrowPiece.Location = new Point(812, 704);
            WheelBarrowPiece.Name = "WheelBarrowPiece";
            WheelBarrowPiece.Size = new Size(36, 29);
            WheelBarrowPiece.SizeMode = PictureBoxSizeMode.StretchImage;
            WheelBarrowPiece.TabIndex = 6;
            WheelBarrowPiece.TabStop = false;
            // 
            // RaceCarPiece
            // 
            RaceCarPiece.BackColor = Color.Transparent;
            RaceCarPiece.Image = (Image)resources.GetObject("RaceCarPiece.Image");
            RaceCarPiece.InitialImage = (Image)resources.GetObject("RaceCarPiece.InitialImage");
            RaceCarPiece.Location = new Point(770, 739);
            RaceCarPiece.Name = "RaceCarPiece";
            RaceCarPiece.Size = new Size(36, 29);
            RaceCarPiece.SizeMode = PictureBoxSizeMode.StretchImage;
            RaceCarPiece.TabIndex = 7;
            RaceCarPiece.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 826);
            Controls.Add(RaceCarPiece);
            Controls.Add(WheelBarrowPiece);
            Controls.Add(TexPiece);
            Controls.Add(ShoePiece);
            Controls.Add(label1);
            Controls.Add(EndTurnButton);
            Controls.Add(RollDiceButton);
            Controls.Add(MonopolyBoard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)MonopolyBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShoePiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)TexPiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)WheelBarrowPiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)RaceCarPiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MonopolyBoard;
        private Button RollDiceButton;
        private Button EndTurnButton;
        private Label label1;
        private PictureBox ShoePiece;
        private PictureBox TexPiece;
        private PictureBox WheelBarrowPiece;
        private PictureBox RaceCarPiece;
    }
}
