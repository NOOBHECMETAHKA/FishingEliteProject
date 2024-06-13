using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ActiveCreator.xaml
    /// </summary>
    public partial class ActiveCreator : Window
    {
        ActiveControle activeControle = new ActiveControle();
        MainFunctions mainFunctions = new MainFunctions(); 

        public ActiveCreator()
        {
            InitializeComponent();
            cbTypeActive.ItemsSource = mainFunctions.getCategory();
            cbTypeActive.SelectedIndex = 0;
            cbTypeActive.SelectedValuePath = "id";
            cbTypeActive.DisplayMemberPath = "title";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(mainFunctions.createActive(tbNameActive.Text, Decimal.Parse(tbonce_price.Text), cbTypeActive.SelectedIndex, tbDescription.Text))
            {
                activeControle.Show();
                this.Close();
            }
        }
       

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            activeControle.Show();
            this.Close();
        }
    }
}
