using System;



namespace HRLib
{
    public class Employee
    {
        #region Fields & Properties



        private string empName;



        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }



        private string address;



        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion





        #region Constructor



        public Employee()
        {
            empName="sandhya";
            address = "kkd";
        }



        public Employee(string ename, string eaddr)
        {
            this.EmpName = ename;
            this.Address = eaddr;
        }
        #endregion







    }
}