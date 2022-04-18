using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Lincoman.Guillermo._2D.TP1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            CargarOperadores();
        }
        /// <summary>
        /// Cargo operadores al Combo Box
        /// </summary>
        private void CargarOperadores()
        {
            CbOperadores.Items.Add("+");
            CbOperadores.Items.Add("-");
            CbOperadores.Items.Add("*");
            CbOperadores.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BtnConvertirDecimal.Enabled = false;
            this.BtnConvertirBinario.Enabled = false;
        }

        private void Limpiar()
        {
            //Limpio datos de la calculadora
            this.LbResultadoNum.Text = "0";
            this.CbOperadores.Text = "";
            this.CbOperadores.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TbxNumUno.Text = string.Empty;
            this.TbxNumDos.Text = string.Empty;
            this.LsbResultadosOperacion.Items.Clear();
            this.BtnConvertirDecimal.Enabled = false;
            this.BtnConvertirBinario.Enabled = false;
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(TbxNumUno.Text, out double num1) && double.TryParse(TbxNumDos.Text, out double num2))
            {
                if (CbOperadores.Text != string.Empty)
                {
                    Operando numUno = new Operando(TbxNumUno.Text);
                    Operando numDos = new Operando(TbxNumDos.Text);
                    double resultado = 0;
                    resultado = Calculadora.Operar(numUno, numDos, CbOperadores.Text[0]);
                    this.LsbResultadosOperacion.Items.Add($"{num1} {CbOperadores.Text[0]} {num2} = {resultado}");
                    this.LbResultadoNum.Text = resultado.ToString();
                    this.BtnOperar.Enabled = false;
                    this.BtnConvertirBinario.Enabled = true;
                    this.CbOperadores.Enabled = false;
                    this.TbxNumUno.Enabled = false;
                    this.TbxNumDos.Enabled = false;
                    char[] auxResultado = resultado.ToString().ToCharArray();
                    for (int i = 0; i < auxResultado.Length; i++)
                    {
                        if (auxResultado[i] == '1' || auxResultado[i] == '0')
                        {
                            this.BtnConvertirDecimal.Enabled = true;
                        }
                        else
                        {
                            this.BtnConvertirDecimal.Enabled = false;
                            break;
                        }
                    }
                }
                else
                {
                    this.LbResultadoNum.Text = "Error, Ingrese un operador..";

                }

            }
            else
            {
                this.LbResultadoNum.Text = "Ingrese datos validos para operar";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.BtnOperar.Enabled = true;
            this.TbxNumUno.Enabled = true;
            this.CbOperadores.Enabled = true;
            this.TbxNumDos.Enabled = true;
            Limpiar();
        }

        private void BtnConvertirBinario_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            string aux = LbResultadoNum.Text;
            if(double.TryParse(LbResultadoNum.Text, out double numeroDecimal))
            {
                LbResultadoNum.Text = numero.DecimalBinario(numeroDecimal);
                this.LsbResultadosOperacion.Items.Clear();
                this.BtnConvertirDecimal.Enabled = true;
                this.BtnConvertirBinario.Enabled = false;
            }
        }

        private void BtnConvertirDecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            string aux = LbResultadoNum.Text;
            LbResultadoNum.Text = numero.BinarioDecimal(LbResultadoNum.Text);
            this.LsbResultadosOperacion.Items.Clear();
            this.BtnConvertirBinario.Enabled = true;
            this.BtnConvertirDecimal.Enabled = false;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar la aplicacion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
