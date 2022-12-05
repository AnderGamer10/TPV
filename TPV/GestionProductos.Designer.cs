namespace TPV
{
    partial class GestionProductos
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
            this.groupProductos = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.delTxtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modComboType = new System.Windows.Forms.ComboBox();
            this.modTxtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.modTxtNewName = new System.Windows.Forms.TextBox();
            this.modTxtImpuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.modTxtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modTxtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addComboType = new System.Windows.Forms.ComboBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.addTxtImpuesto = new System.Windows.Forms.TextBox();
            this.addTxtStock = new System.Windows.Forms.TextBox();
            this.addTxtName = new System.Windows.Forms.TextBox();
            this.addTxtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupProductos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupProductos
            // 
            this.groupProductos.Controls.Add(this.groupBox3);
            this.groupProductos.Controls.Add(this.groupBox2);
            this.groupProductos.Controls.Add(this.groupBox1);
            this.groupProductos.Controls.Add(this.listProductos);
            this.groupProductos.Location = new System.Drawing.Point(37, 35);
            this.groupProductos.Name = "groupProductos";
            this.groupProductos.Size = new System.Drawing.Size(868, 315);
            this.groupProductos.TabIndex = 3;
            this.groupProductos.TabStop = false;
            this.groupProductos.Text = "Gestion de Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.delTxtName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(654, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 244);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // delTxtName
            // 
            this.delTxtName.Enabled = false;
            this.delTxtName.Location = new System.Drawing.Point(28, 74);
            this.delTxtName.Name = "delTxtName";
            this.delTxtName.Size = new System.Drawing.Size(151, 23);
            this.delTxtName.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modComboType);
            this.groupBox2.Controls.Add(this.modTxtName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.modTxtNewName);
            this.groupBox2.Controls.Add(this.modTxtImpuesto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.modTxtStock);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.modTxtPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(425, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Producto";
            // 
            // modComboType
            // 
            this.modComboType.FormattingEnabled = true;
            this.modComboType.Items.AddRange(new object[] {
            "refrescos",
            "cervezas",
            "congelados",
            "licores",
            "picoteo",
            "varios",
            "vinos"});
            this.modComboType.Location = new System.Drawing.Point(87, 195);
            this.modComboType.Name = "modComboType";
            this.modComboType.Size = new System.Drawing.Size(112, 23);
            this.modComboType.TabIndex = 20;
            // 
            // modTxtName
            // 
            this.modTxtName.Enabled = false;
            this.modTxtName.Location = new System.Drawing.Point(87, 20);
            this.modTxtName.Name = "modTxtName";
            this.modTxtName.Size = new System.Drawing.Size(112, 23);
            this.modTxtName.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Seleccionado";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(87, 233);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // modTxtNewName
            // 
            this.modTxtNewName.Enabled = false;
            this.modTxtNewName.Location = new System.Drawing.Point(87, 58);
            this.modTxtNewName.Name = "modTxtNewName";
            this.modTxtNewName.Size = new System.Drawing.Size(112, 23);
            this.modTxtNewName.TabIndex = 17;
            // 
            // modTxtImpuesto
            // 
            this.modTxtImpuesto.Enabled = false;
            this.modTxtImpuesto.Location = new System.Drawing.Point(87, 159);
            this.modTxtImpuesto.Name = "modTxtImpuesto";
            this.modTxtImpuesto.Size = new System.Drawing.Size(112, 23);
            this.modTxtImpuesto.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre";
            // 
            // modTxtStock
            // 
            this.modTxtStock.Enabled = false;
            this.modTxtStock.Location = new System.Drawing.Point(87, 124);
            this.modTxtStock.Name = "modTxtStock";
            this.modTxtStock.Size = new System.Drawing.Size(112, 23);
            this.modTxtStock.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stock";
            // 
            // modTxtPrice
            // 
            this.modTxtPrice.Enabled = false;
            this.modTxtPrice.Location = new System.Drawing.Point(87, 91);
            this.modTxtPrice.Name = "modTxtPrice";
            this.modTxtPrice.Size = new System.Drawing.Size(112, 23);
            this.modTxtPrice.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Impuesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addComboType);
            this.groupBox1.Controls.Add(this.btnAnyadir);
            this.groupBox1.Controls.Add(this.addTxtImpuesto);
            this.groupBox1.Controls.Add(this.addTxtStock);
            this.groupBox1.Controls.Add(this.addTxtName);
            this.groupBox1.Controls.Add(this.addTxtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Producto";
            // 
            // addComboType
            // 
            this.addComboType.FormattingEnabled = true;
            this.addComboType.Items.AddRange(new object[] {
            "refrescos",
            "cervezas",
            "congelados",
            "licores",
            "picoteo",
            "varios",
            "vinos"});
            this.addComboType.Location = new System.Drawing.Point(87, 165);
            this.addComboType.Name = "addComboType";
            this.addComboType.Size = new System.Drawing.Size(112, 23);
            this.addComboType.TabIndex = 11;
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(87, 200);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(112, 23);
            this.btnAnyadir.TabIndex = 10;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // addTxtImpuesto
            // 
            this.addTxtImpuesto.Location = new System.Drawing.Point(87, 126);
            this.addTxtImpuesto.Name = "addTxtImpuesto";
            this.addTxtImpuesto.Size = new System.Drawing.Size(112, 23);
            this.addTxtImpuesto.TabIndex = 8;
            // 
            // addTxtStock
            // 
            this.addTxtStock.Location = new System.Drawing.Point(87, 91);
            this.addTxtStock.Name = "addTxtStock";
            this.addTxtStock.Size = new System.Drawing.Size(112, 23);
            this.addTxtStock.TabIndex = 7;
            // 
            // addTxtName
            // 
            this.addTxtName.Location = new System.Drawing.Point(87, 25);
            this.addTxtName.Name = "addTxtName";
            this.addTxtName.Size = new System.Drawing.Size(112, 23);
            this.addTxtName.TabIndex = 6;
            // 
            // addTxtPrice
            // 
            this.addTxtPrice.Location = new System.Drawing.Point(87, 58);
            this.addTxtPrice.Name = "addTxtPrice";
            this.addTxtPrice.Size = new System.Drawing.Size(112, 23);
            this.addTxtPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 15;
            this.listProductos.Location = new System.Drawing.Point(6, 31);
            this.listProductos.Name = "listProductos";
            this.listProductos.ScrollAlwaysVisible = true;
            this.listProductos.Size = new System.Drawing.Size(171, 244);
            this.listProductos.TabIndex = 0;
            this.listProductos.SelectedIndexChanged += new System.EventHandler(this.listProductos_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(767, 356);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(123, 60);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 433);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupProductos);
            this.Name = "GestionProductos";
            this.Text = "GestionProductos";
            this.Load += new System.EventHandler(this.GestionProductos_Load);
            this.groupProductos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupProductos;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private TextBox delTxtName;
        private Label label11;
        private GroupBox groupBox2;
        private Button btnModificar;
        private TextBox modTxtNewName;
        private TextBox modTxtImpuesto;
        private Label label10;
        private TextBox modTxtStock;
        private Label label9;
        private Label label8;
        private TextBox modTxtPrice;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnAnyadir;
        private TextBox addTxtImpuesto;
        private TextBox addTxtStock;
        private TextBox addTxtName;
        private TextBox addTxtPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listProductos;
        private Button btnVolver;
        private TextBox modTxtName;
        private Label label13;
        private ComboBox modComboType;
        private ComboBox addComboType;
    }
}