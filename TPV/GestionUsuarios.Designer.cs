namespace TPV
{
    partial class GestionUsuarios
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
            this.groupUsuarios = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.delTxtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.modTxtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.modTxtPasswd = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addComboRol = new System.Windows.Forms.ComboBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.addTxtName = new System.Windows.Forms.TextBox();
            this.addTxtPasswd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.modComboRol = new System.Windows.Forms.ComboBox();
            this.groupUsuarios.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUsuarios
            // 
            this.groupUsuarios.Controls.Add(this.groupBox4);
            this.groupUsuarios.Controls.Add(this.listUsuarios);
            this.groupUsuarios.Controls.Add(this.groupBox5);
            this.groupUsuarios.Controls.Add(this.groupBox6);
            this.groupUsuarios.Location = new System.Drawing.Point(32, 43);
            this.groupUsuarios.Name = "groupUsuarios";
            this.groupUsuarios.Size = new System.Drawing.Size(868, 266);
            this.groupUsuarios.TabIndex = 4;
            this.groupUsuarios.TabStop = false;
            this.groupUsuarios.Text = "Gestion de Usuarios";
            this.groupUsuarios.Enter += new System.EventHandler(this.groupUsuarios_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.delTxtName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(654, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 173);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eliminar Usuario";
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
            this.delTxtName.Location = new System.Drawing.Point(28, 74);
            this.delTxtName.Name = "delTxtName";
            this.delTxtName.Size = new System.Drawing.Size(151, 23);
            this.delTxtName.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nombre";
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.ItemHeight = 15;
            this.listUsuarios.Location = new System.Drawing.Point(6, 31);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.ScrollAlwaysVisible = true;
            this.listUsuarios.Size = new System.Drawing.Size(171, 229);
            this.listUsuarios.TabIndex = 0;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.modComboRol);
            this.groupBox5.Controls.Add(this.btnModificar);
            this.groupBox5.Controls.Add(this.modTxtName);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.modTxtPasswd);
            this.groupBox5.Location = new System.Drawing.Point(425, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 173);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modificar Usuario";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(87, 126);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // modTxtName
            // 
            this.modTxtName.Location = new System.Drawing.Point(87, 25);
            this.modTxtName.Name = "modTxtName";
            this.modTxtName.Size = new System.Drawing.Size(112, 23);
            this.modTxtName.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Rol";
            // 
            // modTxtPasswd
            // 
            this.modTxtPasswd.Enabled = false;
            this.modTxtPasswd.Location = new System.Drawing.Point(87, 58);
            this.modTxtPasswd.Name = "modTxtPasswd";
            this.modTxtPasswd.Size = new System.Drawing.Size(112, 23);
            this.modTxtPasswd.TabIndex = 16;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.addComboRol);
            this.groupBox6.Controls.Add(this.btnAnadir);
            this.groupBox6.Controls.Add(this.addTxtName);
            this.groupBox6.Controls.Add(this.addTxtPasswd);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(197, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 173);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Añadir Usuario";
            // 
            // addComboRol
            // 
            this.addComboRol.FormattingEnabled = true;
            this.addComboRol.Items.AddRange(new object[] {
            "administrator",
            "user"});
            this.addComboRol.Location = new System.Drawing.Point(87, 94);
            this.addComboRol.Name = "addComboRol";
            this.addComboRol.Size = new System.Drawing.Size(112, 23);
            this.addComboRol.TabIndex = 6;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(87, 126);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(112, 23);
            this.btnAnadir.TabIndex = 10;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // addTxtName
            // 
            this.addTxtName.Location = new System.Drawing.Point(87, 25);
            this.addTxtName.Name = "addTxtName";
            this.addTxtName.Size = new System.Drawing.Size(112, 23);
            this.addTxtName.TabIndex = 6;
            // 
            // addTxtPasswd
            // 
            this.addTxtPasswd.Location = new System.Drawing.Point(87, 58);
            this.addTxtPasswd.Name = "addTxtPasswd";
            this.addTxtPasswd.Size = new System.Drawing.Size(112, 23);
            this.addTxtPasswd.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Rol";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Contraseña";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Nombre";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(762, 315);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(123, 60);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // modComboRol
            // 
            this.modComboRol.FormattingEnabled = true;
            this.modComboRol.Items.AddRange(new object[] {
            "administrator",
            "user"});
            this.modComboRol.Location = new System.Drawing.Point(87, 91);
            this.modComboRol.Name = "modComboRol";
            this.modComboRol.Size = new System.Drawing.Size(112, 23);
            this.modComboRol.TabIndex = 11;
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 386);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupUsuarios);
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            this.groupUsuarios.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupUsuarios;
        private GroupBox groupBox4;
        private Button btnEliminar;
        private TextBox delTxtName;
        private Label label12;
        private ListBox listUsuarios;
        private GroupBox groupBox5;
        private Button btnModificar;
        private TextBox modTxtName;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox modTxtPasswd;
        private GroupBox groupBox6;
        private Button btnAnadir;
        private TextBox addTxtName;
        private TextBox addTxtPasswd;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button btnVolver;
        private ComboBox addComboRol;
        private ComboBox modComboRol;
    }
}