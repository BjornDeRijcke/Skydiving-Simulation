namespace Skydiving {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_massadichtheid = new System.Windows.Forms.TextBox();
            this.label_massadichtheid = new System.Windows.Forms.Label();
            this.textBox_oppervlakte = new System.Windows.Forms.TextBox();
            this.label_eenheid_oppervlakte = new System.Windows.Forms.Label();
            this.label_oppevlakte = new System.Windows.Forms.Label();
            this.label_weerstandcoëficient = new System.Windows.Forms.Label();
            this.label_omgeving = new System.Windows.Forms.Label();
            this.label_object = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_parachute = new System.Windows.Forms.Button();
            this.label_eenheid_massa = new System.Windows.Forms.Label();
            this.textBox_massa = new System.Windows.Forms.TextBox();
            this.label_massa = new System.Windows.Forms.Label();
            this.label_eenheid_zwaartekracht = new System.Windows.Forms.Label();
            this.textBox_zwaartekracht = new System.Windows.Forms.TextBox();
            this.label_zwaartekracht = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.PictureBox();
            this.label_FW = new System.Windows.Forms.Label();
            this.label_FG = new System.Windows.Forms.Label();
            this.label_hoogte = new System.Windows.Forms.Label();
            this.label_versnelling = new System.Windows.Forms.Label();
            this.label_snelheid = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Simulatie = new System.Windows.Forms.Label();
            this.label_updatefreq = new System.Windows.Forms.Label();
            this.textBox_updateFreq = new System.Windows.Forms.TextBox();
            this.pictureBox_info_omgeving = new System.Windows.Forms.PictureBox();
            this.pictureBox_info_object = new System.Windows.Forms.PictureBox();
            this.pictureBox_info_Simulatie = new System.Windows.Forms.PictureBox();
            this.label_parachute_opp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_eenheid_para_oppervlakte = new System.Windows.Forms.Label();
            this.label_eenheid_updatefreq = new System.Windows.Forms.Label();
            this.textBox_weerstandcoëficient = new System.Windows.Forms.TextBox();
            this.label_eenheid_snelheid = new System.Windows.Forms.Label();
            this.label_eenheid_fw = new System.Windows.Forms.Label();
            this.label_eenheid_fg = new System.Windows.Forms.Label();
            this.label_eenheid_versnell = new System.Windows.Forms.Label();
            this.label_eenheid_hoogte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_omgeving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_object)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_Simulatie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "kg/m³";
            // 
            // textBox_massadichtheid
            // 
            this.textBox_massadichtheid.Location = new System.Drawing.Point(17, 96);
            this.textBox_massadichtheid.Name = "textBox_massadichtheid";
            this.textBox_massadichtheid.Size = new System.Drawing.Size(246, 20);
            this.textBox_massadichtheid.TabIndex = 41;
            this.textBox_massadichtheid.Text = "1.293";
            this.textBox_massadichtheid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_massadichtheid_KeyPress);
            // 
            // label_massadichtheid
            // 
            this.label_massadichtheid.AutoSize = true;
            this.label_massadichtheid.Location = new System.Drawing.Point(14, 80);
            this.label_massadichtheid.Name = "label_massadichtheid";
            this.label_massadichtheid.Size = new System.Drawing.Size(155, 13);
            this.label_massadichtheid.TabIndex = 40;
            this.label_massadichtheid.Text = "Massadichtheid omgevingsstof:";
            // 
            // textBox_oppervlakte
            // 
            this.textBox_oppervlakte.Location = new System.Drawing.Point(17, 250);
            this.textBox_oppervlakte.Name = "textBox_oppervlakte";
            this.textBox_oppervlakte.Size = new System.Drawing.Size(246, 20);
            this.textBox_oppervlakte.TabIndex = 39;
            this.textBox_oppervlakte.Text = "0.2";
            this.textBox_oppervlakte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_oppervlakte_KeyPress);
            // 
            // label_eenheid_oppervlakte
            // 
            this.label_eenheid_oppervlakte.AutoSize = true;
            this.label_eenheid_oppervlakte.Location = new System.Drawing.Point(269, 253);
            this.label_eenheid_oppervlakte.Name = "label_eenheid_oppervlakte";
            this.label_eenheid_oppervlakte.Size = new System.Drawing.Size(18, 13);
            this.label_eenheid_oppervlakte.TabIndex = 38;
            this.label_eenheid_oppervlakte.Text = "m²";
            // 
            // label_oppevlakte
            // 
            this.label_oppevlakte.AutoSize = true;
            this.label_oppevlakte.Location = new System.Drawing.Point(14, 234);
            this.label_oppevlakte.Name = "label_oppevlakte";
            this.label_oppevlakte.Size = new System.Drawing.Size(169, 13);
            this.label_oppevlakte.TabIndex = 37;
            this.label_oppevlakte.Text = "Oppervlakte horizontale doorsnee:";
            // 
            // label_weerstandcoëficient
            // 
            this.label_weerstandcoëficient.AutoSize = true;
            this.label_weerstandcoëficient.Location = new System.Drawing.Point(14, 194);
            this.label_weerstandcoëficient.Name = "label_weerstandcoëficient";
            this.label_weerstandcoëficient.Size = new System.Drawing.Size(113, 13);
            this.label_weerstandcoëficient.TabIndex = 35;
            this.label_weerstandcoëficient.Text = "Weerstandscoëficient:";
            // 
            // label_omgeving
            // 
            this.label_omgeving.AutoSize = true;
            this.label_omgeving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_omgeving.Location = new System.Drawing.Point(17, 18);
            this.label_omgeving.Name = "label_omgeving";
            this.label_omgeving.Size = new System.Drawing.Size(80, 20);
            this.label_omgeving.TabIndex = 34;
            this.label_omgeving.Text = "Omgeving";
            // 
            // label_object
            // 
            this.label_object.AutoSize = true;
            this.label_object.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_object.Location = new System.Drawing.Point(17, 136);
            this.label_object.Name = "label_object";
            this.label_object.Size = new System.Drawing.Size(55, 20);
            this.label_object.TabIndex = 33;
            this.label_object.Text = "Object";
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(166, 527);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(130, 23);
            this.button_stop.TabIndex = 32;
            this.button_stop.Text = "Pauzeer simulatie";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(17, 527);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(130, 23);
            this.button_start.TabIndex = 31;
            this.button_start.Text = "Start simulatie";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_parachute
            // 
            this.button_parachute.Enabled = false;
            this.button_parachute.Location = new System.Drawing.Point(17, 585);
            this.button_parachute.Name = "button_parachute";
            this.button_parachute.Size = new System.Drawing.Size(279, 23);
            this.button_parachute.TabIndex = 30;
            this.button_parachute.Text = "Parachute openen";
            this.button_parachute.UseVisualStyleBackColor = true;
            this.button_parachute.Click += new System.EventHandler(this.button_parachute_Click);
            // 
            // label_eenheid_massa
            // 
            this.label_eenheid_massa.AutoSize = true;
            this.label_eenheid_massa.Location = new System.Drawing.Point(270, 170);
            this.label_eenheid_massa.Name = "label_eenheid_massa";
            this.label_eenheid_massa.Size = new System.Drawing.Size(19, 13);
            this.label_eenheid_massa.TabIndex = 29;
            this.label_eenheid_massa.Text = "kg";
            // 
            // textBox_massa
            // 
            this.textBox_massa.Location = new System.Drawing.Point(137, 167);
            this.textBox_massa.Name = "textBox_massa";
            this.textBox_massa.Size = new System.Drawing.Size(126, 20);
            this.textBox_massa.TabIndex = 28;
            this.textBox_massa.Text = "65";
            this.textBox_massa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_massa_KeyPress);
            // 
            // label_massa
            // 
            this.label_massa.AutoSize = true;
            this.label_massa.Location = new System.Drawing.Point(14, 170);
            this.label_massa.Name = "label_massa";
            this.label_massa.Size = new System.Drawing.Size(41, 13);
            this.label_massa.TabIndex = 27;
            this.label_massa.Text = "Massa:";
            // 
            // label_eenheid_zwaartekracht
            // 
            this.label_eenheid_zwaartekracht.AutoSize = true;
            this.label_eenheid_zwaartekracht.Location = new System.Drawing.Point(270, 54);
            this.label_eenheid_zwaartekracht.Name = "label_eenheid_zwaartekracht";
            this.label_eenheid_zwaartekracht.Size = new System.Drawing.Size(31, 13);
            this.label_eenheid_zwaartekracht.TabIndex = 26;
            this.label_eenheid_zwaartekracht.Text = "m/s² ";
            // 
            // textBox_zwaartekracht
            // 
            this.textBox_zwaartekracht.Location = new System.Drawing.Point(137, 51);
            this.textBox_zwaartekracht.Name = "textBox_zwaartekracht";
            this.textBox_zwaartekracht.Size = new System.Drawing.Size(126, 20);
            this.textBox_zwaartekracht.TabIndex = 25;
            this.textBox_zwaartekracht.Text = "9.80665";
            this.textBox_zwaartekracht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_zwaartekracht_KeyPress);
            // 
            // label_zwaartekracht
            // 
            this.label_zwaartekracht.AutoSize = true;
            this.label_zwaartekracht.Location = new System.Drawing.Point(14, 54);
            this.label_zwaartekracht.Name = "label_zwaartekracht";
            this.label_zwaartekracht.Size = new System.Drawing.Size(75, 13);
            this.label_zwaartekracht.TabIndex = 24;
            this.label_zwaartekracht.Text = "Valversnelling:";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(302, 8);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(350, 600);
            this.display.TabIndex = 23;
            this.display.TabStop = false;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
            // 
            // label_FW
            // 
            this.label_FW.AutoSize = true;
            this.label_FW.Location = new System.Drawing.Point(163, 423);
            this.label_FW.Name = "label_FW";
            this.label_FW.Size = new System.Drawing.Size(35, 13);
            this.label_FW.TabIndex = 43;
            this.label_FW.Text = "label2";
            // 
            // label_FG
            // 
            this.label_FG.AutoSize = true;
            this.label_FG.Location = new System.Drawing.Point(163, 449);
            this.label_FG.Name = "label_FG";
            this.label_FG.Size = new System.Drawing.Size(35, 13);
            this.label_FG.TabIndex = 44;
            this.label_FG.Text = "label2";
            // 
            // label_hoogte
            // 
            this.label_hoogte.AutoSize = true;
            this.label_hoogte.Location = new System.Drawing.Point(163, 500);
            this.label_hoogte.Name = "label_hoogte";
            this.label_hoogte.Size = new System.Drawing.Size(35, 13);
            this.label_hoogte.TabIndex = 45;
            this.label_hoogte.Text = "label2";
            // 
            // label_versnelling
            // 
            this.label_versnelling.AutoSize = true;
            this.label_versnelling.Location = new System.Drawing.Point(163, 475);
            this.label_versnelling.Name = "label_versnelling";
            this.label_versnelling.Size = new System.Drawing.Size(35, 13);
            this.label_versnelling.TabIndex = 46;
            this.label_versnelling.Text = "label3";
            // 
            // label_snelheid
            // 
            this.label_snelheid.AutoSize = true;
            this.label_snelheid.Location = new System.Drawing.Point(163, 398);
            this.label_snelheid.Name = "label_snelheid";
            this.label_snelheid.Size = new System.Drawing.Size(35, 13);
            this.label_snelheid.TabIndex = 47;
            this.label_snelheid.Text = "label2";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(17, 556);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(279, 23);
            this.button_reset.TabIndex = 48;
            this.button_reset.Text = "Reset simulatie";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "snelheid:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 423);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 13);
            this.label.TabIndex = 50;
            this.label.Text = "Fw:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "versnelling:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Hoogte:";
            // 
            // label_Simulatie
            // 
            this.label_Simulatie.AutoSize = true;
            this.label_Simulatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Simulatie.Location = new System.Drawing.Point(17, 290);
            this.label_Simulatie.Name = "label_Simulatie";
            this.label_Simulatie.Size = new System.Drawing.Size(74, 20);
            this.label_Simulatie.TabIndex = 59;
            this.label_Simulatie.Text = "Simulatie";
            // 
            // label_updatefreq
            // 
            this.label_updatefreq.AutoSize = true;
            this.label_updatefreq.Location = new System.Drawing.Point(14, 324);
            this.label_updatefreq.Name = "label_updatefreq";
            this.label_updatefreq.Size = new System.Drawing.Size(95, 13);
            this.label_updatefreq.TabIndex = 60;
            this.label_updatefreq.Text = "Update frequentie:";
            // 
            // textBox_updateFreq
            // 
            this.textBox_updateFreq.Location = new System.Drawing.Point(137, 321);
            this.textBox_updateFreq.Name = "textBox_updateFreq";
            this.textBox_updateFreq.Size = new System.Drawing.Size(126, 20);
            this.textBox_updateFreq.TabIndex = 61;
            this.textBox_updateFreq.Text = "100";
            this.textBox_updateFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateFreq_KeyPress);
            // 
            // pictureBox_info_omgeving
            // 
            this.pictureBox_info_omgeving.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_info_omgeving.Image")));
            this.pictureBox_info_omgeving.InitialImage = null;
            this.pictureBox_info_omgeving.Location = new System.Drawing.Point(103, 24);
            this.pictureBox_info_omgeving.Name = "pictureBox_info_omgeving";
            this.pictureBox_info_omgeving.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_info_omgeving.TabIndex = 62;
            this.pictureBox_info_omgeving.TabStop = false;
            this.pictureBox_info_omgeving.Click += new System.EventHandler(this.pictureBox_info_omgeving_Click);
            // 
            // pictureBox_info_object
            // 
            this.pictureBox_info_object.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_info_object.Image")));
            this.pictureBox_info_object.InitialImage = null;
            this.pictureBox_info_object.Location = new System.Drawing.Point(103, 142);
            this.pictureBox_info_object.Name = "pictureBox_info_object";
            this.pictureBox_info_object.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_info_object.TabIndex = 63;
            this.pictureBox_info_object.TabStop = false;
            this.pictureBox_info_object.Click += new System.EventHandler(this.pictureBox_info_object_Click);
            // 
            // pictureBox_info_Simulatie
            // 
            this.pictureBox_info_Simulatie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_info_Simulatie.Image")));
            this.pictureBox_info_Simulatie.InitialImage = null;
            this.pictureBox_info_Simulatie.Location = new System.Drawing.Point(103, 295);
            this.pictureBox_info_Simulatie.Name = "pictureBox_info_Simulatie";
            this.pictureBox_info_Simulatie.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_info_Simulatie.TabIndex = 64;
            this.pictureBox_info_Simulatie.TabStop = false;
            this.pictureBox_info_Simulatie.Click += new System.EventHandler(this.pictureBox_info_Simulatie_Click);
            // 
            // label_parachute_opp
            // 
            this.label_parachute_opp.AutoSize = true;
            this.label_parachute_opp.Location = new System.Drawing.Point(15, 350);
            this.label_parachute_opp.Name = "label_parachute_opp";
            this.label_parachute_opp.Size = new System.Drawing.Size(119, 13);
            this.label_parachute_opp.TabIndex = 65;
            this.label_parachute_opp.Text = "Oppervlakte parachute:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "50";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label_eenheid_para_oppervlakte
            // 
            this.label_eenheid_para_oppervlakte.AutoSize = true;
            this.label_eenheid_para_oppervlakte.Location = new System.Drawing.Point(269, 350);
            this.label_eenheid_para_oppervlakte.Name = "label_eenheid_para_oppervlakte";
            this.label_eenheid_para_oppervlakte.Size = new System.Drawing.Size(18, 13);
            this.label_eenheid_para_oppervlakte.TabIndex = 67;
            this.label_eenheid_para_oppervlakte.Text = "m²";
            // 
            // label_eenheid_updatefreq
            // 
            this.label_eenheid_updatefreq.AutoSize = true;
            this.label_eenheid_updatefreq.Location = new System.Drawing.Point(270, 324);
            this.label_eenheid_updatefreq.Name = "label_eenheid_updatefreq";
            this.label_eenheid_updatefreq.Size = new System.Drawing.Size(17, 13);
            this.label_eenheid_updatefreq.TabIndex = 68;
            this.label_eenheid_updatefreq.Text = "/s";
            // 
            // textBox_weerstandcoëficient
            // 
            this.textBox_weerstandcoëficient.Location = new System.Drawing.Point(17, 211);
            this.textBox_weerstandcoëficient.Name = "textBox_weerstandcoëficient";
            this.textBox_weerstandcoëficient.Size = new System.Drawing.Size(246, 20);
            this.textBox_weerstandcoëficient.TabIndex = 69;
            this.textBox_weerstandcoëficient.Text = "0.47";
            this.textBox_weerstandcoëficient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_weerstandcoëficient_KeyPress);
            // 
            // label_eenheid_snelheid
            // 
            this.label_eenheid_snelheid.AutoSize = true;
            this.label_eenheid_snelheid.Location = new System.Drawing.Point(269, 398);
            this.label_eenheid_snelheid.Name = "label_eenheid_snelheid";
            this.label_eenheid_snelheid.Size = new System.Drawing.Size(25, 13);
            this.label_eenheid_snelheid.TabIndex = 70;
            this.label_eenheid_snelheid.Text = "m/s";
            // 
            // label_eenheid_fw
            // 
            this.label_eenheid_fw.AutoSize = true;
            this.label_eenheid_fw.Location = new System.Drawing.Point(269, 423);
            this.label_eenheid_fw.Name = "label_eenheid_fw";
            this.label_eenheid_fw.Size = new System.Drawing.Size(15, 13);
            this.label_eenheid_fw.TabIndex = 71;
            this.label_eenheid_fw.Text = "N";
            // 
            // label_eenheid_fg
            // 
            this.label_eenheid_fg.AutoSize = true;
            this.label_eenheid_fg.Location = new System.Drawing.Point(269, 449);
            this.label_eenheid_fg.Name = "label_eenheid_fg";
            this.label_eenheid_fg.Size = new System.Drawing.Size(15, 13);
            this.label_eenheid_fg.TabIndex = 72;
            this.label_eenheid_fg.Text = "N";
            // 
            // label_eenheid_versnell
            // 
            this.label_eenheid_versnell.AutoSize = true;
            this.label_eenheid_versnell.Location = new System.Drawing.Point(269, 475);
            this.label_eenheid_versnell.Name = "label_eenheid_versnell";
            this.label_eenheid_versnell.Size = new System.Drawing.Size(28, 13);
            this.label_eenheid_versnell.TabIndex = 73;
            this.label_eenheid_versnell.Text = "m/s²";
            // 
            // label_eenheid_hoogte
            // 
            this.label_eenheid_hoogte.AutoSize = true;
            this.label_eenheid_hoogte.Location = new System.Drawing.Point(270, 499);
            this.label_eenheid_hoogte.Name = "label_eenheid_hoogte";
            this.label_eenheid_hoogte.Size = new System.Drawing.Size(15, 13);
            this.label_eenheid_hoogte.TabIndex = 74;
            this.label_eenheid_hoogte.Text = "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 617);
            this.Controls.Add(this.label_eenheid_hoogte);
            this.Controls.Add(this.label_eenheid_versnell);
            this.Controls.Add(this.label_eenheid_fg);
            this.Controls.Add(this.label_eenheid_fw);
            this.Controls.Add(this.label_eenheid_snelheid);
            this.Controls.Add(this.textBox_weerstandcoëficient);
            this.Controls.Add(this.label_eenheid_updatefreq);
            this.Controls.Add(this.label_eenheid_para_oppervlakte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_parachute_opp);
            this.Controls.Add(this.pictureBox_info_Simulatie);
            this.Controls.Add(this.pictureBox_info_object);
            this.Controls.Add(this.pictureBox_info_omgeving);
            this.Controls.Add(this.textBox_updateFreq);
            this.Controls.Add(this.label_updatefreq);
            this.Controls.Add(this.label_Simulatie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label_snelheid);
            this.Controls.Add(this.label_versnelling);
            this.Controls.Add(this.label_hoogte);
            this.Controls.Add(this.label_FG);
            this.Controls.Add(this.label_FW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_massadichtheid);
            this.Controls.Add(this.label_massadichtheid);
            this.Controls.Add(this.textBox_oppervlakte);
            this.Controls.Add(this.label_eenheid_oppervlakte);
            this.Controls.Add(this.label_oppevlakte);
            this.Controls.Add(this.label_weerstandcoëficient);
            this.Controls.Add(this.label_omgeving);
            this.Controls.Add(this.label_object);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_parachute);
            this.Controls.Add(this.label_eenheid_massa);
            this.Controls.Add(this.textBox_massa);
            this.Controls.Add(this.label_massa);
            this.Controls.Add(this.label_eenheid_zwaartekracht);
            this.Controls.Add(this.textBox_zwaartekracht);
            this.Controls.Add(this.label_zwaartekracht);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Skydiving";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_omgeving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_object)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_Simulatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_massadichtheid;
        private System.Windows.Forms.Label label_massadichtheid;
        private System.Windows.Forms.TextBox textBox_oppervlakte;
        private System.Windows.Forms.Label label_eenheid_oppervlakte;
        private System.Windows.Forms.Label label_oppevlakte;
        private System.Windows.Forms.Label label_weerstandcoëficient;
        private System.Windows.Forms.Label label_omgeving;
        private System.Windows.Forms.Label label_object;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_parachute;
        private System.Windows.Forms.Label label_eenheid_massa;
        private System.Windows.Forms.TextBox textBox_massa;
        private System.Windows.Forms.Label label_massa;
        private System.Windows.Forms.Label label_eenheid_zwaartekracht;
        private System.Windows.Forms.TextBox textBox_zwaartekracht;
        private System.Windows.Forms.Label label_zwaartekracht;
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Label label_FW;
        private System.Windows.Forms.Label label_FG;
        private System.Windows.Forms.Label label_hoogte;
        private System.Windows.Forms.Label label_versnelling;
        private System.Windows.Forms.Label label_snelheid;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Simulatie;
        private System.Windows.Forms.Label label_updatefreq;
        private System.Windows.Forms.TextBox textBox_updateFreq;
        private System.Windows.Forms.PictureBox pictureBox_info_omgeving;
        private System.Windows.Forms.PictureBox pictureBox_info_object;
        private System.Windows.Forms.PictureBox pictureBox_info_Simulatie;
        private System.Windows.Forms.Label label_parachute_opp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_eenheid_para_oppervlakte;
        private System.Windows.Forms.Label label_eenheid_updatefreq;
        private System.Windows.Forms.TextBox textBox_weerstandcoëficient;
        private System.Windows.Forms.Label label_eenheid_snelheid;
        private System.Windows.Forms.Label label_eenheid_fw;
        private System.Windows.Forms.Label label_eenheid_fg;
        private System.Windows.Forms.Label label_eenheid_versnell;
        private System.Windows.Forms.Label label_eenheid_hoogte;
    }
}

