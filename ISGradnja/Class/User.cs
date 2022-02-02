using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ISGradnja.Class
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }

        private static string error = "Korisnik ne postoji u bazi!";

        private static string errorExist = "Korisnik već postoji u bazi!";

        public static void ShowError()
        {
            MessageBox.Show(error, "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ShowErrorExist()
        {
            MessageBox.Show(errorExist, "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static bool IsEqual(User user1, User user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error = "Korisnik ne postoji u bazi!";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "Korisnički username i password se ne poklapaju!";
                return false;
            }

            return true;
        }
    }
}
