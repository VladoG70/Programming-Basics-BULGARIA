namespace _15_CatchTheButton
    {
    partial class FormCatch
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
            this.buttonCatchMe = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCatchMe
            // 
            this.buttonCatchMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCatchMe.Location = new System.Drawing.Point(72, 69);
            this.buttonCatchMe.Name = "buttonCatchMe";
            this.buttonCatchMe.Size = new System.Drawing.Size(195, 136);
            this.buttonCatchMe.TabIndex = 0;
            this.buttonCatchMe.Text = "Catch Me!";
            this.buttonCatchMe.UseVisualStyleBackColor = true;
            this.buttonCatchMe.Click += new System.EventHandler(this.buttonCatchMe_Click);
            this.buttonCatchMe.MouseEnter += new System.EventHandler(this.buttonCatchMe_MouseEnter);
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(166, 270);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(260, 58);
            this.labelResult.TabIndex = 1;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCatch
            // 
            this.ClientSize = new System.Drawing.Size(602, 337);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCatchMe);
            this.Name = "FormCatch";
            this.Text = "Catch the Button!";
            this.ResumeLayout(false);

            }


        #endregion

        private System.Windows.Forms.Button buttonCatchMe;
        private System.Windows.Forms.Label labelResult;
        }
    }

