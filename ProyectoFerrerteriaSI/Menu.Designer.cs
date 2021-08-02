
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_integrantes = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.btn_integrantes);
            this.panel1.Controls.Add(this.btn_excel);
            this.panel1.Controls.Add(this.btn_historial);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 730);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "La Esperanza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ferreteria";
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(90, 183);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(135, 52);
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Crimson;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(90, 650);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(135, 52);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Cerrar Sesion";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_integrantes
            // 
            this.btn_integrantes.Location = new System.Drawing.Point(90, 536);
            this.btn_integrantes.Name = "btn_integrantes";
            this.btn_integrantes.Size = new System.Drawing.Size(135, 52);
            this.btn_integrantes.TabIndex = 0;
            this.btn_integrantes.Text = "Integrantes";
            this.btn_integrantes.UseVisualStyleBackColor = true;
            this.btn_integrantes.Click += new System.EventHandler(this.btn_integrantes_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(90, 392);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(135, 52);
            this.btn_excel.TabIndex = 0;
            this.btn_excel.Text = "Exportacion a excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_historial
            // 
            this.btn_historial.Location = new System.Drawing.Point(90, 321);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(135, 52);
            this.btn_historial.TabIndex = 0;
            this.btn_historial.Text = "Historial de Ventas";
            this.btn_historial.UseVisualStyleBackColor = true;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(90, 254);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_historial;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_integrantes;
    }
}