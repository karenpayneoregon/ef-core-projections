using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncOperations.Classes;

namespace AsyncOperations.Examples
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            Shown += EmployeesForm_Shown;
        }

        private async void EmployeesForm_Shown(object sender, EventArgs e)
        {
            var employees = await Operations.EmployeesProjected();
            EmployeeProjectedDataGridView.DataSource = employees;

            EmployeeDataGridView.DataSource = Operations.Employees();
            EmployeeDataGridView.Columns["Orders"].DisplayIndex = 4;
        }
    }
}
