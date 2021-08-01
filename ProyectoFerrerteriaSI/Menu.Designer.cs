
namespace ProyectoFerrerteriaSI
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Controls.Add(this.btn_historial);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(90, 150);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(135, 52);
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_historial
            // 
            this.btn_historial.Location = new System.Drawing.Point(90, 361);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(135, 52);
            this.btn_historial.TabIndex = 0;
            this.btn_historial.Text = "Historial de Ventas";
            this.btn_historial.UseVisualStyleBackColor = true;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(90, 258);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(135, 52);
            this.btn_inventario.TabIndex = 0;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(311, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(915, 730);
            this.main_panel.TabIndex = 1;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(1226, 730);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_historial;
    }
}