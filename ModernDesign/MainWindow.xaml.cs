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

namespace ModernDesign
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateEncryptionAlgorithms();
        }

        private void PopulateEncryptionAlgorithms()
        {
            var encryptionAlgorithms = new List<string>
            {
                "AES", "RSA", "SHA", "MD5", "TripleDES",
                "DES", "RC4", "Blowfish", "Twofish",
                "IDEA", "Serpent", "RC6", "Caesar Cipher"
            };

            EncryptSelectionBox.ItemsSource = encryptionAlgorithms;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaximizeRestoreButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void QuickStartGuide_Click(object sender, RoutedEventArgs e)
        {
            // Implement the action for Quick Start Guide button click
            // For example, open a dialog, navigate to a specific tab, etc.
        }

        private void GoToSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigateToTab("Search");
        }

        private void GoToEncrypt_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Encrypt tab
            NavigateToTab("Encrypt");
        }

        private void GoToDecrypt_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Decrypt tab
            NavigateToTab("Decrypt");
        }

        private void NavigateToTab(string tabHeader)
        {
            foreach (TabItem tab in MyTabControl.Items)
            {
                if (tab.Header.ToString() == tabHeader)
                {
                    MyTabControl.SelectedItem = tab;
                    break;
                }
            }
        }

        private void OnMediaEnded(object sender, RoutedEventArgs e)
        {
            var mediaElement = sender as MediaElement;
            if (mediaElement != null)
            {
                mediaElement.Position = TimeSpan.Zero; // Reset to start
                mediaElement.Play(); // Play again
            }
        }
    }
}
