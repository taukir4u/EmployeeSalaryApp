using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        Salary aSalary;
        Employee aEmployee;
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aSalary=new Salary();
            aSalary.BasicSalary = Convert.ToDouble(basicTextBox.Text);
            aSalary.MedicalPercentage = Convert.ToDouble(medicalTextBox.Text);
            aSalary.ConveyancePercentage = Convert.ToDouble(conveyanceTextBox.Text);

            aEmployee=new Employee();
            aEmployee.ID = idTextBox.Text;
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.EmployeeSalary = aSalary;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            incrementNoTextBox.Text = aEmployee.EmployeeSalary.NoofIncrements.ToString();
            basicOutTextBox.Text = aEmployee.EmployeeSalary.BasicSalary.ToString();
            MedicalOutTextBox.Text = aEmployee.EmployeeSalary.GetMedicalAmount().ToString();
            conveyanceOutTextBox.Text = aEmployee.EmployeeSalary.GetConveyanceAmount().ToString();
            totalTextBox.Text = aEmployee.EmployeeSalary.GetTotalSalary().ToString();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            aEmployee.EmployeeSalary.IncreaseSalary(Convert.ToDouble(IncrementTextBox.Text));
            MessageBox.Show("Increment Done");
        }
    }
}
