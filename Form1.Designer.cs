﻿namespace ChangliReborn
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            JinhsiIconSide = new PictureBox();
            ChangliIconSide = new PictureBox();
            JinhsiSelect = new Button();
            ChangliSelect = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JinhsiIconSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangliIconSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(JinhsiIconSide);
            flowLayoutPanel1.Controls.Add(ChangliIconSide);
            flowLayoutPanel1.Controls.Add(JinhsiSelect);
            flowLayoutPanel1.Controls.Add(ChangliSelect);
            flowLayoutPanel1.Location = new Point(-4, -1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(286, 582);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // JinhsiIconSide
            // 
            JinhsiIconSide.Cursor = Cursors.Hand;
            JinhsiIconSide.Image = (Image)resources.GetObject("JinhsiIconSide.Image");
            JinhsiIconSide.Location = new Point(3, 3);
            JinhsiIconSide.Name = "JinhsiIconSide";
            JinhsiIconSide.Size = new Size(90, 90);
            JinhsiIconSide.SizeMode = PictureBoxSizeMode.Zoom;
            JinhsiIconSide.TabIndex = 3;
            JinhsiIconSide.TabStop = false;
            JinhsiIconSide.Click += JinhsiIconSide_Click;
            // 
            // ChangliIconSide
            // 
            ChangliIconSide.BackgroundImageLayout = ImageLayout.Center;
            ChangliIconSide.Cursor = Cursors.Hand;
            ChangliIconSide.Image = (Image)resources.GetObject("ChangliIconSide.Image");
            ChangliIconSide.Location = new Point(99, 3);
            ChangliIconSide.Name = "ChangliIconSide";
            ChangliIconSide.Size = new Size(90, 90);
            ChangliIconSide.SizeMode = PictureBoxSizeMode.Zoom;
            ChangliIconSide.TabIndex = 2;
            ChangliIconSide.TabStop = false;
            ChangliIconSide.Click += ChangliIconSide_Click;
            // 
            // JinhsiSelect
            // 
            JinhsiSelect.Location = new Point(3, 99);
            JinhsiSelect.Name = "JinhsiSelect";
            JinhsiSelect.Size = new Size(283, 47);
            JinhsiSelect.TabIndex = 1;
            JinhsiSelect.Text = "Jinhsi";
            JinhsiSelect.UseVisualStyleBackColor = true;
            JinhsiSelect.Click += JinhsiSelect_Click;
            // 
            // ChangliSelect
            // 
            ChangliSelect.Location = new Point(3, 152);
            ChangliSelect.Name = "ChangliSelect";
            ChangliSelect.Size = new Size(283, 43);
            ChangliSelect.TabIndex = 0;
            ChangliSelect.Text = "Changli";
            ChangliSelect.UseVisualStyleBackColor = true;
            ChangliSelect.Click += ChangliSelect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(288, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(852, 575);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1138, 579);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Changli/Reborn";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)JinhsiIconSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangliIconSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button ChangliSelect;
        private PictureBox pictureBox1;
        private Button JinhsiSelect;
        private PictureBox ChangliIconSide;
        private PictureBox JinhsiIconSide;
    }
}
