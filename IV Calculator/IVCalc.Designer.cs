using System;
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
			this.label2 = new System.Windows.Forms.Label();
			this.PokemonCombo = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.HealthCombo = new System.Windows.Forms.ComboBox();
			this.CalculateButton = new System.Windows.Forms.Label();
			this.newCaughtCheck = new System.Windows.Forms.CheckBox();
			this.RefineBtn = new System.Windows.Forms.Label();
			this.AppraiseBtn = new System.Windows.Forms.Label();
			this.CPCombo = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.StardustCombo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.WindowMover = new System.Windows.Forms.Label();
			this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CPLabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.PossibleLevelsLabel = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.PossibleStatsPanel = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.StatCount = new System.Windows.Forms.Label();
			this.MaxStat = new System.Windows.Forms.Label();
			this.AvgStat = new System.Windows.Forms.Label();
			this.MinStat = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.PictureBox();
			this.StatsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.AppraisePanel = new System.Windows.Forms.Panel();
			this.CloseAppraisal = new System.Windows.Forms.Label();
			this.StamChck = new System.Windows.Forms.CheckBox();
			this.DefChck = new System.Windows.Forms.CheckBox();
			this.AtkChck = new System.Windows.Forms.CheckBox();
			this.BadStat = new System.Windows.Forms.Label();
			this.BadLabel = new System.Windows.Forms.Label();
			this.OkStat = new System.Windows.Forms.Label();
			this.GoodStat = new System.Windows.Forms.Label();
			this.OkLabel = new System.Windows.Forms.Label();
			this.BestStat = new System.Windows.Forms.Label();
			this.GoodLabel = new System.Windows.Forms.Label();
			this.BestLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
			this.AppraisePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.PokemonCombo);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.HealthCombo);
			this.panel1.Controls.Add(this.CalculateButton);
			this.panel1.Controls.Add(this.newCaughtCheck);
			this.panel1.Controls.Add(this.RefineBtn);
			this.panel1.Controls.Add(this.AppraiseBtn);
			this.panel1.Controls.Add(this.CPCombo);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.StardustCombo);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 502);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 267);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(315, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 31);
			this.label2.TabIndex = 6;
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
            "Abra",
            "Aerodactyl",
            "Alakazam",
            "Arbok",
            "Arcanine",
            "Articuno",
            "Beedrill",
            "Bellsprout",
            "Blastoise",
            "Bulbasaur",
            "Butterfree",
            "Caterpie",
            "Chansey",
            "Charizard",
            "Charmander",
            "Charmeleon",
            "Clefable",
            "Clefairy",
            "Cloyster",
            "Cubone",
            "Dewgong",
            "Diglett",
            "Ditto",
            "Dodrio",
            "Doduo",
            "Dragonair",
            "Dragonite",
            "Dratini",
            "Drowzee",
            "Dugtrio",
            "Eevee",
            "Ekans",
            "Electabuzz",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Farfetch\'d",
            "Fearow",
            "Flareon",
            "Gastly",
            "Gengar",
            "Geodude",
            "Gloom",
            "Golbat",
            "Goldeen",
            "Golduck",
            "Golem",
            "Graveler",
            "Grimer",
            "Growlithe",
            "Gyarados",
            "Haunter",
            "Hitmonchan",
            "Hitmonlee",
            "Horsea",
            "Hypno",
            "Ivysaur",
            "Jigglypuff",
            "Jolteon",
            "Jynx",
            "Kabuto",
            "Kabutops",
            "Kadabra",
            "Kakuna",
            "Kangaskhan",
            "Kingler",
            "Koffing",
            "Krabby",
            "Lapras",
            "Lickitung",
            "Machamp",
            "Machoke",
            "Machop",
            "Magikarp",
            "Magmar",
            "Magnemite",
            "Magneton",
            "Mankey",
            "Marowak",
            "Meowth",
            "Metapod",
            "Mew",
            "Mewtwo",
            "Moltres",
            "Mr. Mime",
            "Muk",
            "Nidoking",
            "Nidoqueen",
            "Nidoran♀",
            "Nidoran♂",
            "Nidorina",
            "Nidorino",
            "Ninetales",
            "Oddish",
            "Omanyte",
            "Omastar",
            "Onix",
            "Paras",
            "Parasect",
            "Persian",
            "Pidgeot",
            "Pidgeotto",
            "Pidgey",
            "Pikachu",
            "Pinsir",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Ponyta",
            "Porygon",
            "Primeape",
            "Psyduck",
            "Raichu",
            "Rapidash",
            "Raticate",
            "Rattata",
            "Rhydon",
            "Rhyhorn",
            "Sandshrew",
            "Sandslash",
            "Scyther",
            "Seadra",
            "Seaking",
            "Seel",
            "Shellder",
            "Slowbro",
            "Slowpoke",
            "Snorlax",
            "Spearow",
            "Squirtle",
            "Starmie",
            "Staryu",
            "Tangela",
            "Tauros",
            "Tentacool",
            "Tentacruel",
            "Vaporeon",
            "Venomoth",
            "Venonat",
            "Venusaur",
            "Victreebel",
            "Vileplume",
            "Voltorb",
            "Vulpix",
            "Wartortle",
            "Weedle",
            "Weepinbell",
            "Weezing",
            "Wigglytuff",
            "Zapdos",
            "Zubat"});
			this.PokemonCombo.Location = new System.Drawing.Point(123, 9);
			this.PokemonCombo.Name = "PokemonCombo";
			this.PokemonCombo.Size = new System.Drawing.Size(209, 29);
			this.PokemonCombo.TabIndex = 4;
			this.PokemonCombo.Leave += new System.EventHandler(this.PokemonCombo_Leave);
			this.PokemonCombo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PokemonCombo_PreviewKeyDown);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(315, 81);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 31);
			this.label9.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(315, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 31);
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
			this.HealthCombo.Location = new System.Drawing.Point(123, 116);
			this.HealthCombo.Name = "HealthCombo";
			this.HealthCombo.Size = new System.Drawing.Size(209, 28);
			this.HealthCombo.TabIndex = 15;
			this.HealthCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HealthCombo_KeyPress);
			this.HealthCombo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HealthCombo_PreviewKeyDown);
			// 
			// CalculateButton
			// 
			this.CalculateButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CalculateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalculateButton.Location = new System.Drawing.Point(9, 181);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(307, 31);
			this.CalculateButton.TabIndex = 13;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// newCaughtCheck
			// 
			this.newCaughtCheck.AutoSize = true;
			this.newCaughtCheck.BackColor = System.Drawing.Color.Transparent;
			this.newCaughtCheck.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.newCaughtCheck.Location = new System.Drawing.Point(11, 152);
			this.newCaughtCheck.Name = "newCaughtCheck";
			this.newCaughtCheck.Size = new System.Drawing.Size(166, 23);
			this.newCaughtCheck.TabIndex = 31;
			this.newCaughtCheck.Text = "Newly Caught";
			this.newCaughtCheck.UseVisualStyleBackColor = false;
			// 
			// RefineBtn
			// 
			this.RefineBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.RefineBtn.Enabled = false;
			this.RefineBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RefineBtn.Location = new System.Drawing.Point(159, 222);
			this.RefineBtn.Name = "RefineBtn";
			this.RefineBtn.Size = new System.Drawing.Size(157, 31);
			this.RefineBtn.TabIndex = 18;
			this.RefineBtn.Text = "Refine";
			this.RefineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RefineBtn.Click += new System.EventHandler(this.RefineBtn_Click);
			// 
			// AppraiseBtn
			// 
			this.AppraiseBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AppraiseBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AppraiseBtn.Location = new System.Drawing.Point(9, 222);
			this.AppraiseBtn.Name = "AppraiseBtn";
			this.AppraiseBtn.Size = new System.Drawing.Size(144, 31);
			this.AppraiseBtn.TabIndex = 17;
			this.AppraiseBtn.Text = "Appraise";
			this.AppraiseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AppraiseBtn.Click += new System.EventHandler(this.AppraiseBtn_Click);
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
			this.CPCombo.Location = new System.Drawing.Point(123, 81);
			this.CPCombo.Name = "CPCombo";
			this.CPCombo.Size = new System.Drawing.Size(209, 28);
			this.CPCombo.TabIndex = 14;
			this.CPCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPCombo_KeyPress);
			this.CPCombo.Leave += new System.EventHandler(this.CPCombo_Leave);
			this.CPCombo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CPCombo_PreviewKeyDown);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label10.Location = new System.Drawing.Point(6, 85);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 21);
			this.label10.TabIndex = 14;
			this.label10.Text = "CP:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label6.Location = new System.Drawing.Point(6, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 21);
			this.label6.TabIndex = 10;
			this.label6.Text = "Health:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(315, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 31);
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
			this.StardustCombo.Location = new System.Drawing.Point(123, 46);
			this.StardustCombo.Name = "StardustCombo";
			this.StardustCombo.Size = new System.Drawing.Size(209, 28);
			this.StardustCombo.TabIndex = 8;
			this.StardustCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StardustCombo_KeyPress);
			this.StardustCombo.Leave += new System.EventHandler(this.StardustCombo_Leave);
			this.StardustCombo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.StardustCombo_PreviewKeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label3.Location = new System.Drawing.Point(6, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "Stardust:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F);
			this.label1.Location = new System.Drawing.Point(6, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "Pokemon:";
			// 
			// WindowMover
			// 
			this.WindowMover.BackColor = System.Drawing.Color.LightSkyBlue;
			this.WindowMover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WindowMover.Dock = System.Windows.Forms.DockStyle.Top;
			this.WindowMover.Location = new System.Drawing.Point(0, 0);
			this.WindowMover.Name = "WindowMover";
			this.WindowMover.Size = new System.Drawing.Size(328, 31);
			this.WindowMover.TabIndex = 1;
			this.WindowMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMover_MouseDown);
			this.WindowMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMover_MouseMove);
			this.WindowMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowMover_MouseUp);
			// 
			// PokemonPictureBox
			// 
			this.PokemonPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.PokemonPictureBox.Image = global::IV_Calculator.Properties.Resources.Question;
			this.PokemonPictureBox.Location = new System.Drawing.Point(90, 62);
			this.PokemonPictureBox.Name = "PokemonPictureBox";
			this.PokemonPictureBox.Size = new System.Drawing.Size(150, 163);
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
			this.label8.Location = new System.Drawing.Point(90, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 33);
			this.label8.TabIndex = 3;
			this.label8.Text = "CP";
			// 
			// CPLabel
			// 
			this.CPLabel.BackColor = System.Drawing.Color.Transparent;
			this.CPLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CPLabel.ForeColor = System.Drawing.Color.White;
			this.CPLabel.Location = new System.Drawing.Point(172, 31);
			this.CPLabel.Name = "CPLabel";
			this.CPLabel.Size = new System.Drawing.Size(70, 33);
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
			this.label11.Location = new System.Drawing.Point(12, 226);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(194, 23);
			this.label11.TabIndex = 5;
			this.label11.Text = "Possible Levels:";
			// 
			// PossibleLevelsLabel
			// 
			this.PossibleLevelsLabel.BackColor = System.Drawing.Color.Transparent;
			this.PossibleLevelsLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PossibleLevelsLabel.ForeColor = System.Drawing.Color.White;
			this.PossibleLevelsLabel.Location = new System.Drawing.Point(206, 222);
			this.PossibleLevelsLabel.Name = "PossibleLevelsLabel";
			this.PossibleLevelsLabel.Size = new System.Drawing.Size(107, 33);
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
			this.label13.Location = new System.Drawing.Point(12, 255);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(180, 23);
			this.label13.TabIndex = 7;
			this.label13.Text = "Possible Stats:";
			// 
			// PossibleStatsPanel
			// 
			this.PossibleStatsPanel.AutoScroll = true;
			this.PossibleStatsPanel.BackColor = System.Drawing.Color.Transparent;
			this.PossibleStatsPanel.Location = new System.Drawing.Point(0, 339);
			this.PossibleStatsPanel.Name = "PossibleStatsPanel";
			this.PossibleStatsPanel.Size = new System.Drawing.Size(491, 159);
			this.PossibleStatsPanel.TabIndex = 8;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(9, 288);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(53, 19);
			this.label17.TabIndex = 23;
			this.label17.Text = "Max:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(120, 288);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(51, 19);
			this.label18.TabIndex = 24;
			this.label18.Text = "Avg:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(224, 288);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 19);
			this.label19.TabIndex = 25;
			this.label19.Text = "Min:";
			// 
			// StatCount
			// 
			this.StatCount.AutoSize = true;
			this.StatCount.BackColor = System.Drawing.Color.Transparent;
			this.StatCount.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatCount.ForeColor = System.Drawing.Color.White;
			this.StatCount.Location = new System.Drawing.Point(190, 255);
			this.StatCount.Name = "StatCount";
			this.StatCount.Size = new System.Drawing.Size(0, 23);
			this.StatCount.TabIndex = 26;
			// 
			// MaxStat
			// 
			this.MaxStat.AutoSize = true;
			this.MaxStat.BackColor = System.Drawing.Color.Transparent;
			this.MaxStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxStat.ForeColor = System.Drawing.Color.White;
			this.MaxStat.Location = new System.Drawing.Point(59, 288);
			this.MaxStat.Name = "MaxStat";
			this.MaxStat.Size = new System.Drawing.Size(0, 19);
			this.MaxStat.TabIndex = 27;
			// 
			// AvgStat
			// 
			this.AvgStat.AutoSize = true;
			this.AvgStat.BackColor = System.Drawing.Color.Transparent;
			this.AvgStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AvgStat.ForeColor = System.Drawing.Color.White;
			this.AvgStat.Location = new System.Drawing.Point(169, 288);
			this.AvgStat.Name = "AvgStat";
			this.AvgStat.Size = new System.Drawing.Size(0, 19);
			this.AvgStat.TabIndex = 28;
			// 
			// MinStat
			// 
			this.MinStat.AutoSize = true;
			this.MinStat.BackColor = System.Drawing.Color.Transparent;
			this.MinStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinStat.ForeColor = System.Drawing.Color.White;
			this.MinStat.Location = new System.Drawing.Point(270, 288);
			this.MinStat.Name = "MinStat";
			this.MinStat.Size = new System.Drawing.Size(0, 19);
			this.MinStat.TabIndex = 29;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.closeButton.Image = global::IV_Calculator.Properties.Resources.close;
			this.closeButton.Location = new System.Drawing.Point(298, 3);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(26, 25);
			this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.closeButton.TabIndex = 30;
			this.closeButton.TabStop = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// StatsBackgroundWorker
			// 
			this.StatsBackgroundWorker.WorkerReportsProgress = true;
			this.StatsBackgroundWorker.WorkerSupportsCancellation = true;
			this.StatsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StatsBackgroundWorker_DoWork);
			this.StatsBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.StatsBackgroundWorker_ProgressChanged);
			this.StatsBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StatsBackgroundWorker_RunWorkerCompleted);
			// 
			// AppraisePanel
			// 
			this.AppraisePanel.BackColor = System.Drawing.Color.LightSkyBlue;
			this.AppraisePanel.Controls.Add(this.CloseAppraisal);
			this.AppraisePanel.Controls.Add(this.StamChck);
			this.AppraisePanel.Controls.Add(this.DefChck);
			this.AppraisePanel.Controls.Add(this.AtkChck);
			this.AppraisePanel.Controls.Add(this.BadStat);
			this.AppraisePanel.Controls.Add(this.BadLabel);
			this.AppraisePanel.Controls.Add(this.OkStat);
			this.AppraisePanel.Controls.Add(this.GoodStat);
			this.AppraisePanel.Controls.Add(this.OkLabel);
			this.AppraisePanel.Controls.Add(this.BestStat);
			this.AppraisePanel.Controls.Add(this.GoodLabel);
			this.AppraisePanel.Controls.Add(this.BestLabel);
			this.AppraisePanel.Location = new System.Drawing.Point(0, 226);
			this.AppraisePanel.Name = "AppraisePanel";
			this.AppraisePanel.Size = new System.Drawing.Size(328, 495);
			this.AppraisePanel.TabIndex = 19;
			this.AppraisePanel.Visible = false;
			// 
			// CloseAppraisal
			// 
			this.CloseAppraisal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CloseAppraisal.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14F);
			this.CloseAppraisal.Location = new System.Drawing.Point(11, 463);
			this.CloseAppraisal.Name = "CloseAppraisal";
			this.CloseAppraisal.Size = new System.Drawing.Size(308, 28);
			this.CloseAppraisal.TabIndex = 7;
			this.CloseAppraisal.Text = "Close";
			this.CloseAppraisal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CloseAppraisal.Click += new System.EventHandler(this.CloseAppraisal_Click);
			// 
			// StamChck
			// 
			this.StamChck.AutoSize = true;
			this.StamChck.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.StamChck.Location = new System.Drawing.Point(217, 249);
			this.StamChck.Name = "StamChck";
			this.StamChck.Size = new System.Drawing.Size(106, 23);
			this.StamChck.TabIndex = 6;
			this.StamChck.Text = "Stamina";
			this.StamChck.UseVisualStyleBackColor = true;
			// 
			// DefChck
			// 
			this.DefChck.AutoSize = true;
			this.DefChck.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.DefChck.Location = new System.Drawing.Point(108, 249);
			this.DefChck.Name = "DefChck";
			this.DefChck.Size = new System.Drawing.Size(110, 23);
			this.DefChck.TabIndex = 5;
			this.DefChck.Text = "Defence";
			this.DefChck.UseVisualStyleBackColor = true;
			// 
			// AtkChck
			// 
			this.AtkChck.AutoSize = true;
			this.AtkChck.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.AtkChck.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AtkChck.Location = new System.Drawing.Point(11, 249);
			this.AtkChck.Name = "AtkChck";
			this.AtkChck.Size = new System.Drawing.Size(98, 23);
			this.AtkChck.TabIndex = 4;
			this.AtkChck.Text = "Attack";
			this.AtkChck.UseVisualStyleBackColor = true;
			// 
			// BadStat
			// 
			this.BadStat.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BadStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BadStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BadStat.Location = new System.Drawing.Point(169, 369);
			this.BadStat.Name = "BadStat";
			this.BadStat.Size = new System.Drawing.Size(150, 87);
			this.BadStat.TabIndex = 3;
			this.BadStat.Text = "Its stats are not out of the norm, in my estimation.";
			this.BadStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BadStat.Click += new System.EventHandler(this.BadStat_Click);
			// 
			// BadLabel
			// 
			this.BadLabel.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BadLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BadLabel.Location = new System.Drawing.Point(168, 132);
			this.BadLabel.Name = "BadLabel";
			this.BadLabel.Size = new System.Drawing.Size(150, 108);
			this.BadLabel.TabIndex = 3;
			this.BadLabel.Text = "Overall, your Pokemon is not likely to make much headway in battle.";
			this.BadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BadLabel.Click += new System.EventHandler(this.BadLabel_Click);
			// 
			// OkStat
			// 
			this.OkStat.BackColor = System.Drawing.Color.LightSkyBlue;
			this.OkStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OkStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkStat.Location = new System.Drawing.Point(12, 369);
			this.OkStat.Name = "OkStat";
			this.OkStat.Size = new System.Drawing.Size(150, 87);
			this.OkStat.TabIndex = 2;
			this.OkStat.Text = "Its stats are noticeably trending to the positive.";
			this.OkStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OkStat.Click += new System.EventHandler(this.OkStat_Click);
			// 
			// GoodStat
			// 
			this.GoodStat.BackColor = System.Drawing.Color.LightSkyBlue;
			this.GoodStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GoodStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GoodStat.Location = new System.Drawing.Point(168, 275);
			this.GoodStat.Name = "GoodStat";
			this.GoodStat.Size = new System.Drawing.Size(150, 87);
			this.GoodStat.TabIndex = 1;
			this.GoodStat.Text = "I am certainly impressed by its stats, I must say.";
			this.GoodStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.GoodStat.Click += new System.EventHandler(this.GoodStat_Click);
			// 
			// OkLabel
			// 
			this.OkLabel.BackColor = System.Drawing.Color.LightSkyBlue;
			this.OkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OkLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkLabel.Location = new System.Drawing.Point(11, 132);
			this.OkLabel.Name = "OkLabel";
			this.OkLabel.Size = new System.Drawing.Size(150, 108);
			this.OkLabel.TabIndex = 2;
			this.OkLabel.Text = "Overall, your Pokemon is above average.";
			this.OkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OkLabel.Click += new System.EventHandler(this.OkLabel_Click);
			// 
			// BestStat
			// 
			this.BestStat.BackColor = System.Drawing.Color.Aqua;
			this.BestStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BestStat.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BestStat.Location = new System.Drawing.Point(11, 275);
			this.BestStat.Name = "BestStat";
			this.BestStat.Size = new System.Drawing.Size(150, 87);
			this.BestStat.TabIndex = 0;
			this.BestStat.Text = "Its stats exceed my calculations. It\'s incredible!";
			this.BestStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BestStat.Click += new System.EventHandler(this.BestStat_Click);
			// 
			// GoodLabel
			// 
			this.GoodLabel.BackColor = System.Drawing.Color.LightSkyBlue;
			this.GoodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GoodLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GoodLabel.Location = new System.Drawing.Point(168, 12);
			this.GoodLabel.Name = "GoodLabel";
			this.GoodLabel.Size = new System.Drawing.Size(150, 108);
			this.GoodLabel.TabIndex = 1;
			this.GoodLabel.Text = "Overall, your Pokemon has certainly caught my attention.\r\n";
			this.GoodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.GoodLabel.Click += new System.EventHandler(this.GoodLabel_Click);
			// 
			// BestLabel
			// 
			this.BestLabel.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BestLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BestLabel.Location = new System.Drawing.Point(11, 12);
			this.BestLabel.Name = "BestLabel";
			this.BestLabel.Size = new System.Drawing.Size(150, 108);
			this.BestLabel.TabIndex = 0;
			this.BestLabel.Text = "Overall, your Pokemon is a wonder! What a breathtaking Pokemon!";
			this.BestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BestLabel.Click += new System.EventHandler(this.BestLabel_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(12, 316);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(322, 19);
			this.label7.TabIndex = 31;
			this.label7.Text = "Lvl      Sta      Atk      Def      Perfect";
			// 
			// IVCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(328, 769);
			this.ControlBox = false;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.WindowMover);
			this.Controls.Add(this.PokemonPictureBox);
			this.Controls.Add(this.MinStat);
			this.Controls.Add(this.AvgStat);
			this.Controls.Add(this.MaxStat);
			this.Controls.Add(this.StatCount);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.PossibleStatsPanel);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.PossibleLevelsLabel);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.CPLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.AppraisePanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "IVCalc";
			this.Load += new System.EventHandler(this.IVCalc_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
			this.AppraisePanel.ResumeLayout(false);
			this.AppraisePanel.PerformLayout();
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
		private Label label17;
		private Label label18;
		private Label label19;
		private Label StatCount;
		private Label MaxStat;
		private Label AvgStat;
		private Label MinStat;
		private PictureBox closeButton;
        private BackgroundWorker StatsBackgroundWorker;
		private Label RefineBtn;
		private Label AppraiseBtn;
		private Panel AppraisePanel;
		private Label BestLabel;
		private Label BadLabel;
		private Label OkLabel;
		private Label GoodLabel;
		private CheckBox StamChck;
		private CheckBox DefChck;
		private CheckBox AtkChck;
		private Label BadStat;
		private Label OkStat;
		private Label GoodStat;
		private Label BestStat;
		private Label CloseAppraisal;
		private CheckBox newCaughtCheck;
		private Label label7;
	}
}

