namespace General.GUI
{
    partial class SolicitantesEdicion
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
            this.components = new System.ComponentModel.Container();
            this.dTFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIDsolicitante = new System.Windows.Forms.TextBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtID_Direccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTFecha
            // 
            this.dTFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dTFecha.Location = new System.Drawing.Point(224, 285);
            this.dTFecha.Name = "dTFecha";
            this.dTFecha.Size = new System.Drawing.Size(252, 34);
            this.dTFecha.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "ID : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(87, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Destinatario:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(127, 337);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 25);
            this.label17.TabIndex = 19;
            this.label17.Text = "Detalle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(136, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 25);
            this.label18.TabIndex = 23;
            this.label18.Text = "Fecha:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(146, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 25);
            this.label19.TabIndex = 22;
            this.label19.Text = "Area:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(101, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Solicitante:";
            // 
            // txtIDsolicitante
            // 
            this.txtIDsolicitante.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIDsolicitante.Location = new System.Drawing.Point(225, 35);
            this.txtIDsolicitante.Name = "txtIDsolicitante";
            this.txtIDsolicitante.ReadOnly = true;
            this.txtIDsolicitante.Size = new System.Drawing.Size(78, 34);
            this.txtIDsolicitante.TabIndex = 30;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSolicitante.Location = new System.Drawing.Point(224, 84);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(252, 34);
            this.txtSolicitante.TabIndex = 31;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtArea.Location = new System.Drawing.Point(225, 136);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(251, 34);
            this.txtArea.TabIndex = 32;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDestinatario.Location = new System.Drawing.Point(225, 186);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(251, 34);
            this.txtDestinatario.TabIndex = 34;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDetalle.Location = new System.Drawing.Point(222, 331);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(172, 34);
            this.txtDetalle.TabIndex = 35;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(134, 436);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 48);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(373, 436);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 48);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Cancelar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // notificador
            // 
            this.notificador.ContainerControl = this;
            // 
            // txtID_Direccion
            // 
            this.txtID_Direccion.Location = new System.Drawing.Point(893, 481);
            this.txtID_Direccion.Name = "txtID_Direccion";
            this.txtID_Direccion.Size = new System.Drawing.Size(38, 22);
            this.txtID_Direccion.TabIndex = 51;
            this.txtID_Direccion.VisibleChanged += new System.EventHandler(this.EmpleadosEdicion_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEquipo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtDetalle);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtDestinatario);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.txtSolicitante);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtIDsolicitante);
            this.panel1.Controls.Add(this.dTFecha);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 523);
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Equipo:";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEquipo.Location = new System.Drawing.Point(224, 235);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(172, 34);
            this.txtEquipo.TabIndex = 49;
            // 
            // EmpleadosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID_Direccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EmpleadosEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider notificador;
        public System.Windows.Forms.DateTimePicker dTFecha;
        public System.Windows.Forms.TextBox txtIDsolicitante;
        public System.Windows.Forms.TextBox txtSolicitante;
        public System.Windows.Forms.TextBox txtArea;
        public System.Windows.Forms.TextBox txtDestinatario;
        public System.Windows.Forms.TextBox txtDetalle;
        public System.Windows.Forms.TextBox txtID_Direccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEquipo;
    }
}