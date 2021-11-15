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

namespace lists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "India", Team2 = "Shrilanka", Score1 = 1, Score2 = 2, Completion = 20 });
            Matches.ItemsSource = matches;
         
        }

        public class Match
        {
            public int Score1 { get; set; }
            public int Score2 { get; set; }
            public string Team1 { get; set; }
            public string Team2 { get; set; }
            public int Completion { get; set; }
        }
    }
}