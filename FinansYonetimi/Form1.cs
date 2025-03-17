namespace FinansYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ReceivableDal _receivableDal = new ReceivableDal();
        private void Form1_Load(object sender, EventArgs e)
        {

            dgwReceivables.DataSource = _receivableDal.GetAll();
        }


    }
}
