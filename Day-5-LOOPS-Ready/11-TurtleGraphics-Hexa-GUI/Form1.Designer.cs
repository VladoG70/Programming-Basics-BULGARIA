namespace _11_TurtleGraphics_Hexa_GUI
    {
    partial class FormTurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.buttonHexagon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(13, 13);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(107, 43);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.ForeColor = System.Drawing.Color.Red;
            this.buttonReset.Location = new System.Drawing.Point(13, 70);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(107, 36);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(13, 117);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(107, 34);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // buttonHexagon
            // 
            this.buttonHexagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexagon.ForeColor = System.Drawing.Color.Blue;
            this.buttonHexagon.Location = new System.Drawing.Point(12, 166);
            this.buttonHexagon.Name = "buttonHexagon";
            this.buttonHexagon.Size = new System.Drawing.Size(108, 40);
            this.buttonHexagon.TabIndex = 3;
            this.buttonHexagon.Text = "Hexagon";
            this.buttonHexagon.UseVisualStyleBackColor = true;
            this.buttonHexagon.Click += new System.EventHandler(this.buttonHexagon_Click);
            // 
            // FormTurtleGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 356);
            this.Controls.Add(this.buttonHexagon);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "FormTurtleGraphics";
            this.Text = "Turtle Graphics - Example";
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button buttonHexagon;
        }
    }

