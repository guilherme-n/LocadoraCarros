using System;
using System.Reflection;

namespace View
{
    public partial class FormSobre : FormPadrao
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void FormVersao_Load(object sender, EventArgs e)
        {
            LabelVersion.Text = "Versão " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}