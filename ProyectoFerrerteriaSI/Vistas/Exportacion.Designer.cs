
namespace ProyectoFerrerteriaSI.Vistas
{
    partial class Exportacion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.cb_tabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(117, 269);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 51;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(957, 430);
            this.dgv_datos.TabIndex = 0;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(935, 722);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(139, 47);
            this.btn_exportar.TabIndex = 1;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // cb_tabla
            // 
            this.cb_tabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tabla.FormattingEnabled = true;
            this.cb_tabla.Items.AddRange(new object[] {
            "Ventas",
            "Inventario",
            "Clientes",
            "Empleados"});
            this.cb_tabla.Location = new System.Drawing.Point(859, 217);
            this.cb_tabla.Name = "cb_tabla";
            this.cb_tabla.Size = new System.Drawing.Size(215, 24);
            this.cb_tabla.TabIndex = 2;
            this.cb_tabla.SelectionChangeCommitted += new System.EventHandler(this.cb_tabla_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos a Exportar";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(307, 733);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 22);
            this.dtp_inicio.TabIndex = 4;
            this.dtp_inicio.Visible = false;
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.dtp_inicio_ValueChanged);
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(621, 733);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(200, 22);
            this.dtp_fin.TabIndex = 5;
            this.dtp_fin.Visible = false;
            this.dtp_fin.ValueChanged += new System.EventHandler(this.dtp_fin_ValueChanged);
            // 
            // Exportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tabla);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.dgv_datos);
            this.Name = "Exportacion";
            this.Size = new System.Drawing.Size(1262, 872);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.ComboBox cb_tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fin;
    }
}
