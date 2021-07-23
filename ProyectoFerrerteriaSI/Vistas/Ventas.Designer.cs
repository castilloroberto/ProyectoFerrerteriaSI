
namespace ProyectoFerrerteriaSI
{
    partial class Ventas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcantprod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelclien = new System.Windows.Forms.TextBox();
            this.txtclien = new System.Windows.Forms.TextBox();
            this.txtcodclien = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 79);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ventas ";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(560, 569);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(196, 22);
            this.txtprecio.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Precio Unitario";
            // 
            // txtcantprod
            // 
            this.txtcantprod.Location = new System.Drawing.Point(186, 569);
            this.txtcantprod.Name = "txtcantprod";
            this.txtcantprod.Size = new System.Drawing.Size(196, 22);
            this.txtcantprod.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cantidad";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(686, 618);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(125, 42);
            this.btnagregar.TabIndex = 32;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(964, 618);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 42);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "Quitar Producto";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // dgvprod
            // 
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Location = new System.Drawing.Point(79, 241);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.RowHeadersWidth = 51;
            this.dgvprod.RowTemplate.Height = 24;
            this.dgvprod.Size = new System.Drawing.Size(732, 314);
            this.dgvprod.TabIndex = 30;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(543, 200);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(268, 22);
            this.txtbusqueda.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Buscar Producto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefono ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "DNI Cliente";
            // 
            // txttelclien
            // 
            this.txttelclien.Location = new System.Drawing.Point(186, 194);
            this.txttelclien.Name = "txttelclien";
            this.txttelclien.Size = new System.Drawing.Size(247, 22);
            this.txttelclien.TabIndex = 24;
            // 
            // txtclien
            // 
            this.txtclien.Location = new System.Drawing.Point(186, 155);
            this.txtclien.Name = "txtclien";
            this.txtclien.Size = new System.Drawing.Size(247, 22);
            this.txtclien.TabIndex = 23;
            // 
            // txtcodclien
            // 
            this.txtcodclien.Location = new System.Drawing.Point(186, 111);
            this.txtcodclien.Name = "txtcodclien";
            this.txtcodclien.Size = new System.Drawing.Size(247, 22);
            this.txtcodclien.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(841, 241);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 314);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(838, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Agregado a la Venta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Terminar Venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcantprod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelclien);
            this.Controls.Add(this.txtclien);
            this.Controls.Add(this.txtcodclien);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(1174, 732);
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcantprod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelclien;
        private System.Windows.Forms.TextBox txtclien;
        private System.Windows.Forms.TextBox txtcodclien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}
