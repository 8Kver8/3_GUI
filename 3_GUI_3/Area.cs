namespace _3_GUI_3
{
    public class Area
    {
        public enum AreaUnit { m2, sotka, hectare, desyatina };

        private double value;
        private AreaUnit unit;

        public Area(double value, AreaUnit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public string Verbose()
        {
            string unitVerbose = "";
            switch (this.unit)
            {
                case AreaUnit.m2:
                    unitVerbose = "м²";
                    break;
                case AreaUnit.sotka:
                    unitVerbose = "сотка";
                    break;
                case AreaUnit.hectare:
                    unitVerbose = "гектар";
                    break;
                case AreaUnit.desyatina:
                    unitVerbose = "десятина";
                    break;
            }
            return String.Format("{0} {1}", this.value, unitVerbose);
        }

        public Area To(AreaUnit newUnit)
        {
            double newValue = this.value;

            if (this.unit == AreaUnit.m2)
            {
                switch (newUnit)
                {
                    case AreaUnit.m2:
                        newValue = this.value;
                        break;
                    case AreaUnit.sotka:
                        newValue = this.value / 100;
                        break;
                    case AreaUnit.hectare:
                        newValue = this.value / 10000;
                        break;
                    case AreaUnit.desyatina:
                        newValue = this.value / 10925;
                        break;
                }
            }

            else if (newUnit == AreaUnit.m2)
            {
                switch (this.unit)
                {
                    case AreaUnit.m2:
                        newValue = this.value;
                        break;
                    case AreaUnit.sotka:
                        newValue = this.value * 100;
                        break;
                    case AreaUnit.hectare:
                        newValue = this.value * 10000;
                        break;
                    case AreaUnit.desyatina:
                        newValue = this.value * 10925;
                        break;
                }
            }

            else
            {
                newValue = this.To(AreaUnit.m2).To(newUnit).value;
            }

            return new Area(newValue, newUnit);
        }

        public static Area operator *(Area instance, double number)
        {
            double newValue = instance.value * number;
            AreaUnit sameUnit = instance.unit;
            return new Area(newValue, sameUnit);
        }

        public static Area operator +(Area instance1, Area instance2)
        {
            AreaUnit resultUnit = instance1.unit;
            double convertedValue = instance2.To(resultUnit).value;
            double newValue = instance1.value + convertedValue;
            return new Area(newValue, resultUnit);
        }

        public static Area operator -(Area instance1, Area instance2)
        {
            AreaUnit resultUnit = instance1.unit;
            double convertedValue = instance2.To(resultUnit).value;
            double newValue = instance1.value - convertedValue;
            return new Area(newValue, resultUnit);
        }

        public int CompareTo(Area other)
        {
            double thisInM2 = this.To(AreaUnit.m2).value;
            double otherInM2 = other.To(AreaUnit.m2).value;

            if (thisInM2 < otherInM2)
                return -1;
            if (thisInM2 > otherInM2)
                return 1;
            return 0;
        }

        public double ConvertTo(string unitName)
        {
            AreaUnit targetUnit;
            switch (unitName)
            {
                case "м²":
                    targetUnit = AreaUnit.m2;
                    break;
                case "сотка":
                    targetUnit = AreaUnit.sotka;
                    break;
                case "гектар":
                    targetUnit = AreaUnit.hectare;
                    break;
                case "десятина":
                    targetUnit = AreaUnit.desyatina;
                    break;
                default:
                    targetUnit = AreaUnit.m2;
                    break;
            }
            return this.To(targetUnit).value;
        }
    }
}