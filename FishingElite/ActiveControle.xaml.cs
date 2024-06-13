using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace FishingElite
{
    /// <summary>
    /// Логика взаимодействия для ActiveControle.xaml
    /// </summary>
    public partial class ActiveControle : Window
    {
        MainFunctions mainFunctions = new MainFunctions();
        int selectedID = -1;

        public ActiveControle()
        {
            InitializeComponent();
            reFillList();
        }

        public void reFillList()
        {
            ActiveDataGrid.SelectedValuePath = "id";
            ActiveDataGrid.SelectionMode = DataGridSelectionMode.Single;
            ActiveDataGrid.ItemsSource = mainFunctions.getActive();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView row = sender as DataRowView;
            if(row != null)
            {
                selectedID = int.Parse(row[0].ToString());
            }
        }

        private void btnActiveAdd_Click(object sender, RoutedEventArgs e)
        {
            ActiveCreator activeWindow = new ActiveCreator();
            activeWindow.Show();
            this.Close();
        }

        private void btnDeleteActive_Click(object sender, RoutedEventArgs e)
        {
            if(selectedID != -1)
            {
                mainFunctions.deleteActive(selectedID);
            }
        }
    }
}
