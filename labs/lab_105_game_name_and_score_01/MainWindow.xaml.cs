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
using System.IO;
namespace lab_105_game_name_and_score_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // static string fileName = @"C:\2019-02-c-sharp-labs\labs\lab_105_game_name_and_score_01\bin\Debug\GameText.txt";

        public MainWindow()
        {
            InitializeComponent();
            string fileObj = @"C:\2019-02-c-sharp-labs\labs\lab_105_game_name_and_score_01\bin\Debug\GameText.txt";
            string[] list = File.ReadAllLines(fileObj);
            NameBox.Text = list[1];
            Level.Text = list[2];
            Score.Text = list[3];
        }
        
       
        
        void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = @"C:\2019-02-c-sharp-labs\labs\lab_105_game_name_and_score_01\bin\Debug\GameText.txt";
            string name = NameBox.Text;
            string tLevel = Level.Text;
            string tScore = Score.Text;
            string[] content = { "--------------", name, tLevel, tScore };
            System.IO.File.WriteAllLines(fileName,content);
    
        }


        //private void SaveButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string fileName = @"C:\2019-02-c-sharp-labs\labs\lab_105_game_name_and_score_01\bin\Debug\WriteText.txt";
        //    string name = NameBox.Text.ToString();
        //    string tLevel = Level.Text.ToString();
        //    string tScore = Score.Text.ToString();
        //    string[] content = { "--------------", name, tLevel, tScore };

        //    System.IO.File.AppendAllLines(fileName, content);

        //    if (!File.Exists(fileName))
        //    {
        //        System.IO.File.AppendAllLines(fileName, content);
        //    }

        //}
        //create a gaming homepage 
        // gamer name (saved to a text file)
        // level reached
        // top score
        // prize for the best presented interface 

    }
}
