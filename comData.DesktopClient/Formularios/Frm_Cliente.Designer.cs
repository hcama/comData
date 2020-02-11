namespace comData.DesktopClient.Formularios
{
    partial class Frm_Cliente
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellidopaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellidomaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.ibtn_agregarCliente = new FontAwesome.Sharp.IconButton();
            this.ib_ModificarCliente = new FontAwesome.Sharp.IconButton();
            this.ibtn_EliminarCliente = new FontAwesome.Sharp.IconButton();
            this.ib_guardarCliente = new FontAwesome.Sharp.IconButton();
            this.lbl_idCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(176, 111);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(316, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido paterno";
            // 
            // txt_apellidopaterno
            // 
            this.txt_apellidopaterno.Location = new System.Drawing.Point(176, 137);
            this.txt_apellidopaterno.Name = "txt_apellidopaterno";
            this.txt_apellidopaterno.Size = new System.Drawing.Size(316, 20);
            this.txt_apellidopaterno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido materno";
            // 
            // txt_apellidomaterno
            // 
            this.txt_apellidomaterno.Location = new System.Drawing.Point(176, 163);
            this.txt_apellidomaterno.Name = "txt_apellidomaterno";
            this.txt_apellidomaterno.Size = new System.Drawing.Size(316, 20);
            this.txt_apellidomaterno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(176, 192);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(96, 20);
            this.dtp_fechaNacimiento.TabIndex = 8;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(26, 256);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(569, 226);
            this.dgv_clientes.TabIndex = 10;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            // 
            // ibtn_agregarCliente
            // 
            this.ibtn_agregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_agregarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_agregarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibtn_agregarCliente.IconColor = System.Drawing.Color.Black;
            this.ibtn_agregarCliente.IconSize = 24;
            this.ibtn_agregarCliente.Location = new System.Drawing.Point(41, 24);
            this.ibtn_agregarCliente.Name = "ibtn_agregarCliente";
            this.ibtn_agregarCliente.Rotation = 0D;
            this.ibtn_agregarCliente.Size = new System.Drawing.Size(75, 46);
            this.ibtn_agregarCliente.TabIndex = 13;
            this.ibtn_agregarCliente.TabStop = false;
            this.ibtn_agregarCliente.UseVisualStyleBackColor = true;
            this.ibtn_agregarCliente.Click += new System.EventHandler(this.ibtn_agregarCliente_Click);
            // 
            // ib_ModificarCliente
            // 
            this.ib_ModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.ib_ModificarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ib_ModificarCliente.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ib_ModificarCliente.IconColor = System.Drawing.Color.Black;
            this.ib_ModificarCliente.IconSize = 24;
            this.ib_ModificarCliente.Location = new System.Drawing.Point(122, 24);
            this.ib_ModificarCliente.Name = "ib_ModificarCliente";
            this.ib_ModificarCliente.Rotation = 0D;
            this.ib_ModificarCliente.Size = new System.Drawing.Size(75, 46);
            this.ib_ModificarCliente.TabIndex = 14;
            this.ib_ModificarCliente.TabStop = false;
            this.ib_ModificarCliente.UseVisualStyleBackColor = true;
            this.ib_ModificarCliente.Click += new System.EventHandler(this.ib_ModificarCliente_Click);
            // 
            // ibtn_EliminarCliente
            // 
            this.ibtn_EliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_EliminarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_EliminarCliente.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.ibtn_EliminarCliente.IconColor = System.Drawing.Color.Black;
            this.ibtn_EliminarCliente.IconSize = 24;
            this.ibtn_EliminarCliente.Location = new System.Drawing.Point(203, 24);
            this.ibtn_EliminarCliente.Name = "ibtn_EliminarCliente";
            this.ibtn_EliminarCliente.Rotation = 0D;
            this.ibtn_EliminarCliente.Size = new System.Drawing.Size(75, 46);
            this.ibtn_EliminarCliente.TabIndex = 15;
            this.ibtn_EliminarCliente.TabStop = false;
            this.ibtn_EliminarCliente.UseVisualStyleBackColor = true;
            this.ibtn_EliminarCliente.Click += new System.EventHandler(this.ibtn_EliminarCliente_Click);
            // 
            // ib_guardarCliente
            // 
            this.ib_guardarCliente.BackColor = System.Drawing.Color.Transparent;
            this.ib_guardarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ib_guardarCliente.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ib_guardarCliente.IconColor = System.Drawing.Color.Black;
            this.ib_guardarCliente.IconSize = 24;
            this.ib_guardarCliente.Location = new System.Drawing.Point(284, 24);
            this.ib_guardarCliente.Name = "ib_guardarCliente";
            this.ib_guardarCliente.Rotation = 0D;
            this.ib_guardarCliente.Size = new System.Drawing.Size(75, 46);
            this.ib_guardarCliente.TabIndex = 16;
            this.ib_guardarCliente.TabStop = false;
            this.ib_guardarCliente.UseVisualStyleBackColor = true;
            this.ib_guardarCliente.Click += new System.EventHandler(this.ib_guardarCliente_Click);
            // 
            // lbl_idCliente
            // 
            this.lbl_idCliente.AutoSize = true;
            this.lbl_idCliente.Location = new System.Drawing.Point(310, 192);
            this.lbl_idCliente.Name = "lbl_idCliente";
            this.lbl_idCliente.Size = new System.Drawing.Size(15, 13);
            this.lbl_idCliente.TabIndex = 17;
            this.lbl_idCliente.Text = "id";
            this.lbl_idCliente.Visible = false;
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 614);
            this.Controls.Add(this.lbl_idCliente);
            this.Controls.Add(this.ib_guardarCliente);
            this.Controls.Add(this.ibtn_EliminarCliente);
            this.Controls.Add(this.ib_ModificarCliente);
            this.Controls.Add(this.ibtn_agregarCliente);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellidomaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apellidopaterno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Frm_Cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellidopaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellidomaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private FontAwesome.Sharp.IconButton ibtn_agregarCliente;
        private FontAwesome.Sharp.IconButton ib_ModificarCliente;
        private FontAwesome.Sharp.IconButton ibtn_EliminarCliente;
        private FontAwesome.Sharp.IconButton ib_guardarCliente;
        private System.Windows.Forms.Label lbl_idCliente;
    }
}