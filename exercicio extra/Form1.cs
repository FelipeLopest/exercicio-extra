namespace exercicio_extra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb.Items.Add(texto_txt.Text);
            texto_txt.Clear();
            texto_txt.Focus();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item para eliminar", "Combo box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cb.Items.RemoveAt(cb.SelectedIndex);
                cb.SelectedIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texto_txt.Clear();
            cb.SelectedIndex = -1;
            position.Text = "";
            select.Text = "";
            sum.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb.Items.Clear();

        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex != -1)
            {
                position.Text = cb.SelectedIndex.ToString();
                select.Text = cb.SelectedItem.ToString();
                sum.Text = cb.Items.Count.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void texto_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
