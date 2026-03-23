namespace _3_GUI_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            cmbUnitA.SelectedIndex = 0;
            cmbUnitB.SelectedIndex = 0;
            cmbResultUnit.SelectedIndex = 0;
            cmbOperation.SelectedIndex = 0;
        }

        private void Calculate()
        {
            
        }
        private void OnValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
