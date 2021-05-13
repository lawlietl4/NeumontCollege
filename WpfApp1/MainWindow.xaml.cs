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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum States { draw, erase };
        States state = States.draw;
        int size = 10;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.Strokes.Clear();
            MessageBox.Show("You have pressed the clear button");
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Now the window will be closed");
            Close();
        }
        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {

        }
        private void incBrush_Click(object sender, RoutedEventArgs e)
        {
            size += 5;
            inkCanvas1.DefaultDrawingAttributes.Width = size;
            inkCanvas1.DefaultDrawingAttributes.Height = size;
            MessageBox.Show("Brush size increased!");
        }
        private void decBrush_Click(object sender, RoutedEventArgs e)
        {
            size -= 5;
            inkCanvas1.DefaultDrawingAttributes.Width = size;
            inkCanvas1.DefaultDrawingAttributes.Height = size;
            MessageBox.Show("Brush size decreased!");
        }

        private void redBtn_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(255,0,0);
            MessageBox.Show("Brush color changed to RED!");
        }
        private void greenBtn_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(0, 255, 0);
            MessageBox.Show("Brush color changed to GREEN!");
        }
        private void blueBtn_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 255);
            MessageBox.Show("Brush color changed to BLUE!");
        }

        private void eraseBtn_Click(object sender, RoutedEventArgs e)
        {
            state = States.erase;
            StateMachine();
        }
        private void StateMachine()
        {
            if (state == States.erase)
            {
                inkCanvas1.DefaultDrawingAttributes.Width = size;
                inkCanvas1.DefaultDrawingAttributes.Height = size;
                inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
                MessageBox.Show("Eraser in use!");
            }
            else if (state == States.draw)
            {
                inkCanvas1.DefaultDrawingAttributes.Width = size;
                inkCanvas1.DefaultDrawingAttributes.Height = size;
                inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
                MessageBox.Show("Pen in use!");
            }
        }

        private void DrawBtn_Click(object sender, RoutedEventArgs e)
        {
            state = States.draw;
            StateMachine();
        }
    }
}
