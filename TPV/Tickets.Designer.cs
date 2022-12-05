namespace TPV
{
    partial class Tickets
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
            this.listProductos = new System.Windows.Forms.ListBox();
            this.btnAnyadirProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listProductosAnyadidos = new System.Windows.Forms.ListBox();
            this.btnCrearTicket = new System.Windows.Forms.Button();
            this.btnCancelarTicket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 15;
            this.listProductos.Location = new System.Drawing.Point(25, 22);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(148, 229);
            this.listProductos.TabIndex = 0;
            // 
            // btnAnyadirProducto
            // 
            this.btnAnyadirProducto.Location = new System.Drawing.Point(233, 93);
            this.btnAnyadirProducto.Name = "btnAnyadirProducto";
            this.btnAnyadirProducto.Size = new System.Drawing.Size(75, 53);
            this.btnAnyadirProducto.TabIndex = 2;
            this.btnAnyadirProducto.Text = "Añadir";
            this.btnAnyadirProducto.UseVisualStyleBackColor = true;
            this.btnAnyadirProducto.Click += new System.EventHandler(this.btnAnyadirProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(233, 179);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 53);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listProductos);
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 268);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listProductosAnyadidos);
            this.groupBox2.Location = new System.Drawing.Point(329, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 268);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Añadidos";
            // 
            // listProductosAnyadidos
            // 
            this.listProductosAnyadidos.FormattingEnabled = true;
            this.listProductosAnyadidos.ItemHeight = 15;
            this.listProductosAnyadidos.Location = new System.Drawing.Point(23, 22);
            this.listProductosAnyadidos.Name = "listProductosAnyadidos";
            this.listProductosAnyadidos.Size = new System.Drawing.Size(148, 229);
            this.listProductosAnyadidos.TabIndex = 7;
            // 
            // btnCrearTicket
            // 
            this.btnCrearTicket.Location = new System.Drawing.Point(448, 314);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTicket.TabIndex = 6;
            this.btnCrearTicket.Text = "Crear";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // btnCancelarTicket
            // 
            this.btnCancelarTicket.Location = new System.Drawing.Point(21, 314);
            this.btnCancelarTicket.Name = "btnCancelarTicket";
            this.btnCancelarTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTicket.TabIndex = 7;
            this.btnCancelarTicket.Text = "Cancelar";
            this.btnCancelarTicket.UseVisualStyleBackColor = true;
            this.btnCancelarTicket.Click += new System.EventHandler(this.btnCancelarTicket_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.btnCancelarTicket);
            this.Controls.Add(this.btnCrearTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAnyadirProducto);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listProductos;
        private Button btnAnyadirProducto;
        private Button btnEliminarProducto;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listProductosAnyadidos;
        private Button btnCrearTicket;
        private Button btnCancelarTicket;
    }
}