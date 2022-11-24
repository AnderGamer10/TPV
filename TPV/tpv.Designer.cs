namespace TPV
{
    partial class tpv
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
            this.itemsProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // itemsProductos
            // 
            this.itemsProductos.FormattingEnabled = true;
            this.itemsProductos.ItemHeight = 15;
            this.itemsProductos.Location = new System.Drawing.Point(122, 354);
            this.itemsProductos.Name = "itemsProductos";
            this.itemsProductos.ScrollAlwaysVisible = true;
            this.itemsProductos.Size = new System.Drawing.Size(185, 259);
            this.itemsProductos.TabIndex = 0;
            // 
            // tpv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 606);
            this.Controls.Add(this.itemsProductos);
            this.Name = "tpv";
            this.Text = "tpv";
            this.Load += new System.EventHandler(this.tpv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox itemsProductos;
    }
}