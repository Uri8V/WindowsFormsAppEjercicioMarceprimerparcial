
namespace WindowsFormsAppEjercicioMarceprimerparcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.LadoCTextBox = new System.Windows.Forms.TextBox();
            this.LadoBTextBox = new System.Windows.Forms.TextBox();
            this.LadoATextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TriangulosDataGridView = new System.Windows.Forms.DataGridView();
            this.colLadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriangulosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BorrarButton);
            this.splitContainer1.Panel1.Controls.Add(this.CancelarButton);
            this.splitContainer1.Panel1.Controls.Add(this.ConfirmarButton);
            this.splitContainer1.Panel1.Controls.Add(this.SalirButton);
            this.splitContainer1.Panel1.Controls.Add(this.LadoCTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.LadoBTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.LadoATextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TriangulosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(882, 345);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // BorrarButton
            // 
            this.BorrarButton.Location = new System.Drawing.Point(65, 222);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(75, 23);
            this.BorrarButton.TabIndex = 7;
            this.BorrarButton.Text = "Borrar Grilla";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(113, 140);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(19, 141);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarButton.TabIndex = 5;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(13, 310);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 4;
            this.SalirButton.Text = "SALIR";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // LadoCTextBox
            // 
            this.LadoCTextBox.Location = new System.Drawing.Point(113, 92);
            this.LadoCTextBox.Name = "LadoCTextBox";
            this.LadoCTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoCTextBox.TabIndex = 3;
            // 
            // LadoBTextBox
            // 
            this.LadoBTextBox.Location = new System.Drawing.Point(113, 61);
            this.LadoBTextBox.Name = "LadoBTextBox";
            this.LadoBTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoBTextBox.TabIndex = 3;
            // 
            // LadoATextBox
            // 
            this.LadoATextBox.Location = new System.Drawing.Point(113, 35);
            this.LadoATextBox.Name = "LadoATextBox";
            this.LadoATextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoATextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el Lado C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el Lado B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Lado A:";
            // 
            // TriangulosDataGridView
            // 
            this.TriangulosDataGridView.AllowUserToAddRows = false;
            this.TriangulosDataGridView.AllowUserToDeleteRows = false;
            this.TriangulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TriangulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadoA,
            this.colLadoB,
            this.colLadoC,
            this.colPerimetro,
            this.colSuperficie,
            this.colTipo});
            this.TriangulosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TriangulosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TriangulosDataGridView.Name = "TriangulosDataGridView";
            this.TriangulosDataGridView.ReadOnly = true;
            this.TriangulosDataGridView.Size = new System.Drawing.Size(649, 345);
            this.TriangulosDataGridView.TabIndex = 0;
            // 
            // colLadoA
            // 
            this.colLadoA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoA.HeaderText = "Lado A";
            this.colLadoA.Name = "colLadoA";
            this.colLadoA.ReadOnly = true;
            // 
            // colLadoB
            // 
            this.colLadoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoB.HeaderText = "Lado B";
            this.colLadoB.Name = "colLadoB";
            this.colLadoB.ReadOnly = true;
            // 
            // colLadoC
            // 
            this.colLadoC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoC.HeaderText = "Lado C";
            this.colLadoC.Name = "colLadoC";
            this.colLadoC.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // colSuperficie
            // 
            this.colSuperficie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuperficie.HeaderText = "Superficie";
            this.colSuperficie.Name = "colSuperficie";
            this.colSuperficie.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo de Triángulo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 345);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(898, 384);
            this.MinimumSize = new System.Drawing.Size(898, 384);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Triángulos";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TriangulosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.TextBox LadoCTextBox;
        private System.Windows.Forms.TextBox LadoBTextBox;
        private System.Windows.Forms.TextBox LadoATextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TriangulosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
    }
}

