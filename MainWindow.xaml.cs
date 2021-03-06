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

using System.Text.RegularExpressions;   //  A Regex névtere
using System.Collections.ObjectModel;

namespace processManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<mission> feladat = new ObservableCollection<mission>();
        public MainWindow()
        {
            InitializeComponent();

            feladat.Add(new mission() {Name = "Első feladat", Location = "Első helyszín", StartingMonth = 1,
            StartingDay = 1, Duration = 25, EndingMonth = 1, EndingDay = 1, Description = "Első feladat leírása"});
            feladat.Add(new mission() {Name = "Második feladat", Location = "Második helyszín", StartingMonth = 2,
            StartingDay = 1, Duration = 10, EndingMonth = 1, EndingDay = 1, Description = "Második feladat leírása"});
            feladat.Add(new mission() {Name = "Harmadik feladat", Location = "Első helyszín", StartingMonth = 2,
            StartingDay = 10, Duration = 20, EndingMonth = 1, EndingDay = 1,Description = "Harmadik feladat leírása"});
            feladat.Add(new mission() {Name = "Negyedik feladat", Location = "Első helyszín", StartingMonth = 3,
            StartingDay = 20, Duration = 30, EndingMonth = 1, EndingDay = 1,Description = "Negyedik feladat leírása"});

            LBO_Tasks.ItemsSource = feladat;

            SP_TaskPanel.Visibility = Visibility.Hidden;
        }

        private void StringToIntValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regexValidator = new Regex("[^0-9]+");
            e.Handled = regexValidator.IsMatch(e.Text);

            // "[^0-9]+" : Szám "[^a-z]+" : Az angol ABC kisbetűi "[^A-Z]+" : Az angol ABC nagybetűi
            // "[^A-z]+" : Az angol ABC kis és nagybetűi
            //  Függően a regexValidator példányosításánál a "^" elhelyezkedésétől (Szögletes zárójelen belül vagy kívül), jelentheti
            //  hogy (Belül)csak az  adott karakterek vihetőek be, vagy (Kívül) csak az adott karakterek NEM vihetőek be
        }

        private async void BTN_Validate_Click(object sender, RoutedEventArgs e)
        {
            SP_ValidatorPanel.DataContext = new mission();
        }

        private void DPI_StartingDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            TBO_StartingDay.Text = DPI_StartingDate.SelectedDate.Value.Day.ToString();
            TBO_StartingMonth.Text = DPI_StartingDate.SelectedDate.Value.Month.ToString();
        }

        private async void BTN_NewTask_Click(object sender, RoutedEventArgs e)
        {
            LBO_Tasks.SelectedItem = null;
            SP_TaskPanel.Visibility = Visibility.Visible;
            #region kommenteltcucc
            //if (string.IsNullOrEmpty(TBO_TaskName.Text))
            //{
            //    TBO_TaskName.Text = "Kitöltése kötelező";
            //    await Task.Delay(1000);
            //    TBO_TaskName.Text = null;
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(TBO_TaskLocation.Text))
            //    {
            //        TBO_TaskLocation.Text = "Kitöltése kötelező";
            //        await Task.Delay(1000);
            //        TBO_TaskLocation.Text = null;
            //    }
            //    else
            //    {
            //        if (string.IsNullOrEmpty(TBO_StartingMonth.Text) || string.IsNullOrEmpty(TBO_StartingDay.Text))
            //        {
            //            SP_ValidatorPanel.DataContext = new mission();
            //            if (TBO_StartingMonth.Text.Contains(""))
            //            {
            //                TBO_StartingMonth.Text = "";
            //                if (TBO_StartingDay.Text.Contains(""))
            //                {
            //                    TBO_StartingDay.Text = "";
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (string.IsNullOrEmpty(TBO_Duration.Text))
            //            {
            //                TBO_Duration.Text = "Kitöltése kötelező";
            //                await Task.Delay(1000);
            //                TBO_Duration.Text = null;
            //            }
            //            else
            //            {
            //                if (string.IsNullOrEmpty(TBO_Description.Text))
            //                {
            //                    TBO_Description.Text = "Kitöltése kötelező";
            //                    await Task.Delay(1000);
            //                    TBO_Description.Text = null;
            //                }
            //                else
            //                {
            //                    feladat.Add(new mission()
            //                    {
            //                        Name = TBO_TaskName.Text,
            //                        Location = TBO_TaskLocation.Text,
            //                        StartingMonth = Convert.ToInt32(TBO_StartingMonth.Text),
            //                        StartingDay = Convert.ToInt32(TBO_StartingDay.Text),
            //                        Duration = Convert.ToInt32(TBO_Description.Text),
            //                        EndingMonth = 0,
            //                        EndingDay = 0,
            //                        Description = TBO_Description.Text,
            //                    });
            //                    LBO_Tasks.ItemsSource = feladat;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (string.IsNullOrEmpty(TBO_StartingMonth.Text) || string.IsNullOrEmpty(TBO_StartingDay.Text))
            //{
            //    SP_ValidatorPanel.DataContext = new mission();
            //    if (TBO_StartingMonth.Text.Contains(""))
            //    {
            //        TBO_StartingMonth.Text = "";
            //        if (TBO_StartingDay.Text.Contains(""))
            //        {
            //            TBO_StartingDay.Text = "";
            //        }
            //    }
            //}

            //SP_ValidatorPanel.DataContext = new mission();
            //if (TBO_StartingMonth.Text.Contains("0"))
            //{
            //    TBO_StartingMonth.Text = "";
            //    if (TBO_StartingDay.Text.Contains(""))
            //    {
            //        TBO_StartingDay.Text = "";
            //    }
            //}
            #endregion
        }

        private void BTN_EditTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_DeleteTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            if (LBO_Tasks.SelectedItem != null)
            {

            }
            else
            {
                if (string.IsNullOrEmpty(TBO_TaskName.Text))
                {
                    TBO_TaskName.Text = "Kitöltése kötelező";
                    await Task.Delay(1000);
                    TBO_TaskName.Text = null;
                }
                else
                {
                    if (string.IsNullOrEmpty(TBO_TaskLocation.Text))
                    {
                        TBO_TaskLocation.Text = "Kitöltése kötelező";
                        await Task.Delay(1000);
                        TBO_TaskLocation.Text = null;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(TBO_StartingMonth.Text) || string.IsNullOrEmpty(TBO_StartingDay.Text))
                        {
                            SP_ValidatorPanel.DataContext = new mission();
                            if (TBO_StartingMonth.Text.Contains(""))
                            {
                                TBO_StartingMonth.Text = "";
                                if (TBO_StartingDay.Text.Contains(""))
                                {
                                    TBO_StartingDay.Text = "";
                                }
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(TBO_Duration.Text))
                            {
                                TBO_Duration.Text = "Kitöltése kötelező";
                                await Task.Delay(1000);
                                TBO_Duration.Text = null;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(TBO_Description.Text))
                                {
                                    TBO_Description.Text = "Kitöltése kötelező";
                                    await Task.Delay(1000);
                                    TBO_Description.Text = null;
                                }
                                else
                                {
                                    feladat.Add(new mission()
                                    {
                                        Name = TBO_TaskName.Text,
                                        Location = TBO_TaskLocation.Text,
                                        StartingMonth = Convert.ToInt32(TBO_StartingMonth.Text),
                                        StartingDay = Convert.ToInt32(TBO_StartingDay.Text),
                                        Duration = Convert.ToInt32(TBO_Description.Text),
                                        EndingMonth = 0,
                                        EndingDay = 0,
                                        Description = TBO_Description.Text,
                                    });
                                    LBO_Tasks.ItemsSource = feladat;
                                }
                            }
                        }
                    }
                }
            }

            
        }
    }
}
