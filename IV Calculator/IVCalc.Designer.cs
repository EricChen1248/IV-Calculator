using System.ComponentModel;
using System.Windows.Forms;

namespace IV_Calculator
{
	partial class IVCalc
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IVCalc));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.CPCombo = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.HealthCombo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.StardustCombo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PokemonCombo = new System.Windows.Forms.ComboBox();
			this.WindowMover = new System.Windows.Forms.Label();
			this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CPLabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.PossibleLevelsLabel = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.PossibleStatsPanel = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.StatCount = new System.Windows.Forms.Label();
			this.MaxStat = new System.Windows.Forms.Label();
			this.AvgStat = new System.Windows.Forms.Label();
			this.MinStat = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.CPCombo);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.CalculateButton);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.HealthCombo);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.StardustCombo);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.PokemonCombo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 494);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 172);
			this.panel1.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(315, 107);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 29);
			this.label9.TabIndex = 16;
			// 
			// CPCombo
			// 
			this.CPCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CPCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CPCombo.BackColor = System.Drawing.Color.LightSkyBlue;
			this.CPCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CPCombo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CPCombo.FormatString = "#,###,###";
			this.CPCombo.FormattingEnabled = true;
			this.CPCombo.Location = new System.Drawing.Point(118, 107);
			this.CPCombo.Name = "CPCombo";
			this.CPCombo.Size = new System.Drawing.Size(214, 27);
			this.CPCombo.TabIndex = 15;
			this.CPCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPCombo_KeyPress);
			this.CPCombo.Leave += new System.EventHandler(this.CPCombo_Leave);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label10.Location = new System.Drawing.Point(6, 110);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 20);
			this.label10.TabIndex = 14;
			this.label10.Text = "CP:";
			// 
			// CalculateButton
			// 
			this.CalculateButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CalculateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalculateButton.Location = new System.Drawing.Point(9, 138);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(307, 29);
			this.CalculateButton.TabIndex = 13;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(315, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 29);
			this.label5.TabIndex = 12;
			// 
			// HealthCombo
			// 
			this.HealthCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.HealthCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.HealthCombo.BackColor = System.Drawing.Color.LightSkyBlue;
			this.HealthCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.HealthCombo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HealthCombo.FormatString = "#,###,###";
			this.HealthCombo.FormattingEnabled = true;
			this.HealthCombo.Location = new System.Drawing.Point(118, 74);
			this.HealthCombo.Name = "HealthCombo";
			this.HealthCombo.Size = new System.Drawing.Size(214, 27);
			this.HealthCombo.TabIndex = 11;
			this.HealthCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HealthCombo_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label6.Location = new System.Drawing.Point(6, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Health:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(315, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 29);
			this.label4.TabIndex = 9;
			// 
			// StardustCombo
			// 
			this.StardustCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.StardustCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.StardustCombo.BackColor = System.Drawing.Color.LightSkyBlue;
			this.StardustCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StardustCombo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StardustCombo.FormatString = "#,###,###";
			this.StardustCombo.FormattingEnabled = true;
			this.StardustCombo.Items.AddRange(new object[] {
            "0",
            "200",
            "400",
            "600",
            "800",
            "1000",
            "1300",
            "1600",
            "1900",
            "2200",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000"});
			this.StardustCombo.Location = new System.Drawing.Point(118, 42);
			this.StardustCombo.Name = "StardustCombo";
			this.StardustCombo.Size = new System.Drawing.Size(214, 27);
			this.StardustCombo.TabIndex = 8;
			this.StardustCombo.Leave += new System.EventHandler(this.StardustCombo_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label3.Location = new System.Drawing.Point(6, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Stardust:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(315, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 29);
			this.label2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label1.Location = new System.Drawing.Point(6, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Pokemon:";
			// 
			// PokemonCombo
			// 
			this.PokemonCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.PokemonCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.PokemonCombo.BackColor = System.Drawing.Color.LightSkyBlue;
			this.PokemonCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PokemonCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PokemonCombo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PokemonCombo.FormattingEnabled = true;
			this.PokemonCombo.Items.AddRange(new object[] {
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "Nidoran♀",
            "Nidorina",
            "Nidoqueen",
            "Nidoran♂",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetch\'d",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "Mr. Mime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew"});
			this.PokemonCombo.Location = new System.Drawing.Point(118, 8);
			this.PokemonCombo.Name = "PokemonCombo";
			this.PokemonCombo.Size = new System.Drawing.Size(214, 28);
			this.PokemonCombo.TabIndex = 4;
			this.PokemonCombo.Leave += new System.EventHandler(this.PokemonCombo_Leave);
			// 
			// WindowMover
			// 
			this.WindowMover.BackColor = System.Drawing.Color.LightSkyBlue;
			this.WindowMover.Dock = System.Windows.Forms.DockStyle.Top;
			this.WindowMover.Location = new System.Drawing.Point(0, 0);
			this.WindowMover.Name = "WindowMover";
			this.WindowMover.Size = new System.Drawing.Size(328, 29);
			this.WindowMover.TabIndex = 1;
			this.WindowMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMover_MouseDown);
			this.WindowMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMover_MouseMove);
			this.WindowMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMover_MouseUp);
			// 
			// PokemonPictureBox
			// 
			this.PokemonPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.PokemonPictureBox.Image = global::IV_Calculator.Properties.Resources.Question;
			this.PokemonPictureBox.Location = new System.Drawing.Point(72, 55);
			this.PokemonPictureBox.Name = "PokemonPictureBox";
			this.PokemonPictureBox.Size = new System.Drawing.Size(200, 200);
			this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PokemonPictureBox.TabIndex = 2;
			this.PokemonPictureBox.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(101, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 30);
			this.label8.TabIndex = 3;
			this.label8.Text = "CP";
			// 
			// CPLabel
			// 
			this.CPLabel.BackColor = System.Drawing.Color.Transparent;
			this.CPLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CPLabel.ForeColor = System.Drawing.Color.White;
			this.CPLabel.Location = new System.Drawing.Point(174, 32);
			this.CPLabel.Name = "CPLabel";
			this.CPLabel.Size = new System.Drawing.Size(89, 30);
			this.CPLabel.TabIndex = 4;
			this.CPLabel.Text = "10";
			this.CPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(12, 259);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(188, 21);
			this.label11.TabIndex = 5;
			this.label11.Text = "Possible Levels:";
			// 
			// PossibleLevelsLabel
			// 
			this.PossibleLevelsLabel.BackColor = System.Drawing.Color.Transparent;
			this.PossibleLevelsLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PossibleLevelsLabel.ForeColor = System.Drawing.Color.White;
			this.PossibleLevelsLabel.Location = new System.Drawing.Point(197, 253);
			this.PossibleLevelsLabel.Name = "PossibleLevelsLabel";
			this.PossibleLevelsLabel.Size = new System.Drawing.Size(107, 30);
			this.PossibleLevelsLabel.TabIndex = 6;
			this.PossibleLevelsLabel.Text = "1 - 40";
			this.PossibleLevelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(12, 285);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(177, 21);
			this.label13.TabIndex = 7;
			this.label13.Text = "Possible Stats:";
			// 
			// PossibleStatsPanel
			// 
			this.PossibleStatsPanel.AutoScroll = true;
			this.PossibleStatsPanel.BackColor = System.Drawing.Color.Transparent;
			this.PossibleStatsPanel.Location = new System.Drawing.Point(-5, 364);
			this.PossibleStatsPanel.Name = "PossibleStatsPanel";
			this.PossibleStatsPanel.Size = new System.Drawing.Size(496, 132);
			this.PossibleStatsPanel.TabIndex = 8;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(244, 343);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(81, 18);
			this.label16.TabIndex = 22;
			this.label16.Text = "Perfect";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(69, 343);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 18);
			this.label12.TabIndex = 19;
			this.label12.Text = "Sta";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(129, 343);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 18);
			this.label15.TabIndex = 21;
			this.label15.Text = "Atk";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(9, 343);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "Lvl";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(189, 343);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 18);
			this.label14.TabIndex = 20;
			this.label14.Text = "Def";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(9, 316);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(49, 18);
			this.label17.TabIndex = 23;
			this.label17.Text = "Max:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(120, 316);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(48, 18);
			this.label18.TabIndex = 24;
			this.label18.Text = "Avg:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(224, 316);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(45, 18);
			this.label19.TabIndex = 25;
			this.label19.Text = "Min:";
			// 
			// StatCount
			// 
			this.StatCount.AutoSize = true;
			this.StatCount.BackColor = System.Drawing.Color.Transparent;
			this.StatCount.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatCount.ForeColor = System.Drawing.Color.White;
			this.StatCount.Location = new System.Drawing.Point(197, 285);
			this.StatCount.Name = "StatCount";
			this.StatCount.Size = new System.Drawing.Size(0, 21);
			this.StatCount.TabIndex = 26;
			// 
			// MaxStat
			// 
			this.MaxStat.AutoSize = true;
			this.MaxStat.BackColor = System.Drawing.Color.Transparent;
			this.MaxStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxStat.ForeColor = System.Drawing.Color.White;
			this.MaxStat.Location = new System.Drawing.Point(59, 316);
			this.MaxStat.Name = "MaxStat";
			this.MaxStat.Size = new System.Drawing.Size(0, 18);
			this.MaxStat.TabIndex = 27;
			// 
			// AvgStat
			// 
			this.AvgStat.AutoSize = true;
			this.AvgStat.BackColor = System.Drawing.Color.Transparent;
			this.AvgStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AvgStat.ForeColor = System.Drawing.Color.White;
			this.AvgStat.Location = new System.Drawing.Point(169, 316);
			this.AvgStat.Name = "AvgStat";
			this.AvgStat.Size = new System.Drawing.Size(0, 18);
			this.AvgStat.TabIndex = 28;
			// 
			// MinStat
			// 
			this.MinStat.AutoSize = true;
			this.MinStat.BackColor = System.Drawing.Color.Transparent;
			this.MinStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinStat.ForeColor = System.Drawing.Color.White;
			this.MinStat.Location = new System.Drawing.Point(270, 316);
			this.MinStat.Name = "MinStat";
			this.MinStat.Size = new System.Drawing.Size(0, 18);
			this.MinStat.TabIndex = 29;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.closeButton.Image = global::IV_Calculator.Properties.Resources.close;
			this.closeButton.Location = new System.Drawing.Point(298, 3);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(26, 23);
			this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.closeButton.TabIndex = 30;
			this.closeButton.TabStop = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// IVCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(328, 666);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.MinStat);
			this.Controls.Add(this.AvgStat);
			this.Controls.Add(this.MaxStat);
			this.Controls.Add(this.StatCount);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.PossibleStatsPanel);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.PossibleLevelsLabel);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.CPLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.PokemonPictureBox);
			this.Controls.Add(this.WindowMover);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "IVCalc";
			this.Load += new System.EventHandler(this.IVCalc_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private ComboBox PokemonCombo;
		private Label label4;
		private ComboBox StardustCombo;
		private Label label3;
		private Label label5;
		private ComboBox HealthCombo;
		private Label label6;
		private Label CalculateButton;
		private Label WindowMover;
		private PictureBox PokemonPictureBox;
		private Label label9;
		private ComboBox CPCombo;
		private Label label10;
		private Label label8;
		private Label CPLabel;
		private Label label11;
		private Label PossibleLevelsLabel;
		private Label label13;
		private Panel PossibleStatsPanel;
		private Label label16;
		private Label label12;
		private Label label15;
		private Label label7;
		private Label label14;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label StatCount;
		private Label MaxStat;
		private Label AvgStat;
		private Label MinStat;
		private PictureBox closeButton;
	}
}

