using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
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
using UP2_ASS.Models;

namespace UP2_ASS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBMainContext dbMainContext = new DBMainContext();
        ObservableCollection<Book> books = new ObservableCollection<Book>();
        public MainWindow()
        {
            InitializeComponent();

            dbMainContext.Books.Load();

            books = dbMainContext.Books.Local.ToObservableCollection();

            itemscontrolMain.ItemsSource = books;
        }

        private void buttAddBook_Click(object sender, RoutedEventArgs e)
        {
            Book b = new Book();

            WindowBookAddEdit window = new WindowBookAddEdit();

            window.DataContext = b;

            window.comboxStatuses.ItemsSource = dbMainContext.Statuses.ToList();

            window.comboxGenres.ItemsSource = dbMainContext.Genres.ToList();

            window.ShowDialog();

            if (window.DialogResult == true) {
                try
                {
                    b.GenreName = b.Genre?.Name;
                    b.StatusName = b.Status?.Name;
                    books.Add(b);
                    dbMainContext.SaveChanges();
                    itemscontrolMain.ItemsSource = null;
                    itemscontrolMain.ItemsSource = books;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void buttDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены в своих действиях?", "Армагеддон", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                books.Clear();
                dbMainContext.SaveChanges();
            }
            MessageBox.Show("Готово.");
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowBookAddEdit window = new WindowBookAddEdit();

                if ((sender as StackPanel).DataContext is Book b)
                {
                    window.DataContext = b;

                    window.comboxGenres.ItemsSource = dbMainContext.Genres.ToList();

                    window.comboxStatuses.ItemsSource = dbMainContext.Statuses.ToList();

                    window.ShowDialog();

                    if (window.deletionFlag == true && window.DialogResult == false)
                    {
                        try
                        {
                            books.Remove(b);
                            dbMainContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        return;
                    }

                    if (window.DialogResult == true)
                    {
                        try
                        {
                            b.GenreName = b.Genre?.Name;
                            b.StatusName = b.Status?.Name;
                            dbMainContext.SaveChanges();
                            itemscontrolMain.ItemsSource = null;
                            itemscontrolMain.ItemsSource = books;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                    }
                }
            }
        }
    }