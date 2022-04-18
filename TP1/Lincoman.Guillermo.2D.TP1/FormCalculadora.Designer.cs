namespace Lincoman.Guillermo._2D.TP1
{
    partial class FormCalculadora
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
            this.TbxNumUno = new System.Windows.Forms.TextBox();
            this.LsbResultadosOperacion = new System.Windows.Forms.ListBox();
            this.TbxNumDos = new System.Windows.Forms.TextBox();
            this.CbOperadores = new System.Windows.Forms.ComboBox();
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConvertirBinario = new System.Windows.Forms.Button();
            this.BtnConvertirDecimal = new System.Windows.Forms.Button();
            this.LbResultadoNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxNumUno
            // 
            this.TbxNumUno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxNumUno.Location = new System.Drawing.Point(11, 89);
            this.TbxNumUno.Name = "TbxNumUno";
            this.TbxNumUno.Size = new System.Drawing.Size(159, 43);
            this.TbxNumUno.TabIndex = 1;
            // 
            // LsbResultadosOperacion
            // 
            this.LsbResultadosOperacion.FormattingEnabled = true;
            this.LsbResultadosOperacion.ItemHeight = 15;
            this.LsbResultadosOperacion.Location = new System.Drawing.Point(491, 25);
            this.LsbResultadosOperacion.Name = "LsbResultadosOperacion";
            this.LsbResultadosOperacion.Size = new System.Drawing.Size(282, 319);
            this.LsbResultadosOperacion.TabIndex = 2;
            // 
            // TbxNumDos
            // 
            this.TbxNumDos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxNumDos.Location = new System.Drawing.Point(303, 89);
            this.TbxNumDos.Name = "TbxNumDos";
            this.TbxNumDos.Size = new System.Drawing.Size(159, 43);
            this.TbxNumDos.TabIndex = 3;
            // 
            // CbOperadores
            // 
            this.CbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbOperadores.FormattingEnabled = true;
            this.CbOperadores.Location = new System.Drawing.Point(176, 89);
            this.CbOperadores.Name = "CbOperadores";
            this.CbOperadores.Size = new System.Drawing.Size(121, 43);
            this.CbOperadores.TabIndex = 2;
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(12, 152);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(144, 46);
            this.BtnOperar.TabIndex = 4;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(165, 152);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(144, 46);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(319, 152);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(144, 46);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConvertirBinario
            // 
            this.BtnConvertirBinario.Location = new System.Drawing.Point(12, 216);
            this.BtnConvertirBinario.Name = "BtnConvertirBinario";
            this.BtnConvertirBinario.Size = new System.Drawing.Size(218, 46);
            this.BtnConvertirBinario.TabIndex = 7;
            this.BtnConvertirBinario.Text = "Convertir a Binario";
            this.BtnConvertirBinario.UseVisualStyleBackColor = true;
            this.BtnConvertirBinario.Click += new System.EventHandler(this.BtnConvertirBinario_Click);
            // 
            // BtnConvertirDecimal
            // 
            this.BtnConvertirDecimal.Location = new System.Drawing.Point(236, 216);
            this.BtnConvertirDecimal.Name = "BtnConvertirDecimal";
            this.BtnConvertirDecimal.Size = new System.Drawing.Size(226, 46);
            this.BtnConvertirDecimal.TabIndex = 8;
            this.BtnConvertirDecimal.Text = "Convertir a Decimal";
            this.BtnConvertirDecimal.UseVisualStyleBackColor = true;
            this.BtnConvertirDecimal.Click += new System.EventHandler(this.BtnConvertirDecimal_Click);
            // 
            // LbResultadoNum
            // 
            this.LbResultadoNum.AutoSize = true;
            this.LbResultadoNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbResultadoNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbResultadoNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbResultadoNum.Location = new System.Drawing.Point(12, 25);
            this.LbResultadoNum.Name = "LbResultadoNum";
            this.LbResultadoNum.Size = new System.Drawing.Size(36, 43);
            this.LbResultadoNum.TabIndex = 10;
            this.LbResultadoNum.Text = "0";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.LbResultadoNum);
            this.Controls.Add(this.BtnConvertirDecimal);
            this.Controls.Add(this.BtnConvertirBinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Controls.Add(this.CbOperadores);
            this.Controls.Add(this.TbxNumDos);
            this.Controls.Add(this.LsbResultadosOperacion);
            this.Controls.Add(this.TbxNumUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de Guillermo Lincoman del curso 2°D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxNumUno;
        private System.Windows.Forms.ListBox LsbResultadosOperacion;
        private System.Windows.Forms.TextBox TbxNumDos;
        private System.Windows.Forms.ComboBox CbOperadores;
        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvertirBinario;
        private System.Windows.Forms.Button BtnConvertirDecimal;
        private System.Windows.Forms.Label LbResultadoNum;
    }
}
