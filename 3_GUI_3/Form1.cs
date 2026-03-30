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

        private Area.AreaUnit ParseAreaUnit(string unitName)
        {
            Area.AreaUnit unit;
            switch (unitName)
            {
                case "м²":
                    unit = Area.AreaUnit.m2;
                    break;
                case "сотка":
                    unit = Area.AreaUnit.sotka;
                    break;
                case "гектар":
                    unit = Area.AreaUnit.hectare;
                    break;
                case "десятина":
                    unit = Area.AreaUnit.desyatina;
                    break;
                default:
                    unit = Area.AreaUnit.m2;
                    break;
            }
            return unit;
        }

        private Area GetAreaFromInput(TextBox txt, ComboBox cmb)
        {
            double value = double.Parse(txt.Text);
            Area.AreaUnit unit = ParseAreaUnit(cmb.Text);
            return new Area(value, unit);
        }

        private void ShowResult(Area result, string outUnit)
        {
            double outValue = result.ConvertTo(outUnit);
            txtResult.Text = outValue.ToString("F2");
        }

        private void ShowCompareResult(int cmp)
        {
            switch (cmp)
            {
                case -1:
                    txtResult.Text = "А < Б";
                    break;
                case 0:
                    txtResult.Text = "А = Б";
                    break;
                case 1:
                    txtResult.Text = "А > Б";
                    break;
            }
        }

        private void Calculate()
        {
            try
            {
                string operation = cmbOperation.Text;
                string resultUnit = cmbResultUnit.Text;

                Area areaA = GetAreaFromInput(txtAreaA, cmbUnitA);

                if (operation == "×")
                {
                    double multiplier = double.Parse(txtAreaB.Text);
                    Area result = areaA * multiplier;
                    ShowResult(result, resultUnit);
                    return;
                }

                Area areaB = GetAreaFromInput(txtAreaB, cmbUnitB);

                switch (operation)
                {
                    case "+":
                        ShowResult(areaA + areaB, resultUnit);
                        break;
                    case "-":
                        ShowResult(areaA - areaB, resultUnit);
                        break;
                    case "Сравнить":
                        int cmp = areaA.CompareTo(areaB);
                        ShowCompareResult(cmp);
                        break;
                }
            }
            catch (FormatException)
            {
                txtResult.Text = "";
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}