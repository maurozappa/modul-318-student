using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
  class Wörtervollständigung
  {

    private static Transport _transport = new Transport();


    public static void AddSuggestions(ComboBox VoncomboBox)
    {
      try
      {
        List<string> temp = new List<string>();
        foreach (var station in _transport.GetStations(VoncomboBox.Text).StationList)
        {
          temp.Add(station.Name);
        }

        if (temp.Count != 0 && temp.First() != null)
        {
          VoncomboBox.Items.Clear();
          VoncomboBox.Items.Add(VoncomboBox.Text);
          VoncomboBox.Items.AddRange(temp.ToArray());
          if (VoncomboBox.DroppedDown == false)
          {
            VoncomboBox.DroppedDown = true;
          }
          VoncomboBox.SelectionStart = VoncomboBox.Text.Length;
        }
        else
        {
          VoncomboBox.DroppedDown = false;
        }
      }
      catch { }
    }

  }
}
