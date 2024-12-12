using Tyuiu.MasalimovTR.Sprint6.Task0.V6.Lib;

namespace Tyuiu.MasalimovTR.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            Result.Text = Convert.ToString(ds.Calculate(x));
        }
    }
}
