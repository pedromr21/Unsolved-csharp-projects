namespace EmployeesV10
{
    public class Teacher : Employee
    {
        #region Instance fields
        private int _payGrade;
        #endregion

        #region Constructor
        public Teacher(string name, int hoursPerWeek, int payGrade) : base(name,hoursPerWeek)
        {
            _payGrade = payGrade;
        }
        #endregion

        #region Properties
        public int PayGrade
        {
            get { return _payGrade; }
            set { _payGrade = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"Teacher {Name} works {HoursPerWeek} hours/week, at paygrade {PayGrade}";
            }
        } 
        #endregion
    }
}
