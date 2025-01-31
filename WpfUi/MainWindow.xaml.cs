﻿using System;
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

namespace WpfUi
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public List<Person> people = new List<Person>();

    public MainWindow()
    {
      InitializeComponent();

      SetUpDummyData();

      myComboBox.ItemsSource = people;

      //myMedia.Play();

    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show($"Hello {firstNameText.Text}");
    }

    private void SetUpDummyData()
    {
      people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
      people.Add(new Person { FirstName = "Joe", LastName = "Smith" });
      people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
    }
  }
}
