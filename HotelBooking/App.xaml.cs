using HotelBooking.Exceptions;
using HotelBooking.Models;
using HotelBooking.ViewModels;
using System.Windows;

namespace HotelBooking
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            //Hotel hotel = new Hotel("Leonardo Suites");

            //try
            //{
            //    hotel.MakeReservation(new Reservation(
            //        new RoomID(1, 3),
            //        "Leonardo",
            //        new DateTime(2000, 1, 1),
            //        new DateTime(2000, 1, 2)));

            //    hotel.MakeReservation(new Reservation(
            //        new RoomID(1, 3),
            //        "Leonardo",
            //        new DateTime(2000, 1, 3),
            //        new DateTime(2000, 1, 4)));
            //} catch (ReservationConflictException ex)
            //{

            //}

            //IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Leonardo");

            base.OnStartup(e);
        }
    }

}
