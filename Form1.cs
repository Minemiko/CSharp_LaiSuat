namespace CSharp_LaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double NamBD = Convert.ToDouble(txtNbd.Text);
            double Nam = Convert.ToDouble(txtNam.Text);
            double TienM = Convert.ToDouble(txtTien.Text);
            double LS = Convert.ToDouble(txtLS.Text);
            double TienLS = TienM * LS * 0.01;
            for (double i = NamBD; i <= Nam; i++)
            {
                TienM += TienLS;
                TN.Items.Add("Năm " + i + " lãi " + Math.Round(TienLS) + "đ " + " tổng " + Math.Round(TienM) + "đ");
                TienLS = TienM * (LS*0.01);
            }
        }
    }
}
