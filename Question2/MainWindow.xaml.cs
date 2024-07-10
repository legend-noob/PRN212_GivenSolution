using Question2.Models;
using System.Data.Common;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Prn212TrialContext context = new Prn212TrialContext();  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

		private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

        private void Button_Click()
        {
            Employee employee = new Employee
            {
                Name = empName.Text,
                Id = int.Parse(empId.Text),
               // Dob = empDob.Value,
                Phone = empPhone.Text,
                Idnumber = empIdNum.Text,
            };
            context.Employees.Add(employee);
            context.SaveChanges();
		}

		

		private void Button_Click_1()
		{


			//Employees.Remove(employee);
            context.SaveChanges();
		}
	}
}