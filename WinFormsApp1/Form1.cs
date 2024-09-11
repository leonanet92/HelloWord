namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            //MessageBox.Show("Usuario: " + usuario + " \n" + "Senha: " + senha);
            MessageBox.Show($"Usuario: {usuario} \n Senha: {senha}{1 + 2}");
        }
        
        private void tela2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            //frm.Show();/*permite que alterar entre as duas abas*/
            frm.ShowDialog();/*Não permite alterar entre as duas abas, deve fechar a que foi aberta ppara ter acesso a primeira*/
        }
    }
}