using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tiny_Explorers
{
    public partial class FrmGenerirajRacun : Form

    {
        private List<Dijete> listaDjece;
        private FrmMeniRavnateljice mainForm;
        private int DohvatiBrojDanaUMjesecu(string mjesec)
        {
            var mjeseci = new Dictionary<string, int>
    {
        { "Siječanj", 1 }, { "Veljača", 2 }, { "Ožujak", 3 }, { "Travanj", 4 },
        { "Svibanj", 5 }, { "Lipanj", 6 }, { "Srpanj", 7 }, { "Kolovoz", 8 },
        { "Rujan", 9 }, { "Listopad", 10 }, { "Studeni", 11 }, { "Prosinac", 12 }
    };

            if (!mjeseci.TryGetValue(mjesec, out int brojMjeseca))
                throw new ArgumentException("Nepoznat mjesec: " + mjesec);
            int godina = DateTime.Now.Year;
            return DateTime.DaysInMonth(godina, brojMjeseca);
        }



        public FrmGenerirajRacun(FrmMeniRavnateljice parent)
        {
            InitializeComponent();
            mainForm = parent;

            LoadComboValues();
            cbGenerirajRacunDijete.SelectedIndexChanged += cbGenerirajRacunDijete_SelectedIndexChanged;
            cbGenerirajRacunSkupina.Enabled = false;
            cbGenerirajRacunRoditelj.Enabled = false;
            chkGenerirajRacunDijeteSTeskocamaDa.Enabled = false;
            chkGenerirajRacunDijeteSTeskocamaNe.Enabled = false;

            cbGenerirajRacunMjesec.Enabled = false;
            cbGenerirajRacunSatiBoravka.Enabled = false;

            cbGenerirajRacunSkupina.SelectedIndexChanged += UpdatePrices;
            cbGenerirajRacunSatiBoravka.TextChanged += UpdatePrices;
            chkGenerirajRacunDijeteSTeskocamaDa.CheckedChanged += UpdatePrices;
            txtGenerirajRacunIzostanci.TextChanged += UpdatePrices;

            txtGenerirajRacunIzostanci.KeyPress += (s, e) =>
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            };
        }

        private void LoadComboValues()
        {
            cbGenerirajRacunMjesec.Items.AddRange(new[]
            {
                "Siječanj", "Veljača", "Ožujak", "Travanj", "Svibanj", "Lipanj",
                "Srpanj", "Kolovoz", "Rujan", "Listopad", "Studeni", "Prosinac"
            });
            cbGenerirajRacunSatiBoravka.Items.AddRange(new[] { "6", "10" });

            listaDjece = DjecaRepository.GetDjeca()
                            .OrderBy(d => d.Prezime)
                            .ThenBy(d => d.Ime) 
                            .ToList();

            foreach (var dijete in listaDjece)
            {
                cbGenerirajRacunDijete.Items.Add(new ComboBoxItem
                {
                    Text = $"{dijete.Ime} {dijete.Prezime}",
                    Value = dijete.Id_dijete
                });
            }
        }

        private void UpdatePrices(object sender, EventArgs e)
        {
            if (!int.TryParse(cbGenerirajRacunSatiBoravka.Text, out int satiBoravka) ||
                !int.TryParse(txtGenerirajRacunIzostanci.Text, out int izostanci) ||
                cbGenerirajRacunMjesec.SelectedItem == null ||
                string.IsNullOrEmpty(cbGenerirajRacunSkupina.Text))
            {
                ClearPriceFields();
                return;
            }

            string mjesec = cbGenerirajRacunMjesec.SelectedItem.ToString();
            int maxDana = DohvatiBrojDanaUMjesecu(mjesec);
            if (izostanci > maxDana)
            {
                MessageBox.Show($"Izostanci ne mogu biti veći od {maxDana} za mjesec {mjesec}.");
                txtGenerirajRacunIzostanci.Text = maxDana.ToString();
                return;
            }

            string skupina = cbGenerirajRacunSkupina.Text.Trim().ToLower();
            bool jeJaslicka = skupina == "jaslička";
            bool dijeteSTeskocama = chkGenerirajRacunDijeteSTeskocamaDa.Checked;

            decimal osnovnaCijena = 0m;
            if (jeJaslicka)
                osnovnaCijena = dijeteSTeskocama ? (satiBoravka == 10 ? 92m : 80m) : (satiBoravka == 10 ? 119m : 95m);
            else
                osnovnaCijena = dijeteSTeskocama ? (satiBoravka == 10 ? 66m : 55m) : (satiBoravka == 10 ? 92m : 75m);

            decimal izostanciCijena = izostanci * 1m;
            decimal ukupnaCijena = Math.Max(0, osnovnaCijena - izostanciCijena);

            txtGenerirajRacunOsnovnaCijena.Text = osnovnaCijena.ToString("F2") + " EUR";
            txtGenerirajRacunCijenaIzostanka.Text = izostanciCijena.ToString("F2") + " EUR";
            txtGenerirajRacunUkupnaCijena.Text = ukupnaCijena.ToString("F2") + " EUR";

            txtGenerirajRacunOsnovnaCijena.ReadOnly = true;
            txtGenerirajRacunCijenaIzostanka.ReadOnly = true;
            txtGenerirajRacunUkupnaCijena.ReadOnly = true;
        }



        private void ClearPriceFields()
        {
            txtGenerirajRacunOsnovnaCijena.Text = "";
            txtGenerirajRacunCijenaIzostanka.Text = "";
            txtGenerirajRacunUkupnaCijena.Text = "";
        }


        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            if (cbGenerirajRacunDijete.SelectedItem == null ||
                cbGenerirajRacunMjesec.SelectedItem == null ||
                cbGenerirajRacunSatiBoravka.SelectedItem == null)
            {
                MessageBox.Show("Molimo ispunite sva potrebna polja.");
                return;
            }

            if (cbGenerirajRacunRoditelj.Tag == null || cbGenerirajRacunDijete.Tag == null)
            {
                MessageBox.Show("Tag vrijednosti nisu postavljene.");
                return;
            }

            if (!int.TryParse(txtGenerirajRacunIzostanci.Text, out int izostanci) || izostanci < 0)
            {
                MessageBox.Show("Izostanci moraju biti nenegativan broj.");
                return;
            }

            string mjesec = cbGenerirajRacunMjesec.SelectedItem.ToString();
            int maxDana = DohvatiBrojDanaUMjesecu(mjesec);
            if (izostanci > maxDana)
            {
                MessageBox.Show($"Izostanci ne mogu biti veći od {maxDana} za mjesec {mjesec}.");
                txtGenerirajRacunIzostanci.Text = maxDana.ToString();
                return;
            }

            if (!int.TryParse(cbGenerirajRacunSatiBoravka.Text, out int satiBoravka) || (satiBoravka != 6 && satiBoravka != 10))
            {
                MessageBox.Show("Sati boravka moraju biti 6 ili 10.");
                return;
            }

            string skupina = cbGenerirajRacunSkupina.Text;
            bool dijeteSTeskocama = chkGenerirajRacunDijeteSTeskocamaDa.Checked;
            int roditeljId = (int)cbGenerirajRacunRoditelj.Tag;
            int dijeteId = (int)cbGenerirajRacunDijete.Tag;

            if (RacunPostoji(dijeteId, mjesec))
            {
                MessageBox.Show("Račun za odabrano dijete i mjesec već postoji.");
                return;
            }

            UpdatePrices(null, null);

            if (!decimal.TryParse(txtGenerirajRacunOsnovnaCijena.Text.Replace(" EUR", ""), out decimal osnovnaCijena) ||
                !decimal.TryParse(txtGenerirajRacunCijenaIzostanka.Text.Replace(" EUR", ""), out decimal izostanciCijena) ||
                !decimal.TryParse(txtGenerirajRacunUkupnaCijena.Text.Replace(" EUR", ""), out decimal ukupnaCijena))
            {
                MessageBox.Show("Greška kod izračuna cijena.");
                return;
            }

            var racun = new Racun
            {
                Mjesec = mjesec,
                Skupina = skupina,
                Izostanci = izostanci,
                Sati_boravka = satiBoravka,
                Roditelj_id = roditeljId,
                Dijete_id = dijeteId,
                Dijete_s_teskocama = dijeteSTeskocama ? "Da" : "Ne",
                Osnovna_cijena = osnovnaCijena,
                Izostanci_cijena = izostanciCijena,
                Ukupna_cijena = ukupnaCijena
            };

            SaveRacun(racun);
            MessageBox.Show("Račun uspješno generiran.");
            mainForm.OpenChildForm(new FrmPrikazSvihRacuna());
            this.Close();
        }



        private bool RacunPostoji(int dijeteId, string mjesec)
        {
            DB.OpenConnection();
            var cmd = DB.CreateCommand("SELECT COUNT(*) FROM Racun WHERE dijete_id = @dijeteId AND mjesec = @mjesec");
            cmd.Parameters.AddWithValue("@dijeteId", dijeteId);
            cmd.Parameters.AddWithValue("@mjesec", mjesec);
            int count = (int)cmd.ExecuteScalar();
            DB.CloseConnection();
            return count > 0;
        }

        private int GetNextRacunId()
        {
            DB.OpenConnection();
            var cmd = DB.CreateCommand("SELECT ISNULL(MAX(id_racun), 0) FROM Racun");
            int maxId = (int)cmd.ExecuteScalar();
            DB.CloseConnection();
            return maxId + 1;
        }

        private void SaveRacun(Racun r)
        {
            int newId = GetNextRacunId();

            DB.OpenConnection();
            var cmd = DB.CreateCommand(@"
                INSERT INTO Racun 
                (id_racun, mjesec, skupina, izostanci, sati_boravka, roditelj_id, dijete_id, dijete_s_teskocama, osnovna_cijena, izostanci_cijena, ukupna_cijena)
                VALUES 
                (@id, @mjesec, @skupina, @izostanci, @sati, @roditelj, @dijete, @teskoce, @osnovna, @umanjenje, @ukupno)
            ");
            cmd.Parameters.AddWithValue("@id", newId);
            cmd.Parameters.AddWithValue("@mjesec", r.Mjesec);
            cmd.Parameters.AddWithValue("@skupina", r.Skupina);
            cmd.Parameters.AddWithValue("@izostanci", r.Izostanci);
            cmd.Parameters.AddWithValue("@sati", r.Sati_boravka);
            cmd.Parameters.AddWithValue("@roditelj", r.Roditelj_id);
            cmd.Parameters.AddWithValue("@dijete", r.Dijete_id);
            cmd.Parameters.AddWithValue("@teskoce", r.Dijete_s_teskocama);
            cmd.Parameters.AddWithValue("@osnovna", r.Osnovna_cijena);
            cmd.Parameters.AddWithValue("@umanjenje", r.Izostanci_cijena);
            cmd.Parameters.AddWithValue("@ukupno", r.Ukupna_cijena);
            cmd.ExecuteNonQuery();
            DB.CloseConnection();
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }


        private void chkGenerirajRacunDijeteSTeskocamaDa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGenerirajRacunDijeteSTeskocamaDa.Checked)
                chkGenerirajRacunDijeteSTeskocamaNe.Checked = false;

            UpdatePrices(null, null);

        }

        private void chkGenerirajRacunDijeteSTeskocamaNe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGenerirajRacunDijeteSTeskocamaNe.Checked)
                chkGenerirajRacunDijeteSTeskocamaDa.Checked = false;

            UpdatePrices(null, null);

        }


        private void cbGenerirajRacunDijete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGenerirajRacunDijete.SelectedItem is ComboBoxItem selected)
            {
                var dijete = listaDjece.FirstOrDefault(d => d.Id_dijete == (int)selected.Value);

                if (dijete != null)
                {
                    cbGenerirajRacunSkupina.Text = dijete.NazivSkupine;
                    cbGenerirajRacunRoditelj.Text = dijete.ImeRoditelja;

                    cbGenerirajRacunRoditelj.Tag = dijete.Roditelj_id;
                    cbGenerirajRacunSkupina.Tag = dijete.Skupina_id;
                    cbGenerirajRacunDijete.Tag = dijete.Id_dijete;

                    chkGenerirajRacunDijeteSTeskocamaDa.Checked = dijete.Dijete_s_teskocama == "Da";
                    chkGenerirajRacunDijeteSTeskocamaNe.Checked = dijete.Dijete_s_teskocama == "Ne";

                    cbGenerirajRacunMjesec.Enabled = true;
                    cbGenerirajRacunSatiBoravka.Enabled = true;

                    UpdatePrices(null, null);
                }
            }
        }

    }
}
