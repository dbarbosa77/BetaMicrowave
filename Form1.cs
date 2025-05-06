using MicroDigital.Entities;
using MicroDigital.Models;
using MicroDigital.Models.Exceptions;
using MicroDigital.Utils;
using MicroDigital.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MicroDigital
{
    public partial class Form1 : Form
    {

        private List<ProgramasAquecimento> programasPreDefinidos;
        private ProgramasAquecimento programaSelecionado = null;
        private Microondas microondas;
        private FormatarDigitacao formatador = new FormatarDigitacao();
        private EstadoAquecimento estadoAtual = EstadoAquecimento.Desligado;
        private ProgramasAquecimento programaAtual = null;
        private bool carregandoCombo = true;



        public Form1()
        {
            InitializeComponent();
            programasPreDefinidos = ProgramasAquecimento.ObterProgramasPreDefinidos();
            comboProgramas.DataSource = programasPreDefinidos;
            comboProgramas.DisplayMember = "Name";
            comboProgramas.SelectedIndex = -1;
            MicroondasHelper.LimpezaCampos(LblAquecimento, lblTempo, BoxTime);
            numericPower.Value = 0;
            carregandoCombo = false;
        }

        public async void btnIniciar_Click(object sender, EventArgs e)
        {
            bool IsTrueProgramaPreDefinido = programaSelecionado != null;
            switch (estadoAtual)
            {
                case EstadoAquecimento.Pausado:
                    
                    timer1.Start();
                    microondas.Power = MicroondasHelper.TratarPower(numericPower);
                    estadoAtual = EstadoAquecimento.EmAndamento;
                    break;

                case EstadoAquecimento.Desligado:
                    try
                    {
                        if (IsTrueProgramaPreDefinido)
                        {
                            programaAtual = programaSelecionado;
                            microondas = new Microondas(programaAtual.Microondas.Time, programaAtual.Microondas.Power);
                            numericPower.Enabled = false;
                        }
                        else
                        {
                            TimeSpan time = (TimeSpan)MicroondasHelper.ObterTimeSpan(BoxTime);
                            numericPower.Value = MicroondasHelper.TratarPower(numericPower);
                            microondas = new Microondas(time, (int)numericPower.Value);
                        }
                        MicroondasHelper.LimparAquecimentoVisor(LblAquecimento);
                        lblTempo.Text = microondas.ToString();
                        timer1.Start();
                        estadoAtual = EstadoAquecimento.EmAndamento;
                    }
                    catch (TimerException ex)
                    {
                        await MicroondasHelper.TratarAlertAsync(lblAlert, ex.Message);
                        MicroondasHelper.TratarStop(lblTempo, BoxTime);
                        formatador.Limpar();
                    }
                    catch (PowerException ex)
                    {
                        await MicroondasHelper.TratarAlertAsync(lblAlert, ex.Message);
                        MicroondasHelper.TratarStop(lblTempo, BoxTime);
                        formatador.Limpar();
                    }
                    catch (Exception ex)
                    {
                        await MicroondasHelper.TratarAlertAsync(lblAlert, ex.Message);
                        MicroondasHelper.TratarStop(lblTempo, BoxTime);
                        formatador.Limpar();
                    }
                    break;

                case EstadoAquecimento.EmAndamento:
                    if (IsTrueProgramaPreDefinido)
                    {
                        await MicroondasHelper.TratarAlertAsync(lblAlert, "O tempo não pode ser aumentado para programas pré-definidos.");
                    }
                    else
                    {
                        microondas.Power = MicroondasHelper.TratarPower(numericPower);
                        microondas.AumentarIniciar();
                    }
                    
                    break;
            }

            BoxTime.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)//Tick do Timer1
        {
            bool IsTrueProgramaPreDefinido = programaSelecionado != null;
            if (microondas.Time > TimeSpan.Zero) //Se timer do microondas for maior que zero:
            {
                if (IsTrueProgramaPreDefinido)
                {
                    MicroondasHelper.IniciarAquecimentoVisor(LblAquecimento, microondas, programaAtual.CaracterHeat);
                }
                else
                {
                    MicroondasHelper.IniciarAquecimentoVisor(LblAquecimento, microondas, '.');
                }
                
                microondas.Diminuir();
                lblTempo.Text = microondas.ToString();
            }
            else //Se timer do microondas terminou:
            {
                comboProgramas.SelectedIndex = -1;
                numericPower.Enabled = true;
                programaSelecionado = null;
                MicroondasHelper.FinalizarAquecimentoVisor(LblAquecimento);
                timer1.Stop();
                estadoAtual = EstadoAquecimento.Desligado;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            switch (estadoAtual)
            {
                case EstadoAquecimento.EmAndamento:
                    timer1.Stop();
                    estadoAtual = EstadoAquecimento.Pausado;
                    break;

                case EstadoAquecimento.Pausado:
                    formatador.Limpar();
                    MicroondasHelper.LimpezaCampos(LblAquecimento, lblTempo, BoxTime);
                    estadoAtual = EstadoAquecimento.Desligado;
                    numericPower.Value = MicroondasHelper.TratarPower(numericPower);
                    numericPower.Enabled = true;
                    comboProgramas.SelectedIndex = -1;
                    programaSelecionado = null;
                    break;

                case EstadoAquecimento.Desligado:

                    programaSelecionado = null;
                    numericPower.Value = 0;
                    formatador.Limpar();
                    MicroondasHelper.TratarStop(lblTempo, BoxTime);
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 1;
                lblTempo.Text = formatador.AdicionarDigito(1);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 2;
                lblTempo.Text = formatador.AdicionarDigito(2);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 3;
                lblTempo.Text = formatador.AdicionarDigito(3);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 4;
                lblTempo.Text = formatador.AdicionarDigito(4);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 5;
                lblTempo.Text = lblTempo.Text = formatador.AdicionarDigito(5);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 6;
                lblTempo.Text = formatador.AdicionarDigito(6);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 7;
                lblTempo.Text = formatador.AdicionarDigito(7);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 8;
                lblTempo.Text = formatador.AdicionarDigito(8);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 9;
                lblTempo.Text = formatador.AdicionarDigito(9);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                BoxTime.Text += 0;
                lblTempo.Text = formatador.AdicionarDigito(0);
            }
        }
        public void comboProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregandoCombo) return;

            if (comboProgramas.SelectedIndex != -1 && estadoAtual == EstadoAquecimento.Desligado && !timer1.Enabled)
            {
                programaSelecionado = (ProgramasAquecimento)comboProgramas.SelectedItem;

                lblTempo.Text = programaSelecionado.Microondas.Time.ToString(@"hh\:mm\:ss");
                numericPower.Text = programaSelecionado.Microondas.Power.ToString();
            }
        }
    }
}
