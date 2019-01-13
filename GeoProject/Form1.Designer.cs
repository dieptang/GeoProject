namespace GeoProject
{
    partial class Form1
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
            this.autocompleteAddressControl1 = new GeoProject.AutocompleteAddressControl();
            this.SuspendLayout();
            // 
            // autocompleteAddressControl1
            // 
            this.autocompleteAddressControl1.Location = new System.Drawing.Point(10, 12);
            this.autocompleteAddressControl1.Name = "autocompleteAddressControl1";
            this.autocompleteAddressControl1.Size = new System.Drawing.Size(554, 222);
            this.autocompleteAddressControl1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 246);
            this.Controls.Add(this.autocompleteAddressControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AutocompleteAddressControl autocompleteAddressControl1;
    }
}

