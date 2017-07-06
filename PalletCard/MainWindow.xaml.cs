using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PalletCard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool sectionbtns;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Dockpanel_Loaded(object sender, RoutedEventArgs e)
        {

        }




        private void Search(object sender, RoutedEventArgs e)
        {


            string ConnectionString = Convert.ToString("Dsn=TharData;uid=tharuser");
            string CommandText = "SELECT * FROM app_PalletOperations";
            OdbcConnection myConnection = new OdbcConnection(ConnectionString);
            OdbcCommand myCommand = new OdbcCommand(CommandText, myConnection);
            OdbcDataAdapter myAdapter = new OdbcDataAdapter();
            myAdapter.SelectCommand = myCommand;
            DataSet tharData = new DataSet();
            try
            {
                myConnection.Open();
                myAdapter.Fill(tharData);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                myConnection.Close();
            }
            using (DataTable operations = new DataTable())
            {
                myAdapter.Fill(operations);              
                string job = searchBox.Text;
                string name = "0/2 Sheet Work";
                DataView dv = new DataView(operations);
                //dv.RowFilter = "Name like '%3%' and JobNo like '%101885%'";
                dv.RowFilter = "ResourceID = '5' and JobNo = " + "'"+ job +"'" ; 
                dataGrid.ItemsSource = dv;

                var x = 1;
                var y = 2;
                var z = x + y;
                if(z==3)
                {
                    dv.RowFilter = "ResourceID = '5' and JobNo = " + "'" + job + "'" + "and Name = " + "'" + name + "'";
                }

            }


        }
    }

}
