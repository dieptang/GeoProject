namespace GeoProject
{
    partial class AutocompleteAddressControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StrNum = new System.Windows.Forms.TextBox();
            this.StrAddress = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoComplete = new CustomCompleteTextBox.CustomCompleteTextBox();
          //  this.radAutoCompleteBox = new Telerik.WinControls.UI.RadAutoCompleteBox();
           // ((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StrNum
            // 
            this.StrNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrNum.Location = new System.Drawing.Point(115, 38);
            this.StrNum.Name = "StrNum";
            this.StrNum.Size = new System.Drawing.Size(115, 25);
            this.StrNum.TabIndex = 0;
            // 
            // StrAddress
            // 
            this.StrAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrAddress.Location = new System.Drawing.Point(236, 38);
            this.StrAddress.Name = "StrAddress";
            this.StrAddress.Size = new System.Drawing.Size(302, 25);
            this.StrAddress.TabIndex = 1;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(115, 69);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(423, 25);
            this.City.TabIndex = 2;
            // 
            // State
            // 
            this.State.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(115, 100);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(115, 25);
            this.State.TabIndex = 3;
            // 
            // ZipCode
            // 
            this.ZipCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCode.Location = new System.Drawing.Point(432, 100);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(106, 25);
            this.ZipCode.TabIndex = 4;
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(115, 131);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(423, 25);
            this.Country.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Street address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zip code";
            // 
            // AutoComplete
            // 
            this.AutoComplete.AutoDropWidth = true;
            this.AutoComplete.DisplayMember = "";
            this.AutoComplete.DropDownMinCharLength = 1;
            this.AutoComplete.DropDownOnEnter = false;
            this.AutoComplete.DropHeight = 100;
            this.AutoComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoComplete.ItemFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoComplete.ItemForeColor = System.Drawing.SystemColors.WindowText;
            this.AutoComplete.Location = new System.Drawing.Point(21, 7);
            this.AutoComplete.Name = "AutoComplete";
            this.AutoComplete.PreviousSelectedItem = null;
            this.AutoComplete.SelectedItem = null;
            this.AutoComplete.SelectedValue = null;
            this.AutoComplete.Size = new System.Drawing.Size(517, 25);
            this.AutoComplete.TabIndex = 12;
            this.AutoComplete.ValueMember = "";
            this.AutoComplete.Visible = false;
            // 
            // radAutoCompleteBox
            // 
            //this.radAutoCompleteBox.EnableGestures = false;
            //this.radAutoCompleteBox.EnableTheming = false;
            //this.radAutoCompleteBox.Location = new System.Drawing.Point(21, 7);
            //this.radAutoCompleteBox.MaxDropDownItemCount = 10;
            //this.radAutoCompleteBox.Name = "radAutoCompleteBox";
            //this.radAutoCompleteBox.Size = new System.Drawing.Size(516, 26);
            //this.radAutoCompleteBox.TabIndex = 13;
            //this.radAutoCompleteBox.TextChanged += new System.EventHandler(this.radAutoCompleteBox_TextChanged_1);
            //this.radAutoCompleteBox.Leave += new System.EventHandler(this.radAutoCompleteBox_Leave);
            // 
            // AutocompleteAddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          //this.Controls.Add(this.radAutoCompleteBox);
            this.Controls.Add(this.AutoComplete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.ZipCode);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.StrAddress);
            this.Controls.Add(this.StrNum);
            this.Name = "AutocompleteAddressControl";
            this.Size = new System.Drawing.Size(554, 230);
            //((System.ComponentModel.ISupportInitialize)(this.radAutoCompleteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StrNum;
        private System.Windows.Forms.TextBox StrAddress;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.TextBox ZipCode;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomCompleteTextBox.CustomCompleteTextBox AutoComplete;
    }
}
