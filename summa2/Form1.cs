namespace summa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int tal3 = tal1 + tal2;

           
            textBox3.Text = (tal3).ToString();



         
            
        }
    }
}
