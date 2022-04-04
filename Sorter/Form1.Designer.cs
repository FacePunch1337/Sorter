namespace Sorter
{
    partial class Sort
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
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.listboxConsole = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.Plum;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSort.ForeColor = System.Drawing.Color.Indigo;
            this.buttonSort.Location = new System.Drawing.Point(12, 365);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(344, 73);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "навести порядок";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.White;
            this.labelDisplay.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDisplay.ForeColor = System.Drawing.Color.Crimson;
            this.labelDisplay.Location = new System.Drawing.Point(12, 9);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(344, 72);
            this.labelDisplay.TabIndex = 2;
            this.labelDisplay.Text = "НЕ ПРОВЕРЕНО";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listboxConsole
            // 
            this.listboxConsole.FormattingEnabled = true;
            this.listboxConsole.ItemHeight = 20;
            this.listboxConsole.Location = new System.Drawing.Point(12, 98);
            this.listboxConsole.Name = "listboxConsole";
            this.listboxConsole.Size = new System.Drawing.Size(344, 244);
            this.listboxConsole.TabIndex = 3;
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.listboxConsole);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.buttonSort);
            this.Name = "Sort";
            this.Text = "Sort";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.ListBox listboxConsole;
    }
}
