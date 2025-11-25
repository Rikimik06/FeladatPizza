using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PizzaRendeles
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void RendelesClick(object sender, RoutedEventArgs e)
		{
			string teszta = (lbTesztak.SelectedItem as ListBoxItem)?.Content.ToString()
							?? "Nincs kiválasztva";

			string meret = (cbMeret.SelectedItem as ComboBoxItem).Content.ToString();

			List<string> feltetek = new List<string>();
			if (chSajt.IsChecked == true) feltetek.Add("Sajt");
			if (chSonka.IsChecked == true) feltetek.Add("Sonka");
			if (chGomba.IsChecked == true) feltetek.Add("Gomba");
			if (chOlivabogyo.IsChecked == true) feltetek.Add("Olívabogyó");
			if (chKukorica.IsChecked == true) feltetek.Add("Kukorica");

			string feltetSzoveg = feltetek.Count > 0 ? string.Join(", ", feltetek)
													 : "Nincs plusz feltét";

			string atvetel = rbHazhoz.IsChecked == true
				? "Házhozszállítás"
				: "Személyes átvétel";

			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Tészta: {teszta}");
			sb.AppendLine($"Méret: {meret}");
			sb.AppendLine($"Feltétek: {feltetSzoveg}");
			sb.AppendLine($"Átvételi mód: {atvetel}");

			txtOsszegzes.Text = sb.ToString();
		}
	}
}
