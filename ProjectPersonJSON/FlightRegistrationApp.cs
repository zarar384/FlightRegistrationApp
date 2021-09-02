using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjectPersonJSON
{

    public partial class FlightRegistrationApp : Form
    {
        JsonProperties jsonProperties = new JsonProperties();
        public FlightRegistrationApp()
        {
            InitializeComponent();
        }
        private void CleanInput()
        {
            // Guid orderID, string sex, string name, string surname,
            // string middleName, string email, DateTime dateBirth, string citizenship,
            //int numberPas, int numberPassanger, DateTime validity, string from, string where,
            //DateTime dateOne, DateTime dateTwo

            NameText.Text = string.Empty;
            EmailText.Text = string.Empty;
            OrderCompleted.Checked = false;
            NameText.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                MessageBox.Show("Enter your name");
                return;
            }
            else if (SurnameText.Text == "")
            {
                MessageBox.Show("Enter your surname");
                return;
            }
            else if (SexText.Text == "")
            {
                MessageBox.Show("Choose your gender");
                return;
            }
            else if (EmailText.Text == "")
            {
                MessageBox.Show("Enter your mail");
                return;
            }
            else if (NumberPasText.Text == "NХХХХХХХХХ")
            {
                MessageBox.Show("Enter your passport number");
                return;
            }
            else if (FromText.Text == "From?")
            {
                MessageBox.Show("Choose where you are flying from");
                return;
            }
            else if (WhereText.Text == "Where?")
            {
                MessageBox.Show("Choose where you are flying");
                return;
            }
            else
            {
                JsonPropertie jsonPropertie = new JsonPropertie(Guid.NewGuid(), SexText.Text, NameText.Text, SurnameText.Text,
                MiddleNameText.Text, EmailText.Text, DateBirthText.Value, CitizenshipText.Text, int.Parse(NumberPasText.Text), int.Parse(NumberPassangerText.Text),
                ValidityText.Value, FromText.Text, WhereText.Text, DateOneText.Value, DateTwoText.Value, OrderCompleted.Checked);

                Add(jsonPropertie);

                CleanInput();
            }
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUser.SelectedItems.Count == 1)
            {
                JsonPropertie jsonPropertie = (JsonPropertie)listUser.SelectedItems[0].Tag;

                if (jsonProperties != null)
                {
                    SexText.Text = jsonPropertie.sex;
                    NameText.Text = jsonPropertie.name;
                    SurnameText.Text = jsonPropertie.surname;
                    MiddleNameText.Text = jsonPropertie.middleName;
                    EmailText.Text = jsonPropertie.email;
                    DateBirthText.Value = jsonPropertie.dateBirth;
                    CitizenshipText.Text = jsonPropertie.citizenship;
                    NumberPasText.Text = jsonPropertie.numberPas.ToString();
                    NumberPassangerText.Text = jsonPropertie.numberPassanger.ToString();
                    ValidityText.Value = jsonPropertie.validity;
                    OrderCompleted.Checked = jsonPropertie.orderCompleted;
                    FromText.Text = jsonPropertie.from;
                    WhereText.Text = jsonPropertie.where;
                    DateOneText.Value = jsonPropertie.dateOne;
                    DateTwoText.Value = jsonPropertie.dateTwo;
                }
            }
            else if (listUser.SelectedItems.Count == 0)
            {
                CleanInput();
            }
        }

        private void SerializedJson(JsonProperties productList)
        {
            File.WriteAllText("myJsconProperties.json", JsonConvert.SerializeObject(productList));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            JsonProperties jsonProperties = new JsonProperties();


            foreach (ListViewItem item in listUser.Items)
            {
                if (item.Tag != null)
                {
                    jsonProperties.ProductList.Add((JsonPropertie)item.Tag);
                }
                SerializedJson(jsonProperties);
            }
        }

        private void Add(JsonPropertie jsonPropertie)
        {
            ListViewItem LVI = new ListViewItem(jsonPropertie.name);

            LVI.Tag = jsonPropertie;
            listUser.Items.Add(LVI);
        }
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            CleanInput();
            JsonProperties jsonProperties = JsonConvert.DeserializeObject<JsonProperties>(File.ReadAllText("myJsconProperties.json"));

            foreach (JsonPropertie jsonPropertie in jsonProperties.ProductList)
            {
                Add(jsonPropertie);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string jsonData = File.ReadAllText("myJsconProperties.json");
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(@"{ '?xml': { '@version': '1.0', '@standalone': 'no' }, 'root': " + jsonData + "}");
            doc.Save("myProject.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FromText.Items.AddRange(new string[] { "Nowhere", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bangladesh", "Barbados", "Bahamas", "Bahrain", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "British Indian Ocean Territory", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Coconut (Keeling) Islands", "Colombia", "Comoros", "Congo-Brazzaville", "Congo-Kinshasa", "Cook Islands", "Costa Rica", "Croatia", " Kura?JSC", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "El Salvador", "Egypt", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", " Federated States of Micronesia", "Fiji", "Finland", "France", "French Guiana", "French Polynesia", "French Southern Lands", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard and McDonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn Islands", "Poland", "Portugal", "Puerto Rico", "Qatar", "European Union", "Romania", "Russia", "Rwanda", "Saint Bart-Lemi", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon", "Saint Vincent", "Samoa", "San Marino", " About That? and Pr?ncipe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia", "South Korea", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and Jan Mayen", "Sweden", "Swaziland", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican", "Vietnam", "Venezuela", "Wallis and Futuna", "Western Sahara", " Yemen", " Zambia", " Zimbabwe", "Nowhere" });
            WhereText.Items.AddRange(new string[] { "Nowhere", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bangladesh", "Barbados", "Bahamas", "Bahrain", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "British Indian Ocean Territory", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Coconut (Keeling) Islands", "Colombia", "Comoros", "Congo-Brazzaville", "Congo-Kinshasa", "Cook Islands", "Costa Rica", "Croatia", " Kura?JSC", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "El Salvador", "Egypt", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", " Federated States of Micronesia", "Fiji", "Finland", "France", "French Guiana", "French Polynesia", "French Southern Lands", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard and McDonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn Islands", "Poland", "Portugal", "Puerto Rico", "Qatar", "European Union", "Romania", "Russia", "Rwanda", "Saint Bart-Lemi", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon", "Saint Vincent", "Samoa", "San Marino", " About That? and Pr?ncipe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia", "South Korea", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and Jan Mayen", "Sweden", "Swaziland", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican", "Vietnam", "Venezuela", "Wallis and Futuna", "Western Sahara", " Yemen", " Zambia", " Zimbabwe", "Nowhere" });
            CitizenshipText.Items.AddRange(new string[] { "Other", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bangladesh", "Barbados", "Bahamas", "Bahrain", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "British Indian Ocean Territory", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Coconut (Keeling) Islands", "Colombia", "Comoros", "Congo-Brazzaville", "Congo-Kinshasa", "Cook Islands", "Costa Rica", "Croatia", " Kura?JSC", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "El Salvador", "Egypt", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", " Federated States of Micronesia", "Fiji", "Finland", "France", "French Guiana", "French Polynesia", "French Southern Lands", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard and McDonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn Islands", "Poland", "Portugal", "Puerto Rico", "Qatar", "European Union", "Romania", "Russia", "Rwanda", "Saint Bart-Lemi", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon", "Saint Vincent", "Samoa", "San Marino", " About That? and Pr?ncipe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia", "South Korea", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and Jan Mayen", "Sweden", "Swaziland", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican", "Vietnam", "Venezuela", "Wallis and Futuna", "Western Sahara", " Yemen", " Zambia", " Zimbabwe", "Other" });
            SexText.Items.AddRange(new string[] { "Муж.", "Жен." });

            FromText.Text = "From?";
            FromText.ForeColor = Color.Gray;

            WhereText.Text = "Where?";
            WhereText.ForeColor = Color.Gray;

            CitizenshipText.Text = "Russia";
            CitizenshipText.ForeColor = Color.Gray;

            NumberPasText.Text = "NХХХХХХХХХ";
            NumberPasText.ForeColor = Color.Gray;

            Random rnd = new Random();
            int randomN = rnd.Next(1, 100000);
            NumberPassangerText.Text = randomN.ToString();

            buttonAdd.Enabled = false;
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            if (FromText.Text == "From?")
            {
                FromText.Text = "";
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (FromText.Text == "")
            {
                FromText.Text = "From?";
            }
            if (FromText.Text == "Nowhere")
            {
                FromText.Text = "From?";
            }
        }

        private void comboBox4_Enter(object sender, EventArgs e)
        {
            if (WhereText.Text == "Where?")
            {
                WhereText.Text = "";
                WhereText.ForeColor = Color.Black;
            }
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            if (WhereText.Text == "")
            {
                WhereText.Text = "Where?";
                WhereText.ForeColor = Color.Gray;
            }
            if (WhereText.Text == "Nowhere")
            {
                WhereText.Text = "Where?";
                WhereText.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (CitizenshipText.Text == "Other")
            {
                CitizenshipText.Text = "";
                CitizenshipText.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (CitizenshipText.Text == "")
            {
                CitizenshipText.Text = "Russia";
                CitizenshipText.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (NumberPasText.Text == "NХХХХХХХХХ")
            {
                NumberPasText.Text = "";
                NumberPasText.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (NumberPasText.Text == "")
            {
                NumberPasText.Text = "NХХХХХХХХХ";
                NumberPasText.ForeColor = Color.Gray;
            }
        }

        private void OrderCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderCompleted.Checked == true)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }
    }
}
