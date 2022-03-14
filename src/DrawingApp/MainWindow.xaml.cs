using System;
using System.Windows;
using System.IO;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SelfRef = this;
            InitializeComponent();
        }

        public static MainWindow SelfRef    // link on this private components to other classes
        {
            get; set;
        }

        private void AboutOpen_Enter(object sender, RoutedEventArgs e)
        {
            ToolTip tOpen = new ToolTip();
            ItemOpen.ToolTip = tOpen;
            tOpen.Content = "Open file and load to my editor!";
        }

        private void AboutSave_Enter(object sender, RoutedEventArgs e)
        {
            ToolTip tSave = new ToolTip();
            ItemSave.ToolTip = tSave;
            tSave.Content = "Save file to initial directory without bitmap coding for further opening in my editor.";
        }

        private void AboutExport_Enter(object sender, RoutedEventArgs e)
        {
            ToolTip tExport = new ToolTip();
            ItemExport.ToolTip = tExport;
            tExport.Content = "Export file to open in Windows. This will not be avaliable to open in my editor.";
        }        

        private void EditClear_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.Strokes.Clear();
        }

        private void ItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }       

        private void ToolsOpen_Click(object sender, RoutedEventArgs e)
        {
            Palette obj = new Palette();
            obj.Show();
        }

        private void MessageBoxForAbout(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show("Hello and thank you for downloading my drawing app!\nThis is a recreation based on an open source project, built in Visual Studio 2022 Community.\n\nThere are some decent functions here aswell as an advanced color pallete to let your creativity flow!\n\nNOTE: Resizing the window will leave any current drawing in its place, resulting in a larger canvas.\n\nSIDENOTE: Saving the file is primarily meant for projects in progress and can in most cases corrupt the file if trying to open it normally. Use the export button when the project is complete to get a working image in 4 different formats of your choice!\n\nCopyright © 2022 by TnyavnTo @ S&A Organics Co.", "About My Drawing App", MessageBoxButton.OK);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
