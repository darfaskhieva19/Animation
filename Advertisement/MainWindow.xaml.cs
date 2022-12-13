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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Advertisement
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation FSA = new DoubleAnimation();
            FSA.From = 64;
            FSA.To = 112;
            FSA.Duration = TimeSpan.FromSeconds(5);
            FSA.RepeatBehavior = RepeatBehavior.Forever;
            FSA.AutoReverse = true;
            MainTxt.BeginAnimation(FontSizeProperty, FSA);            

            ThicknessAnimation MA = new ThicknessAnimation(); // анимация границ
            MA.From = new Thickness(30, 30, 30, 30);
            MA.To = new Thickness(0, 0, 0, 0);
            MA.Duration = TimeSpan.FromSeconds(3);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            btnTraining.BeginAnimation(MarginProperty, MA);

            DoubleAnimation doubleAnimationHeight = new DoubleAnimation();
            doubleAnimationHeight.From = 45;
            doubleAnimationHeight.To = 60;
            doubleAnimationHeight.Duration = TimeSpan.FromSeconds(2);
            doubleAnimationHeight.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimationHeight.AutoReverse = true;
            btnTraining.BeginAnimation(HeightProperty, doubleAnimationHeight);

            DoubleAnimation WA = new DoubleAnimation(); // создание объекта для настройки
            WA.From = 270; // начальное значение свойства
            WA.To = 310; // конечное значение свойства
            WA.Duration = TimeSpan.FromSeconds(5); // продолжительность анимации (в
            WA.RepeatBehavior = RepeatBehavior.Forever; // бесконечность анимации
            WA.AutoReverse = true; // воспроизведение временной шкалы в обратном порядке
            btnTraining.BeginAnimation(WidthProperty, WA); // «навешивание» анимации на свойство ширины

            ColorAnimation BC = new ColorAnimation(); // создание объекта для настройки анимации
            ColorConverter CCA = new ColorConverter(); // создание объекта для конвертации кода в цвет
            Color CAstart = (Color)CCA.ConvertFrom("#ffffff");// присваивание начального цвета эл-ту
            btnTraining.Background = new SolidColorBrush(CAstart); // закрашивание эл-та сплошным цветом
            BC.From = CAstart; // начальное значение свойства
            BC.To = (Color)CCA.ConvertFrom("#1CD9CD"); // конечное значение свойства
            BC.Duration = TimeSpan.FromSeconds(5);
            BC.AutoReverse = true;
            btnTraining.Background.BeginAnimation(SolidColorBrush.ColorProperty, BC);

            DoubleAnimation FT = new DoubleAnimation();
            FT.From = 22;
            FT.To = 24;
            FT.Duration = TimeSpan.FromSeconds(2);
            FT.RepeatBehavior = RepeatBehavior.Forever;
            FT.AutoReverse = true;
            btnTraining.BeginAnimation(FontSizeProperty, FT);

            DoubleAnimation IM = new DoubleAnimation(); 
            IM.From = 345; 
            IM.To = 360; 
            IM.Duration = TimeSpan.FromSeconds(2); 
            IM.RepeatBehavior = RepeatBehavior.Forever; 
            IM.AutoReverse = true; 
            img.BeginAnimation(WidthProperty, IM); 

            DoubleAnimation IMG = new DoubleAnimation(); 
            IMG.From = 500;
            IMG.To = 525; 
            IMG.Duration = TimeSpan.FromSeconds(2); 
            IMG.RepeatBehavior = RepeatBehavior.Forever; 
            IMG.AutoReverse = true; 
            img.BeginAnimation(HeightProperty, IMG); 
        }
    }
}
