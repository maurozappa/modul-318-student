using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransportApp
{

  public partial class Form1 : Form
  {

    ITransport transport = new Transport();
    Station stationen = new Station();
    public Form1()
    {
      InitializeComponent();
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
      if (VonComboBox.Text != "" && NachComboBox.Text != "")
      {
        dataGridViewVerbindungen.Rows.Clear();
        Connections connections = transport.GetConnections(VonComboBox.Text, NachComboBox.Text, 4, dateTimePickerDatum.Value, dateTimePickerZeit.Value);
        foreach (Connection connection in connections.ConnectionList)

        {
          dataGridViewVerbindungen.Rows.Add(new[] { connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure.Value.ToString(), connection.To.Arrival.Value.ToString(), connection.Duration });
        }
      }
      else
      {
        MessageBox.Show("Nicht genügende Informationen zur Ziel oder Reise Adresse");
      }

    }

    private void dataGridViewVerbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void SearchButtonArbeitstafel_Click(object sender, EventArgs e)
    {

      if (VonComboBoxArbeitstafel.Text != "")
      {
        dataGridViewArbeitstafel.Rows.Clear();
        DateTime time = DateTime.Now;
        StationBoardRoot connections = transport.GetStationBoard(VonComboBoxArbeitstafel.Text, "0", time, 4);
        foreach (var connection in connections.Entries)

        {
          dataGridViewArbeitstafel.Rows.Add(connection.Stop.Departure, connection.To, connection.Number);
        }
      }
      else
      {
        MessageBox.Show("Nicht genügende Informationen zur Abreise Adresse");
      }

    }

    private void searchbuttonKarte_click(object sender, EventArgs e)
    {

    }

    public void Autocomplete();


  }
 }
