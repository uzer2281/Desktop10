using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes; 

namespace MinecraftDungeonMazeGenerator
{
    public partial class MainWindow : Window
    {
        private int[,] maze = new int[20, 20]; 
        private const int Size = 20; 

        public MainWindow()
        {
            InitializeComponent();
            GenerateMaze();
            DrawMaze();
        }

        private void GenerateMaze()
        {
           
            Random r = new Random();

          
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    maze[i, j] = r.Next(2); 
                }
            }
        }

        private void DrawMaze()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    var rect = new Rectangle
                    {
                        Width = 20,
                        Height = 20,
                        Fill = maze[i, j] == 0 ? Brushes.Black : Brushes.White
                    };
                    Canvas.SetTop(rect, i * 20);
                    Canvas.SetLeft(rect, j * 20);
                    MainCanvas.Children.Add(rect);
                }
            }
        }
    }
}