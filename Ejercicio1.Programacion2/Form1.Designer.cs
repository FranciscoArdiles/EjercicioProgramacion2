
namespace Ejercicio1.Programacion2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.numdia = new System.Windows.Forms.NumericUpDown();
            this.numanio = new System.Windows.Forms.NumericUpDown();
            this.nummes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numdia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numanio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DÍA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "MES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "AÑO";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(0, 293);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(156, 25);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "RESULTADO:";
            this.lblResult.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(162, 293);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(172, 25);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "fecha completa";
            this.lblFecha.Visible = false;
            // 
            // numdia
            // 
            this.numdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdia.Location = new System.Drawing.Point(92, 144);
            this.numdia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numdia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numdia.Name = "numdia";
            this.numdia.Size = new System.Drawing.Size(99, 29);
            this.numdia.TabIndex = 10;
            this.numdia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numanio
            // 
            this.numanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numanio.Location = new System.Drawing.Point(342, 144);
            this.numanio.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numanio.Name = "numanio";
            this.numanio.Size = new System.Drawing.Size(99, 29);
            this.numanio.TabIndex = 11;
            this.numanio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nummes
            // 
            this.nummes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummes.Location = new System.Drawing.Point(221, 144);
            this.nummes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nummes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nummes.Name = "nummes";
            this.nummes.Size = new System.Drawing.Size(99, 29);
            this.nummes.TabIndex = 12;
            this.nummes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(115, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ejercicio de Programacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nummes);
            this.Controls.Add(this.numanio);
            this.Controls.Add(this.numdia);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numdia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numanio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown numdia;
        private System.Windows.Forms.NumericUpDown numanio;
        private System.Windows.Forms.NumericUpDown nummes;
        private System.Windows.Forms.Label label4;
    }
}

