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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CursWork.Pages
{
    /// <summary>
    /// Логика взаимодействия для userNotAdmin.xaml
    /// </summary>
    public partial class userNotAdmin : Page
    {
        public userNotAdmin()
        {
            InitializeComponent();
            ItemListDG.ItemsSource = App.DB.films.ToList();
            exampleDG.Visibility = Visibility.Hidden;

        }
            private void ExitBT_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new LoginP());

            }

            private void AllBT_Click(object sender, RoutedEventArgs e)
            {
            ItemListDG.Visibility = Visibility.Visible;
            exampleDG.Visibility = Visibility.Hidden;

            ItemListDG.ItemsSource = App.DB.films.ToList();
            }

            private void DrammBT_Click(object sender, RoutedEventArgs e)
            {
            ItemListDG.Visibility = Visibility.Visible;
            exampleDG.Visibility = Visibility.Hidden;

            ItemListDG.ItemsSource = App.DB.films.ToList().Where(x => x.idGenre == 1);
            }

            private void CrimeBT_Click(object sender, RoutedEventArgs e)
            {
            ItemListDG.Visibility = Visibility.Visible;
            exampleDG.Visibility = Visibility.Hidden;

            ItemListDG.ItemsSource = App.DB.films.ToList().Where(x => x.idGenre == 3);
            }

            private void FantasyBT_Click(object sender, RoutedEventArgs e)
            {
            ItemListDG.Visibility = Visibility.Visible;
            exampleDG.Visibility = Visibility.Hidden;

            ItemListDG.ItemsSource = App.DB.films.ToList().Where(x => x.idGenre == 2);

            }

            private void BuyTicket_Click(object sender, RoutedEventArgs e)
            {
                ticketUser tu = new ticketUser();
                var selectedItem = ItemListDG.SelectedItem as films;
                if (selectedItem == null)
                {
                    MessageBox.Show("Выберите пожалуйста хоть что-то :)");
                    return;
                }
                tu.idTicket = selectedItem.id;
                tu.idUser = DataUs.id;
                MessageBox.Show("Билет куплен!");
            }

            private void MyFilms_Click(object sender, RoutedEventArgs e)
            {
            ItemListDG.Visibility = Visibility.Hidden;
            exampleDG.Visibility = Visibility.Visible;

            exampleDG.ItemsSource = App.DBO.film_seans.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ItemListDG.ItemsSource = App.DB.films.ToList().Where(x => x.idGenre == 2);

        }
    }
}
