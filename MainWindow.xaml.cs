using System;
using System.Collections;
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

namespace HW_Lecture_84_ArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void txtAdd_Text_Click(object sender, RoutedEventArgs e)
        {
            //Add Data
            arrayList.Add(txtTextbox.Text); 
            MessageBox.Show(txtTextbox.Text + " " + "has been Added");
            txtTextbox.Text = "";
        }

        private void txtRemove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            arrayList.Remove(txtTextbox.Text);
            MessageBox.Show(txtTextbox.Text + " " + "has been Removed");
            txtTextbox.Text = "";
        }

        private void txtShow_All_Text_Click(object sender, RoutedEventArgs e)
        {
            //Show All Data
            foreach(string data in arrayList)
            {
                MessageBox.Show(txtTextbox.Text = data);
            }

            //Count Member
            MessageBox.Show("Number of Member: " +" "+arrayList.Count.ToString());
        }

        private void txtTextbox_Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
