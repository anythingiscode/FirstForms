namespace WinFrm_PracticaRegistroEmpleadosJson
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.picRemouve = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picModif = new System.Windows.Forms.PictureBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellio_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picRemouve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // picRemouve
            // 
            this.picRemouve.Image = ((System.Drawing.Image)(resources.GetObject("picRemouve.Image")));
            this.picRemouve.Location = new System.Drawing.Point(843, 120);
            this.picRemouve.Name = "picRemouve";
            this.picRemouve.Size = new System.Drawing.Size(80, 80);
            this.picRemouve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemouve.TabIndex = 0;
            this.picRemouve.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(843, 19);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(80, 80);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 1;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picModif
            // 
            this.picModif.Image = ((System.Drawing.Image)(resources.GetObject("picModif.Image")));
            this.picModif.Location = new System.Drawing.Point(843, 219);
            this.picModif.Name = "picModif";
            this.picModif.Size = new System.Drawing.Size(80, 80);
            this.picModif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picModif.TabIndex = 2;
            this.picModif.TabStop = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.colNombre,
            this.colApellido_1,
            this.colApellio_2,
            this.colEdad,
            this.colEmail});
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 17);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 29;
            this.dgvEmpleados.Size = new System.Drawing.Size(799, 408);
            this.dgvEmpleados.TabIndex = 3;
            // 
            // ColId
            // 
            this.ColId.Frozen = true;
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colApellido_1
            // 
            this.colApellido_1.Frozen = true;
            this.colApellido_1.HeaderText = "Apellido 1";
            this.colApellido_1.MinimumWidth = 6;
            this.colApellido_1.Name = "colApellido_1";
            this.colApellido_1.Width = 125;
            // 
            // colApellio_2
            // 
            this.colApellio_2.Frozen = true;
            this.colApellio_2.HeaderText = "Apellido 2";
            this.colApellio_2.MinimumWidth = 6;
            this.colApellio_2.Name = "colApellio_2";
            this.colApellio_2.Width = 125;
            // 
            // colEdad
            // 
            this.colEdad.Frozen = true;
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 6;
            this.colEdad.Name = "colEdad";
            this.colEdad.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.Frozen = true;
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 200;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.picModif);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.picRemouve);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Gestión Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.picRemouve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picRemouve;
        private PictureBox picAdd;
        private PictureBox picModif;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido_1;
        private DataGridViewTextBoxColumn colApellio_2;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colEmail;
    }
}