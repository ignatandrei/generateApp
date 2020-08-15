namespace TestWindowsForms
{
    partial class frmStart
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
            this.btnNameTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNameTable
            // 
            this.btnNameTable.Location = new System.Drawing.Point(12, 23);
            this.btnNameTable.Name = "btnNameTable";
            this.btnNameTable.Size = new System.Drawing.Size(150, 46);
            this.btnNameTable.TabIndex = 0;
            this.btnNameTable.Text = "@(nameTable)";
            this.btnNameTable.UseVisualStyleBackColor = true;
            this.btnNameTable.Click += new System.EventHandler(this.btnNameTable_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 676);
            this.Controls.Add(this.btnNameTable);
            this.Name = "frmStart";
            this.Text = "Start Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNameTable;
    }
}

