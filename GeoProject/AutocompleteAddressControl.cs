using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoProject
{
    
    public partial class AutocompleteAddressControl : UserControl
    {
        private List<AutoComplete> autoList;
        public AutocompleteAddressControl()
        {
            InitializeComponent();

            //AutoComplete.DisplayMember = "Name";
            //AutoComplete.ValueMember = "placeid";

          //  radAutoCompleteBox.AutoCompleteDisplayMember = "Name";
           // radAutoCompleteBox.AutoCompleteValueMember = "placeid";
           // radAutoCompleteBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.AutoComplete.box.MouseClick += new MouseEventHandler(this.ListBox_MouseClickSelectedItem);
        }

        private void ListBox_MouseClickSelectedItem(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(AutoComplete.SelectedItem);
            var auto = (AutoComplete)AutoComplete.SelectedItem;
            if (auto == null && AutoComplete.PreviousSelectedItem != null) {
                auto = (AutoComplete)AutoComplete.PreviousSelectedItem;
            }

            if (auto != null) {
                var placeid = auto.placeid;
                if (!string.IsNullOrEmpty(placeid)){
                    var details = GoogleApi.get_place_details(placeid);

                    if (details != null) {
                        StrNum.Text = details.StreetNumber;
                        StrAddress.Text = details.Route;
                        City.Text = details.City;
                        State.Text = details.State;
                        ZipCode.Text = details.Zipcode;
                        Country.Text = details.Country;
                    }
                }
            }

        }

        //private void AutoComplete_TextChanged(object sender, EventArgs e)
        //{
        //    var values = GoogleApi.AutoCompletes(AutoComplete.Text);
        //    AutoComplete.Items.Clear();
        //    AutoComplete.Items.AddRange(values.ToArray());
        //}

        //private void AutoComplete_Match(object sender, CustomCompleteTextBox.MatchEventArgs e)
        //{
        //    AutoComplete obj = e.Item as AutoComplete;
        //    if (obj.name.ToLower().StartsWith(e.MatchText.ToLower()))
        //    {
        //        e.MatchResult = true;
        //    }
        //}

        private void radAutoCompleteBox_TextChanged_1(object sender, EventArgs e)
        {
           // var values = GoogleApi.AutoCompletes(radAutoCompleteBox.Text);//.Select (x => x.name);

           // autoList = values;
           // radAutoCompleteBox.AutoCompleteItems.Clear();
           // radAutoCompleteBox.AutoCompleteItems.AddRange(autoList.Select(x => x.name));
        }

        private void radAutoCompleteBox_Leave(object sender, EventArgs e)
        {
            if (autoList.Count > 0) {
                //var t = radAutoCompleteBox.Text.ToString();
                var item = autoList.FirstOrDefault();
                if (item != null) {
                    var placeid = item.placeid;
                    if (!string.IsNullOrEmpty(placeid))
                    {
                        var details = GoogleApi.get_place_details(placeid);

                        if (details != null)
                        {
                            StrNum.ResetText();
                            StrAddress.ResetText();
                            City.ResetText();
                            State.ResetText();
                            ZipCode.ResetText();
                            Country.ResetText();

                            StrNum.Text = details.StreetNumber;
                            StrAddress.Text = details.Route;
                            City.Text = details.City;
                            State.Text = details.State;
                            ZipCode.Text = details.Zipcode;
                            Country.Text = details.Country;
                        }
                    }
                }
            }
        }

        //private void comboBoxEdit_TextChanged(object sender, EventArgs e)
        //{
        //    var values = GoogleApi.AutoCompletes(comboBoxEdit.Text);//.Select (x => x.name);

        //    autoList = values;

        //    List<string> nameList = autoList.Select(x => x.name).ToList();
        //    comboBoxEdit.Properties.Items.Clear();
        //    comboBoxEdit.Properties.Items.AddRange(nameList);
        //    comboBoxEdit.ShowPopup();
        //}

        //private void comboBoxEdit_SelectedValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBoxEdit_MouseClick(object sender, MouseEventArgs e)
        //{

        //}

        //private void comboBoxEdit_QueryCloseUp(object sender, CancelEventArgs e)
        //{
        //    if (autoList.Count > 0)
        //    {
        //        var t = comboBoxEdit.Text.ToString();
        //        var item = autoList.FirstOrDefault();
        //        if (item != null)
        //        {
        //            var placeid = item.placeid;
        //            if (!string.IsNullOrEmpty(placeid))
        //            {
        //                var details = GoogleApi.get_place_details(placeid);

        //                if (details != null)
        //                {
        //                    StrNum.ResetText();
        //                    StrAddress.ResetText();
        //                    City.ResetText();
        //                    State.ResetText();
        //                    ZipCode.ResetText();
        //                    Country.ResetText();

        //                    StrNum.Text = details.StreetNumber;
        //                    StrAddress.Text = details.Route;
        //                    City.Text = details.City;
        //                    State.Text = details.State;
        //                    ZipCode.Text = details.Zipcode;
        //                    Country.Text = details.Country;
        //                }
        //            }
        //        }
        //    }
        //}



    }
}
