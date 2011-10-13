using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PBCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int PointsRemaining;
        private int StartingPointValue;
        private enum Stats
        {
            Str = 0,
            Con = 1,
            Dex = 2,
            Int = 3,
            Wis = 4,
            Cha = 5
        };
        private int[] CurrentStats;

        public MainWindow()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 3;
            resetStats(pointsFromCombo());
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            resetStats(pointsFromCombo());
        }

        private int pointsFromCombo()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return 15;
                case 1:
                    return 20;
                case 2:
                    return 22;
                case 3:
                    return 25;
                case 4:
                    return 28;
                case 5:
                    return 32;
            }
            return 25;
        }
        private void resetStats(int val)
        {
            StartingPointValue = val;
            PointsRemaining = StartingPointValue;
            CurrentStats = new int[6] { 8, 8, 8, 8, 8, 8 };

            currentPoints.Text = PointsRemaining.ToString()+" ";
            updateScores();
        }
        private void updateScores()
        {
            StrVal.Text = CurrentStats[0].ToString();
            DexVal.Text = CurrentStats[1].ToString();
            ConVal.Text = CurrentStats[2].ToString();
            IntVal.Text = CurrentStats[3].ToString();
            WisVal.Text = CurrentStats[4].ToString();
            ChaVal.Text = CurrentStats[5].ToString();
        }
    }
}
