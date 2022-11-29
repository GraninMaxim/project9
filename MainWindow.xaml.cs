using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace project9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        Subject subject;

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string lessonName = inputLessonName.Text;
                string lecturerName = inputLecturerName.Text;
                int audienceNumber = Convert.ToInt32(inputAudienceNumber.Text);
                int hoursCount = Convert.ToInt32(inputHoursCount.Text);
                subject = new Subject(lessonName, lecturerName, audienceNumber, hoursCount);
                dataGrid.Items.Add(subject);
                Clear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            inputLessonName.Clear();
            inputLecturerName.Clear();
            inputAudienceNumber.Clear();
            inputHoursCount.Clear();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int findLecturer = Convert.ToInt32(findNumber.Text);
                string res = $"В аудитории №{findLecturer} работают: \r\n";
                for (int i = 0; i < dataGrid.Items.Count; i++)
                {
                    subject = (Subject)dataGrid.Items[i];
                    if (subject.AudienceNumber == findLecturer)
                    {
                        res += subject.LecturerName + "\r\n";
                    }
                    result.Text = res;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void About_Program_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заполнить таблицу на 5 предметов с полями: предмет, ФИО лектора, номер" +
                "аудитории, кол-во часов в семестре. Вывести результат на экран. Вывести список " +
                "лекторов работающих в заданной аудитории.", "Cправка", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
