using CodeScrinner.Generators;
using CodeScrinner.Properties;
using CoreHtmlToImage;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace CodeScrinner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        public MainWindow()
        {
            InitializeComponent();
            
            NicknameTextBox.Text = Settings.Default.Title;
            LightTheme.IsChecked = Settings.Default.IsLight;
            
            m_notifyIcon = new System.Windows.Forms.NotifyIcon();
            m_notifyIcon.BalloonTipText = "The app has been minimised. Click the tray icon to show.";
            m_notifyIcon.BalloonTipTitle = "CodeScrinner";
            m_notifyIcon.Text = "CodeScrinner";
            m_notifyIcon.Icon = new System.Drawing.Icon("Icons\\Logo.ico");
            m_notifyIcon.Click += new EventHandler(m_notifyIcon_Click);

            
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.Title= NicknameTextBox.Text;
            Settings.Default.IsLight = (bool)LightTheme.IsChecked;
            Settings.Default.Save();
            System.Windows.MessageBox.Show("Settings have been saved ");
        }

        private void Github_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ErrorVdept") { UseShellExecute = true });
            
        }
        private void Web_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://errorvdept.github.io") { UseShellExecute = true });
            
        }
        private void Donate_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://donate.stream/errorvdept_soft") { UseShellExecute = true });
            
        }
        void OnClose(object sender, CancelEventArgs args)
        {
            m_notifyIcon.Dispose();
            m_notifyIcon = null;
            
        }

        private WindowState m_storedWindowState = WindowState.Normal;
        void OnStateChanged(object sender, EventArgs args)
        {
            if (WindowState == WindowState.Minimized)
            {
                Hide();
                if (m_notifyIcon != null)
                    m_notifyIcon.ShowBalloonTip(2000);
            }
            else
                m_storedWindowState = WindowState;
        }
        void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            CheckTrayIcon();
        }

        void m_notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = m_storedWindowState;
        }
        void CheckTrayIcon()
        {
            ShowTrayIcon(!IsVisible);
        }

        void ShowTrayIcon(bool show)
        {
            if (m_notifyIcon != null)
                m_notifyIcon.Visible = show;
        }

        
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            
            string text = System.Windows.Clipboard.GetText();
            text = text.Replace("<", "&lt");
            text = text.Replace(">", "&gt");
            //if (screenWindow != null )
            //{

            //    screenWindow.InitWindow(text);
            //    //screenWindow.ShowDialog();
            //    screenWindow.Activate();
            //}
            //else
            //{
            //    screenWindow ;
            //    screenWindow.ShowDialog();
            //}
            ScreenWindow screenWindow = new ScreenWindow(text);
            screenWindow.ShowDialog();


        }
        
    }
}
