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
             //изменение цвета и размера текста
            DoubleAnimation FSA = new DoubleAnimation();
            FSA.From = 64;
            FSA.To = 112;
            FSA.Duration = TimeSpan.FromSeconds(5);
            FSA.RepeatBehavior = RepeatBehavior.Forever;
            FSA.AutoReverse = true;
            MainTxt.BeginAnimation(FontSizeProperty, FSA);

            ColorAnimation BA = new ColorAnimation(); // создание объекта для настройки
            ColorConverter CC = new ColorConverter(); // создание объекта для конвертации
            Color Cstart = (Color)CC.ConvertFrom("#ffffff"); // присваивание начального
            MainTxt.Foreground = new SolidColorBrush(Cstart); // закрашивание эл-та
            BA.From = Cstart; // начальное значение свойства
            BA.To = (Color)CC.ConvertFrom("#1CD9CD"); // конечное значение
            BA.Duration = TimeSpan.FromSeconds(7);
            MainTxt.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, BA);

            //изменение ширины, границ и цвета кнопки
            ThicknessAnimation MA = new ThicknessAnimation(); // анимация границ
            MA.From = new Thickness(30, 30, 30, 30);
            MA.To = new Thickness(0, 0, 0, 0);
            MA.Duration = TimeSpan.FromSeconds(3);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            btnTraining.BeginAnimation(MarginProperty, MA);

            DoubleAnimation doubleAnimationHeight = new DoubleAnimation();
            doubleAnimationHeight.From = 15;
            doubleAnimationHeight.To = 40;
            doubleAnimationHeight.Duration = TimeSpan.FromSeconds(2);
            doubleAnimationHeight.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimationHeight.AutoReverse = true;
            btnTraining.BeginAnimation(HeightProperty, doubleAnimationHeight);

            //DoubleAnimation WA = new DoubleAnimation(); // создание объекта для настройки
            //WA.From = 50; // начальное значение свойства
            //WA.To = 100; // конечное значение свойства
            //WA.Duration = TimeSpan.FromSeconds(2); // продолжительность анимации (в
            //WA.RepeatBehavior = RepeatBehavior.Forever; // бесконечность анимации
            //WA.AutoReverse = true; // воспроизведение временной шкалы в обратном порядке
            //btnTraining.BeginAnimation(WidthProperty, WA); // «навешивание» анимации на свойство ширины
        }
    }
}
