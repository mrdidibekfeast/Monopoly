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
            ShoePiece = new PictureBox();
            TexPiece = new PictureBox();
            WheelBarrowPiece = new PictureBox();
            RaceCarPiece = new PictureBox();
            infoPanel = new Panel();
            infoPanelLabel = new Label();
            sellButton = new Button();
            buyButton = new Button();
            rentCostBox = new TextBox();
            priceBox = new TextBox();
            colorBox = new TextBox();
            nameBox = new TextBox();
            rentCostText = new Label();
            priceText = new Label();
            colorText = new Label();
            nameText = new Label();
            playerPanel = new Panel();
            propertiesBox = new ComboBox();
            playerPanelText = new Label();
            playerMoneyBox = new TextBox();
            moneyText = new Label();
            propertiesText = new Label();
            ((System.ComponentModel.ISupportInitialize)MonopolyBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShoePiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TexPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WheelBarrowPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RaceCarPiece).BeginInit();
            infoPanel.SuspendLayout();
            playerPanel.SuspendLayout();
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
            EndTurnButton.Location = new Point(992, 21);
            EndTurnButton.Name = "EndTurnButton";
            EndTurnButton.Size = new Size(77, 23);
            EndTurnButton.TabIndex = 2;
            EndTurnButton.Text = "End turn";
            EndTurnButton.UseVisualStyleBackColor = true;
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
            // infoPanel
            // 
            infoPanel.BackColor = Color.White;
            infoPanel.BorderStyle = BorderStyle.Fixed3D;
            infoPanel.Controls.Add(infoPanelLabel);
            infoPanel.Controls.Add(sellButton);
            infoPanel.Controls.Add(buyButton);
            infoPanel.Controls.Add(rentCostBox);
            infoPanel.Controls.Add(priceBox);
            infoPanel.Controls.Add(colorBox);
            infoPanel.Controls.Add(nameBox);
            infoPanel.Controls.Add(rentCostText);
            infoPanel.Controls.Add(priceText);
            infoPanel.Controls.Add(colorText);
            infoPanel.Controls.Add(nameText);
            infoPanel.Location = new Point(881, 428);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(301, 353);
            infoPanel.TabIndex = 8;
         
            // 
            // infoPanelLabel
            // 
            infoPanelLabel.AutoSize = true;
            infoPanelLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoPanelLabel.Location = new Point(109, 18);
            infoPanelLabel.Name = "infoPanelLabel";
            infoPanelLabel.Size = new Size(69, 15);
            infoPanelLabel.TabIndex = 12;
            infoPanelLabel.Text = "Info Panel";
            // 
            // sellButton
            // 
            sellButton.BackColor = Color.Red;
            sellButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellButton.Location = new Point(155, 278);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(75, 23);
            sellButton.TabIndex = 11;
            sellButton.Text = "SELL";
            sellButton.UseVisualStyleBackColor = false;
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.Lime;
            buyButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyButton.Location = new Point(55, 278);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(75, 23);
            buyButton.TabIndex = 10;
            buyButton.Text = "BUY";
            buyButton.UseVisualStyleBackColor = false;
            // 
            // rentCostBox
            // 
            rentCostBox.Location = new Point(130, 202);
            rentCostBox.Name = "rentCostBox";
            rentCostBox.ReadOnly = true;
            rentCostBox.Size = new Size(128, 23);
            rentCostBox.TabIndex = 9;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(130, 161);
            priceBox.Name = "priceBox";
            priceBox.ReadOnly = true;
            priceBox.Size = new Size(128, 23);
            priceBox.TabIndex = 8;
            // 
            // colorBox
            // 
            colorBox.Location = new Point(130, 126);
            colorBox.Name = "colorBox";
            colorBox.ReadOnly = true;
            colorBox.Size = new Size(128, 23);
            colorBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(130, 90);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(128, 23);
            nameBox.TabIndex = 6;
            // 
            // rentCostText
            // 
            rentCostText.AutoSize = true;
            rentCostText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentCostText.Location = new Point(45, 205);
            rentCostText.Name = "rentCostText";
            rentCostText.Size = new Size(69, 15);
            rentCostText.TabIndex = 5;
            rentCostText.Text = "Rent Cost:";
            // 
            // priceText
            // 
            priceText.AutoSize = true;
            priceText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceText.Location = new Point(45, 164);
            priceText.Name = "priceText";
            priceText.Size = new Size(41, 15);
            priceText.TabIndex = 4;
            priceText.Text = "Price:";
            // 
            // colorText
            // 
            colorText.AutoSize = true;
            colorText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colorText.Location = new Point(45, 129);
            colorText.Name = "colorText";
            colorText.Size = new Size(47, 15);
            colorText.TabIndex = 3;
            colorText.Text = "Color: ";
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameText.Location = new Point(45, 93);
            nameText.Name = "nameText";
            nameText.Size = new Size(49, 15);
            nameText.TabIndex = 2;
            nameText.Text = "Name: ";
            // 
            // playerPanel
            // 
            playerPanel.BackColor = SystemColors.Window;
            playerPanel.Controls.Add(propertiesBox);
            playerPanel.Controls.Add(playerPanelText);
            playerPanel.Controls.Add(playerMoneyBox);
            playerPanel.Controls.Add(moneyText);
            playerPanel.Controls.Add(propertiesText);
            playerPanel.Location = new Point(881, 69);
            playerPanel.Name = "playerPanel";
            playerPanel.Size = new Size(301, 353);
            playerPanel.TabIndex = 0;
            // 
            // propertiesBox
            // 
            propertiesBox.FormattingEnabled = true;
            propertiesBox.Location = new Point(111, 115);
            propertiesBox.Name = "propertiesBox";
            propertiesBox.Size = new Size(128, 23);
            propertiesBox.TabIndex = 17;
            // 
            // playerPanelText
            // 
            playerPanelText.AutoSize = true;
            playerPanelText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerPanelText.Location = new Point(105, 26);
            playerPanelText.Name = "playerPanelText";
            playerPanelText.Size = new Size(82, 15);
            playerPanelText.TabIndex = 12;
            playerPanelText.Text = "Player Panel";
            // 
            // playerMoneyBox
            // 
            playerMoneyBox.Location = new Point(111, 79);
            playerMoneyBox.Name = "playerMoneyBox";
            playerMoneyBox.ReadOnly = true;
            playerMoneyBox.Size = new Size(128, 23);
            playerMoneyBox.TabIndex = 16;
            // 
            // moneyText
            // 
            moneyText.AutoSize = true;
            moneyText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moneyText.Location = new Point(26, 82);
            moneyText.Name = "moneyText";
            moneyText.Size = new Size(53, 15);
            moneyText.TabIndex = 12;
            moneyText.Text = "Money:";
            // 
            // propertiesText
            // 
            propertiesText.AutoSize = true;
            propertiesText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            propertiesText.Location = new Point(26, 118);
            propertiesText.Name = "propertiesText";
            propertiesText.Size = new Size(74, 15);
            propertiesText.TabIndex = 13;
            propertiesText.Text = "Properties:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 826);
            Controls.Add(playerPanel);
            Controls.Add(infoPanel);
            Controls.Add(RaceCarPiece);
            Controls.Add(WheelBarrowPiece);
            Controls.Add(TexPiece);
            Controls.Add(ShoePiece);
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
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            playerPanel.ResumeLayout(false);
            playerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MonopolyBoard;
        private Button RollDiceButton;
        private Button EndTurnButton;
        private PictureBox ShoePiece;
        private PictureBox TexPiece;
        private PictureBox WheelBarrowPiece;
        private PictureBox RaceCarPiece;
        private Panel infoPanel;
        private Label nameText;
        private TextBox rentCostBox;
        private TextBox priceBox;
        private TextBox colorBox;
        private TextBox nameBox;
        private Label rentCostText;
        private Label priceText;
        private Label colorText;
        private Button sellButton;
        private Button buyButton;
        private Panel playerPanel;
        private Label playerPanelText;
        private TextBox playerMoneyBox;
        private Label moneyText;
        private Label propertiesText;
        private ComboBox propertiesBox;
        private Label infoPanelLabel;
    }
}
