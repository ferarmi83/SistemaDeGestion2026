namespace SistemaDeGestion2026
{
    partial class FRMCliente_Buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EPNFiltrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTNAceptar = new DevComponents.DotNetBar.ButtonX();
            this.BTNAgregarPersona = new DevComponents.DotNetBar.ButtonX();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPNFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.SuspendLayout();
            // 
            // EPNFiltrar
            // 
            this.EPNFiltrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNFiltrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNFiltrar.Controls.Add(this.BTNAceptar);
            this.EPNFiltrar.Controls.Add(this.BTNAgregarPersona);
            this.EPNFiltrar.Controls.Add(this.BTNFiltrar);
            this.EPNFiltrar.Controls.Add(this.TXTFiltrar);
            this.EPNFiltrar.Controls.Add(this.IINFilas);
            this.EPNFiltrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPNFiltrar.HideControlsWhenCollapsed = true;
            this.EPNFiltrar.Location = new System.Drawing.Point(0, 0);
            this.EPNFiltrar.Name = "EPNFiltrar";
            this.EPNFiltrar.Size = new System.Drawing.Size(896, 73);
            this.EPNFiltrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNFiltrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNFiltrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNFiltrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNFiltrar.Style.GradientAngle = 90;
            this.EPNFiltrar.TabIndex = 17;
            this.EPNFiltrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNFiltrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNFiltrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNFiltrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNFiltrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNFiltrar.TitleStyle.GradientAngle = 90;
            this.EPNFiltrar.TitleText = "Filtrar";
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNAceptar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_ok;
            this.BTNAceptar.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNAceptar.Location = new System.Drawing.Point(361, 41);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(27, 26);
            this.BTNAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAceptar.TabIndex = 17;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNAgregarPersona
            // 
            this.BTNAgregarPersona.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAgregarPersona.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAgregarPersona.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNAgregarPersona.Image = global::SistemaDeGestion2026.Properties.Resources.ic_agregar;
            this.BTNAgregarPersona.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNAgregarPersona.Location = new System.Drawing.Point(328, 41);
            this.BTNAgregarPersona.Name = "BTNAgregarPersona";
            this.BTNAgregarPersona.Size = new System.Drawing.Size(27, 26);
            this.BTNAgregarPersona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAgregarPersona.TabIndex = 16;
            this.BTNAgregarPersona.Click += new System.EventHandler(this.BTNAgregarPersona_Click);
            // 
            // BTNFiltrar
            // 
            this.BTNFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNFiltrar.Image = global::SistemaDeGestion2026.Properties.Resources.ic_buscar;
            this.BTNFiltrar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNFiltrar.Location = new System.Drawing.Point(295, 41);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(27, 26);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 6;
            this.BTNFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Click);
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTFiltrar.Border.Class = "TextBoxBorder";
            this.TXTFiltrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTFiltrar.DisabledBackColor = System.Drawing.Color.White;
            this.TXTFiltrar.ForeColor = System.Drawing.Color.Black;
            this.TXTFiltrar.Location = new System.Drawing.Point(93, 41);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.PreventEnterBeep = true;
            this.TXTFiltrar.Size = new System.Drawing.Size(196, 26);
            this.TXTFiltrar.TabIndex = 5;
            this.TXTFiltrar.WatermarkText = "Datos a buscar...";
            this.TXTFiltrar.Enter += new System.EventHandler(this.TXTFiltrar_Enter);
            // 
            // IINFilas
            // 
            // 
            // 
            // 
            this.IINFilas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IINFilas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IINFilas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IINFilas.Increment = 10;
            this.IINFilas.Location = new System.Drawing.Point(6, 41);
            this.IINFilas.MaxValue = 1000;
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(80, 26);
            this.IINFilas.TabIndex = 4;
            this.IINFilas.Value = 50;
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.AllowUserToResizeColumns = false;
            this.DTGLista.AllowUserToResizeRows = false;
            this.DTGLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.DTGLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DTGLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.nit,
            this.Column4,
            this.dir});
            this.DTGLista.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.DTGLista.Location = new System.Drawing.Point(0, 73);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTGLista.RowHeadersVisible = false;
            this.DTGLista.RowHeadersWidth = 51;
            this.DTGLista.RowTemplate.Height = 30;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(896, 331);
            this.DTGLista.TabIndex = 56;
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Razon Social";
            this.Column3.MinimumWidth = 250;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // nit
            // 
            this.nit.HeaderText = "NIT";
            this.nit.MinimumWidth = 100;
            this.nit.Name = "nit";
            this.nit.ReadOnly = true;
            this.nit.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.MinimumWidth = 120;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // dir
            // 
            this.dir.HeaderText = "Direccion";
            this.dir.MinimumWidth = 400;
            this.dir.Name = "dir";
            this.dir.ReadOnly = true;
            this.dir.Width = 400;
            // 
            // FRMCliente_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 404);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.EPNFiltrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCliente_Buscar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCliente_Buscar";
            this.Load += new System.EventHandler(this.FRMCliente_Buscar_Load);
            this.EPNFiltrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel EPNFiltrar;
        private DevComponents.DotNetBar.ButtonX BTNAceptar;
        private DevComponents.DotNetBar.ButtonX BTNAgregarPersona;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
    }
}