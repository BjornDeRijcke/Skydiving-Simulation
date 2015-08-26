using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skydiving.Logica;

namespace Skydiving {
    public partial class Form1 : Form {

        private Timer timer;
        private RenderManager rm;
        bool parachute = false;

        public Form1() {
            InitializeComponent();
            InitTimer();
        }

        #region Timer

        private void InitTimer() {
            timer = new Timer();
            timer.Interval = 10; // msec, f = 200 Hz;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e) {
            this.display.Invalidate(); // force redraw (& paint event);
        }

        #endregion Timer

        #region Display

        private void display_Paint(object sender, PaintEventArgs e) {
            if (rm == null) {
                e.Graphics.Clear(Color.Azure);
                reset_labels();
            }
            else {
                rm.Render(timer.Interval / 1000f, e.Graphics, parachute);
                update_labels();
            }
        }

        private void update_labels() {
            this.label_FG.Text = "" + rm.GetValues()[4];
            this.label_FW.Text = "" + rm.GetValues()[3];
            this.label_hoogte.Text = "" + rm.GetValues()[2];
            this.label_snelheid.Text = "" + rm.GetValues()[1];
            this.label_versnelling.Text = "" + rm.GetValues()[0];
        }

        private void reset_labels() {
            this.label_FG.Text = "";
            this.label_FW.Text = "";
            this.label_hoogte.Text = "";
            this.label_snelheid.Text = "";
            this.label_versnelling.Text = "";
        }

        #endregion

        private void button_start_Click(object sender, EventArgs e) {
            if (rm == null) {
                rm = new RenderManager(display.Height, display.Width, 1000, display.Width);
                rm.InsertPhysicsValues(700, Double.Parse(this.textBox_zwaartekracht.Text, CultureInfo.InvariantCulture), Double.Parse(this.textBox_massadichtheid.Text, CultureInfo.InvariantCulture), Single.Parse(this.textBox_massa.Text, CultureInfo.InvariantCulture), Single.Parse(this.textBox_weerstandcoëficient.Text, CultureInfo.InvariantCulture), Double.Parse(this.textBox_oppervlakte.Text, CultureInfo.InvariantCulture));
                timer.Interval = 1000 / Int32.Parse(this.textBox_updateFreq.Text);
            }

            this.timer.Enabled = true;
            this.button_stop.Enabled = true;
            this.button_start.Enabled = false;
            this.button_parachute.Enabled = true;

            // invoervelden
            this.textBox_massa.Enabled =
                this.textBox_massadichtheid.Enabled =
                    this.textBox_oppervlakte.Enabled =
                        this.textBox_updateFreq.Enabled =
                            this.textBox_weerstandcoëficient.Enabled =
                                this.textBox_zwaartekracht.Enabled =
                                    this.textBox1.Enabled = false;
        }

        private void button_stop_Click(object sender, EventArgs e) {
            this.timer.Enabled = false;
            this.button_stop.Enabled = false;
            this.button_start.Enabled = true;
            this.button_parachute.Enabled = false;
        }

        private void button_reset_Click(object sender, EventArgs e) {
            rm = null;

            this.timer.Enabled = false;
            this.button_stop.Enabled = false;
            this.button_start.Enabled = true;
            this.button_parachute.Enabled = false;
            this.parachute = false;

            reset_labels();
            this.display.Invalidate(); // force redraw (& paint event);

            // invoervelden
            this.textBox_massa.Enabled =
                this.textBox_massadichtheid.Enabled =
                    this.textBox_oppervlakte.Enabled =
                        this.textBox_updateFreq.Enabled =
                            this.textBox_weerstandcoëficient.Enabled =
                                this.textBox_zwaartekracht.Enabled =
                                    this.textBox1.Enabled = true;
        }

        private void button_parachute_Click(object sender, EventArgs e) {
            rm.UpdateArea(Double.Parse(this.textBox1.Text, CultureInfo.InvariantCulture));
            this.button_parachute.Enabled = false;
            this.parachute = true;
        }

        #region infoclick

        private void pictureBox_info_object_Click(object sender, EventArgs e) {
            MessageBox.Show("De massa van een object bepaalt de zwaartekracht, Fg. Hoe hoger de massa hoe hoger de eindsnelheid zal zijn.\n\nDe weerstandscoëficient van een object bepaald in welke mate het de omgevingsstof doorkliefd. Hoe lager deze waarde is hoe aerodynamischer het object. Enkele voorbeeldswaarden:\n0.04 (regendruppelmodel - in lucht)\n0.35 (mens, verticaal - in lucht)\n0.42 (halve bol - in lucht)\n0.47 (bol - in lucht)\n0.50 (kegel - in lucht)\n0.82 (Cilinder - in lucht)\n1.05 (kubus - in lucht)\n1.10 (mens, horizontaal - in lucht)\n\nDe oppervlakte van de doorsnede dwars op de val richting (in dit geval horizontaal) is van belang voor het berekenen van de luchtweerstand Fw. Hoe groter de oppervlakte van het object, hoe meer weerstand en hoe langer de eindsnelheid. Voor een rechtopstaande mens is de ongeveer 0,2m², voor een liggende mens 1m².", "Object informatie");
        }

        private void pictureBox_info_omgeving_Click(object sender, EventArgs e) {
            MessageBox.Show("De valversnelling stelt de versnelling voor die een object ondervind t.g.v. de massa van een hemellichaam. Deze waarde is niet overal op het hemellichaam gelijk (afhankelijk van de dikte van de korst, etc.). Op aarde is deze gemiddeld gezien 9,80665.\n\nDe massadichtheid van de omgevingsstof is in deze simulatie ook van belang, ze stel immers de draagkracht van de stof voor per kubike meter. Voor lucht is deze waarde ongeveer 1,293.", "Omgevingsinformatie");
        }

        private void pictureBox_info_Simulatie_Click(object sender, EventArgs e) {
            MessageBox.Show("Hier kunt u instellen hoe vaak per seconde een update plaatsvind en hoe groot de parachute is.", "Simulatie informatie");
        }

        #endregion

        #region Keypress

        // Laat enkel toe om nummers in te typen
        // ref: http://stackoverflow.com/a/463335
        private void textBox_zwaartekracht_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox_massadichtheid_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox_massa_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox_weerstandcoëficient_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox_oppervlakte_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBox_updateFreq_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }
        #endregion
    }
}
