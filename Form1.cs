using TrabalhoPratico.Entidades;

namespace TrabalhoPratico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpa()
        {
            txt_nome.Clear();
            txt_registro.Clear();
            txt_salariobase.Clear();
            txt_planosaude.Clear();

            lbl_resultado.Visible = false;
            lbl_inss.Visible = false;
            lbl_valorsalarioliq.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_inss.Visible = false;
            rdb_fpublico.Checked = true;
        }

        private void rdb_fcontratado_CheckedChanged(object sender, EventArgs e)
        {
            lbl_inss.Visible = false;
        }


        private void rdb_fpublico_CheckedChanged(object sender, EventArgs e)
        {
            lbl_inss.Visible = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (rdb_fpublico.Checked == true)
            {
                FPublico FPublico10 = new FPublico();

                FPublico10.setNome(txt_nome.Text);
                FPublico10.setRegistro(int.Parse(txt_registro.Text));
                FPublico10.setSalarioBase(double.Parse(txt_salariobase.Text));
                FPublico10.setPlanoSaude(double.Parse(txt_planosaude.Text));

                lbl_valorsalarioliq.Visible = true;
                lbl_resultado.Visible = true;

                FPublico10.CalcSalarioLiquido();
                lbl_resultado.Text = FPublico10.getSalarioLiquido().ToString();
            }

            else if (rdb_fcontratado.Checked == true)
            {
                lbl_valorsalarioliq.Visible = true;
                lbl_resultado.Visible = true;
                lbl_inss.Visible = true;

                FContratado FContratado20 = new FContratado();

                FContratado20.setNome(txt_nome.Text);
                FContratado20.setRegistro(int.Parse(txt_registro.Text));
                FContratado20.setSalarioBase(double.Parse(txt_salariobase.Text));

                FContratado20.setPlanoSaude(double.Parse(txt_planosaude.Text));

                FContratado20.CalcInss();
                lbl_resultado.Text = FContratado20.getSalarioLiquido().ToString();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpa();
        }
    }
}