using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static IV_Calculator.Properties.Resources;

namespace IV_Calculator
{
	public partial class IVCalc : Form
	{
		private List<Pokemon> PokemonList;
		private List<Label> PLabels;
		private Pokemon _newPoke;
		private bool _drag;
		private int _mouseX;
		private int _mouseY;
        
        private void IVCalc_Load(object sender, EventArgs e)
		{
		}

        public IVCalc()
		{
			PokemonList = new List<Pokemon>();
			PLabels = new List<Label>();
			InitializeComponent();
		}

        private struct StatSet
        {
            public readonly Label Lvl;
            //public readonly Label Sta;
            //public readonly Label Atk;
            //public readonly Label Def;
            //public readonly Label Perfection;

            public StatSet(double level, int sta, int atk, int def, int y, ref double max, ref double min, ref double avg)
            {
                Lvl = new Label()
                {
                    Text = level.ToString(CultureInfo.InvariantCulture) + sta.ToString( ).PadLeft(14 - level.ToString(CultureInfo.InvariantCulture).Length )+ atk.ToString( ).PadLeft(14 - sta.ToString().Length )+def.ToString().PadLeft(14 - atk.ToString().Length ) + $"{(double)(atk + def + sta) / 45:P}".PadLeft(18 - def.ToString( ).Length ),
                    Location = new Point(10, y),
                    Font = new Font("Copperplate Gothic Bold", 12),
                    ForeColor = Color.White,
					AutoSize = true
                };

                //Sta = new Label()
                //{
                //    Text = sta.ToString(),
                //    Location = new Point(70, y),
                //    Font = new Font("Copperplate Gothic Bold", 12),
                //    ForeColor = Color.White
                //};
                //Atk = new Label()
                //{
                //    Text = atk.ToString(),
                //    Location = new Point(130, y),
                //    Font = new Font("Copperplate Gothic Bold", 12),
                //    ForeColor = Color.White
                //};
                //Def = new Label()
                //{
                //    Text = def.ToString(),
                //    Location = new Point(190, y),
                //    Font = new Font("Copperplate Gothic Bold", 12),
                //    ForeColor = Color.White
                //};
                //Perfection = new Label()
                //{
                //    Text = $"{(double)(atk + def + sta) / 45:P}",
                //    Location = new Point(245, y),
                //    Font = new Font("Copperplate Gothic Bold", 12),
                //    ForeColor = Color.White
                //};
                max = max < atk + def + sta ? atk + def + sta : max;
                min = min > atk + def + sta ? atk + def + sta : min;
                avg += atk + def + sta;
            }
        }

#region User Interface

        //Limiting Health ComboBox to only accept number and control key inputs
		private void CalculateButton_Click(object sender, EventArgs e)
		{
			if (CalculateButton.Text == "Cancel")
			{
				MaxStat.Text = "Cancelled";
				StatsBackgroundWorker.CancelAsync();
			}
			else
			{
				if (PokemonCombo.SelectedItem == null && CPCombo.SelectedItem == null && HealthCombo.SelectedItem == null &&
					StardustCombo.SelectedItem == null) return;
				PokemonCombo.Focus();
				CalculateButton.Text = "Cancel";
				MaxStat.Text = "Calculating";
				MinStat.Text = "";
				AvgStat.Text = "";
				_newPoke = new Pokemon()	   
				{
					CP = int.Parse(CPCombo.Text),
					Health = int.Parse(HealthCombo.Text),
					GivenName = PokemonCombo.Text,
					Stardust = int.Parse(StardustCombo.Text),
				};

			    if (BestLabel.BackColor == Color.Aqua)
			        _newPoke.CPRange = 1;
               else if (GoodLabel.BackColor == Color.Aqua)
                    _newPoke.CPRange = 2;
                else if (OkLabel.BackColor == Color.Aqua)
                    _newPoke.CPRange = 3;
               else if (BadLabel.BackColor == Color.Aqua)
                    _newPoke.CPRange = 4;
                if (BestStat.BackColor == Color.Aqua)
                    _newPoke.BestIV = 1;
                else if (GoodStat.BackColor == Color.Aqua)
                    _newPoke.BestIV = 2;
                else if (OkStat.BackColor == Color.Aqua)
                    _newPoke.BestIV = 3;
                else if (BadStat.BackColor == Color.Aqua)
                    _newPoke.BestIV  = 4;

                _newPoke.BestStatChck(AtkChck.Checked , DefChck.Checked, StamChck.Checked);

                _newPoke.Calculate(newCaughtCheck.Checked);

				PossibleStatsPanel.Controls.Clear();
				foreach (Control control in PossibleStatsPanel.Controls)
					control.Dispose();

                StatCount.Text = _newPoke.Levels.Count + " Entries";
				StatsBackgroundWorker.RunWorkerAsync();
			}
		}
		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
			Environment.Exit(0);
        }
        private void WindowMover_MouseMove(object sender, MouseEventArgs e)
		{
			if (!_drag) return;
			Top = Cursor.Position.Y -_mouseY;
			Left = Cursor.Position.X - _mouseX;
		}
        private void WindowMover_MouseDown(object sender, MouseEventArgs e)
		{
			_drag = true;
			_mouseX = Cursor.Position.X - Left;
			_mouseY = Cursor.Position.Y - Top;
		}
        private void WindowMover_MouseUp(object sender, MouseEventArgs e)
		{
			_drag = false;
		}

		#region User Input

		private void PokemonCombo_Leave(object sender, EventArgs e)
		{
			if (((ComboBox) sender).SelectedItem == null)
				((ComboBox) sender).Text = "";
			else
				PokemonPictureBox.Image = SetImage(PokemonCombo.Text);
		}
        private void StardustCombo_Leave(object sender, EventArgs e)
		{
			if (((ComboBox) sender).SelectedItem == null)
			{
				((ComboBox)sender).Text = "";
				PossibleLevelsLabel.Text = "1 - 40";
			}
			else
			{
				switch (int.Parse(((ComboBox) sender).Text))
				{
					case 200:
						PossibleLevelsLabel.Text = "1 - 2.5";
						break;
					case 400:
						PossibleLevelsLabel.Text = "3 - 4.5";
						break;
					case 600:
						PossibleLevelsLabel.Text = "5 - 6.5";
						break;
					case 800:
						PossibleLevelsLabel.Text = "7 - 8.5";
						break;
					case 1000:
						PossibleLevelsLabel.Text = "9 - 10.5";
						break;
					case 1300:
						PossibleLevelsLabel.Text = "11 - 12.5";
						break;
					case 1600:
						PossibleLevelsLabel.Text = "13 - 14.5";
						break;
					case 1900:
						PossibleLevelsLabel.Text = "15 - 16.5";
						break;
					case 2200:
						PossibleLevelsLabel.Text = "17 - 18.5";
						break;
					case 2500:
						PossibleLevelsLabel.Text = "19 - 20.5";
						break;
					case 3000:
						PossibleLevelsLabel.Text = "21 - 23.5";
						break;
					case 3500:
						PossibleLevelsLabel.Text = "23 - 24.5";
						break;
					case 4000:
						PossibleLevelsLabel.Text = "25 - 26.5";
						break;
					case 4500:
						PossibleLevelsLabel.Text = "27 - 28.5";
						break;
					case 5000:
						PossibleLevelsLabel.Text = "29 - 30.5";
						break;
					case 6000:
						PossibleLevelsLabel.Text = "31 - 32.5";
						break;
					case 7000:
						PossibleLevelsLabel.Text = "33 - 34.5";
						break;
					case 8000:
						PossibleLevelsLabel.Text = "35 - 36.5";
						break;
					case 9000:
						PossibleLevelsLabel.Text = "37 - 38.5";
						break;
					case 10000:
						PossibleLevelsLabel.Text = "39 - 39.5";
						break;
					case 0:
						PossibleLevelsLabel.Text = "40";
						break;
					default:
						PossibleLevelsLabel.Text = "1 - 40";
						break;
				}
			}
		}
		private void CPCombo_Leave(object sender, EventArgs e)
		{
			CPLabel.Text = CPCombo.Text;
		}
		private void StardustCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
	        if (e.KeyChar == (char) Keys.Enter)
		        CPCombo.Focus();
        }
		private void CPCombo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar)) return;
			switch (e.KeyChar)
			{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					e.Handled = false;
					break;
				default:
					e.Handled = true;
					break;
			}
		}
        private void HealthCombo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar)) return;
			switch (e.KeyChar )
			{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					e.Handled = false;
					break;
				default:
					e.Handled = true;
					break;
			}
		}
		private void PokemonCombo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			var combo = (ComboBox) sender;
			if (e.KeyValue == (char) Keys.Tab)
				combo.SelectedIndex = combo.FindString(combo.Text);
		}
		private void StardustCombo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			var combo = (ComboBox)sender;
			if (e.KeyValue == (char)Keys.Tab)
				combo.SelectedIndex = combo.FindString(combo.Text);
		}
		private void CPCombo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyValue == (char)Keys.Tab)
				SendKeys.Send("{ENTER}");
		}
		private void HealthCombo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyValue == (char) Keys.Tab)
			{
				SendKeys.Send("{ENTER}");
				CalculateButton_Click(CalculateButton, EventArgs.Empty);
			}
		}

		#endregion	

		private void RefineBtn_Click(object sender, EventArgs e)
        {

        }
        private void AppraiseBtn_Click(object sender, EventArgs e)
        {
            AppraisePanel.Visible = true;
	        AppraisePanel.BringToFront();
        }

		#region Appraisal Controls

		private void BestLabel_Click(object sender, EventArgs e)
        {
            BestLabel.BackColor = Color.Aqua;
            GoodLabel.BackColor = Color.LightSkyBlue;
            OkLabel.BackColor = Color.LightSkyBlue;
            BadLabel.BackColor = Color.LightSkyBlue;
        }
        private void GoodLabel_Click(object sender, EventArgs e)
        {
            BestLabel.BackColor = Color.LightSkyBlue;
            GoodLabel.BackColor = Color.Aqua;
            OkLabel.BackColor = Color.LightSkyBlue;
            BadLabel.BackColor = Color.LightSkyBlue;
        }
        private void OkLabel_Click(object sender, EventArgs e)
        {
            BestLabel.BackColor = Color.LightSkyBlue;
            GoodLabel.BackColor = Color.LightSkyBlue;
            OkLabel.BackColor = Color.Aqua;
            BadLabel.BackColor = Color.LightSkyBlue;
        }
        private void BadLabel_Click(object sender, EventArgs e)
        {
            BestLabel.BackColor = Color.LightSkyBlue;
            GoodLabel.BackColor = Color.LightSkyBlue;
            OkLabel.BackColor = Color.LightSkyBlue;
            BadLabel.BackColor = Color.Aqua;
        }

        private void BestStat_Click(object sender, EventArgs e)
        {
            BestStat.BackColor = Color.Aqua;
            GoodStat.BackColor = Color.LightSkyBlue;
            OkStat.BackColor = Color.LightSkyBlue;
            BadStat.BackColor = Color.LightSkyBlue;
        }
        private void GoodStat_Click(object sender, EventArgs e)
        {

            BestStat.BackColor = Color.LightSkyBlue;
            GoodStat.BackColor = Color.Aqua;
            OkStat.BackColor = Color.LightSkyBlue;
            BadStat.BackColor = Color.LightSkyBlue;
        }
        private void OkStat_Click(object sender, EventArgs e)
        {
            BestStat.BackColor = Color.LightSkyBlue;
            GoodStat.BackColor = Color.LightSkyBlue;
            OkStat.BackColor = Color.Aqua;
            BadStat.BackColor = Color.LightSkyBlue;
        }
        private void BadStat_Click(object sender, EventArgs e)
        {
            BestStat.BackColor = Color.LightSkyBlue;
            GoodStat.BackColor = Color.LightSkyBlue;
            OkStat.BackColor = Color.LightSkyBlue;
            BadStat.BackColor = Color.Aqua;
        }
        private void CloseAppraisal_Click(object sender, EventArgs e)
        {
            AppraisePanel.Visible = false;
	        AppraisePanel.SendToBack();
        }

        #endregion 


        private static Image SetImage(string pokemon)
        {
            switch (pokemon)
            {
                case "Bulbasaur":
                    return Bulbasaur;
                case "Ivysaur":
                    return Ivysaur;
                case "Venusaur":
                    return Venusaur;
                case "Charmander":
                    return Charmander;
                case "Charmeleon":
                    return Charmeleon;
                case "Charizard":
                    return Charizard;
                case "Squirtle":
                    return Squirtle;
                case "Wartortle":
                    return Wartortle;
                case "Blastoise":
                    return Blastoise;
                case "Caterpie":
                    return Caterpie;
                case "Metapod":
                    return Metapod;
                case "Butterfree":
                    return Butterfree;
                case "Weedle":
                    return Weedle;
                case "Kakuna":
                    return Kakuna;
                case "Beedrill":
                    return Beedrill;
                case "Pidgey":
                    return Pidgey;
                case "Pidgeotto":
                    return Pidgeotto;
                case "Pidgeot":
                    return Pidgeot;
                case "Rattata":
                    return Rattata;
                case "Raticate":
                    return Raticate;
                case "Spearow":
                    return Spearow;
                case "Fearow":
                    return Fearow;
                case "Ekans":
                    return Ekans;
                case "Arbok":
                    return Arbok;
                case "Pikachu":
                    return Pikachu;
                case "Raichu":
                    return Raichu;
                case "Sandshrew":
                    return Sandshrew;
                case "Sandslash":
                    return Sandslash;
                case "Nidoran♀":
                    return NidoranF;
                case "Nidorina":
                    return Nidorina;
                case "Nidoqueen":
                    return Nidoqueen;
                case "Nidoran♂":
                    return NidoranM;
                case "Nidorino":
                    return Nidorino;
                case "Nidoking":
                    return Nidoking;
                case "Clefairy":
                    return Clefairy;
                case "Clefable":
                    return Clefable;
                case "Vulpix":
                    return Vulpix;
                case "Ninetales":
                    return Ninetales;
                case "Jigglypuff":
                    return Jigglypuff;
                case "Wigglytuff":
                    return Wigglytuff;
                case "Zubat":
                    return Zubat;
                case "Golbat":
                    return Golbat;
                case "Oddish":
                    return Oddish;
                case "Gloom":
                    return Gloom;
                case "Vileplume":
                    return Vileplume;
                case "Paras":
                    return Paras;
                case "Parasect":
                    return Parasect;
                case "Venonat":
                    return Venonat;
                case "Venomoth":
                    return Venomoth;
                case "Diglett":
                    return Diglett;
                case "Dugtrio":
                    return Dugtrio;
                case "Meowth":
                    return Meowth;
                case "Persian":
                    return Persian;
                case "Psyduck":
                    return Psyduck;
                case "Golduck":
                    return Golduck;
                case "Mankey":
                    return Mankey;
                case "Primeape":
                    return Primeape;
                case "Growlithe":
                    return Growlithe;
                case "Arcanine":
                    return Arcanine;
                case "Poliwag":
                    return Poliwag;
                case "Poliwhirl":
                    return Poliwhirl;
                case "Poliwrath":
                    return Poliwrath;
                case "Abra":
                    return Abra;
                case "Kadabra":
                    return Kadabra;
                case "Alakazam":
                    return Alakazam;
                case "Machop":
                    return Machop;
                case "Machoke":
                    return Machoke;
                case "Machamp":
                    return Machamp;
                case "Bellsprout":
                    return Bellsprout;
                case "Weepinbell":
                    return Weepinbell;
                case "Victreebel":
                    return Victreebel;
                case "Tentacool":
                    return Tentacool;
                case "Tentacruel":
                    return Tentacruel;
                case "Geodude":
                    return Geodude;
                case "Graveler":
                    return Graveler;
                case "Golem":
                    return Golem;
                case "Ponyta":
                    return Ponyta;
                case "Rapidash":
                    return Rapidash;
                case "Slowpoke":
                    return Slowpoke;
                case "Slowbro":
                    return Slowbro;
                case "Magnemite":
                    return Magnemite;
                case "Magneton":
                    return Magneton;
                case "Farfetch'd":
                    return Farfetch_d;
                case "Doduo":
                    return Doduo;
                case "Dodrio":
                    return Dodrio;
                case "Seel":
                    return Seel;
                case "Dewgong":
                    return Dewgong;
                case "Grimer":
                    return Grimer;
                case "Muk":
                    return Muk;
                case "Shellder":
                    return Shellder;
                case "Cloyster":
                    return Cloyster;
                case "Gastly":
                    return Gastly;
                case "Haunter":
                    return Haunter;
                case "Gengar":
                    return Gengar;
                case "Onix":
                    return Onix;
                case "Drowzee":
                    return Drowzee;
                case "Hypno":
                    return Hypno;
                case "Krabby":
                    return Krabby;
                case "Kingler":
                    return Kingler;
                case "Voltorb":
                    return Voltorb;
                case "Electrode":
                    return Electrode;
                case "Exeggcute":
                    return Exeggcute;
                case "Exeggutor":
                    return Exeggutor;
                case "Cubone":
                    return Cubone;
                case "Marowak":
                    return Marowak;
                case "Hitmonlee":
                    return Hitmonlee;
                case "Hitmonchan":
                    return Hitmonchan;
                case "Lickitung":
                    return Lickitung;
                case "Koffing":
                    return Koffing;
                case "Weezing":
                    return Weezing;
                case "Rhyhorn":
                    return Rhyhorn;
                case "Rhydon":
                    return Rhydon;
                case "Chansey":
                    return Chansey;
                case "Tangela":
                    return Tangela;
                case "Kangaskhan":
                    return Kangaskhan;
                case "Horsea":
                    return Horsea;
                case "Seadra":
                    return Seadra;
                case "Goldeen":
                    return Goldeen;
                case "Seaking":
                    return Seaking;
                case "Staryu":
                    return Staryu;
                case "Starmie":
                    return Starmie;
                case "Mr. Mime":
                    return Mr_Mime;
                case "Scyther":
                    return Scyther;
                case "Jynx":
                    return Jynx;
                case "Electabuzz":
                    return Electabuzz;
                case "Magmar":
                    return Magmar;
                case "Pinsir":
                    return Pinsir;
                case "Tauros":
                    return Tauros;
                case "Magikarp":
                    return Magikarp;
                case "Gyarados":
                    return Gyarados;
                case "Lapras":
                    return Lapras;
                case "Ditto":
                    return Ditto;
                case "Eevee":
                    return Eevee;
                case "Vaporeon":
                    return Vaporeon;
                case "Jolteon":
                    return Jolteon;
                case "Flareon":
                    return Flareon;
                case "Porygon":
                    return Porygon;
                case "Omanyte":
                    return Omanyte;
                case "Omastar":
                    return Omastar;
                case "Kabuto":
                    return Kabuto;
                case "Kabutops":
                    return Kabutops;
                case "Aerodactyl":
                    return Aerodactyl;
                case "Snorlax":
                    return Snorlax;
                case "Articuno":
                    return Articuno;
                case "Zapdos":
                    return Zapdos;
                case "Moltres":
                    return Moltres;
                case "Dratini":
                    return Dratini;
                case "Dragonair":
                    return Dragonair;
                case "Dragonite":
                    return Dragonite;
                case "Mewtwo":
                    return Mewtwo;
                case "Mew":
                    return Mew;
                default:
                    return Question;
            }

        }

#endregion



#region Background Worker
        private void StatsBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
	        var StatCount = 0;
            double max = 0, min = 100, avg = 0;
	        foreach (var levels in _newPoke.Levels)
			{
				Thread.Sleep(2);
				if (StatsBackgroundWorker.CancellationPending)
				{
					e.Cancel = true;
					return;
				}

				StatsBackgroundWorker.ReportProgress(0, new Tuple<double, int, int, int,int>(levels.Level,levels.Siv,levels.Aiv,levels.Div, StatCount++));
				var current = (levels.Aiv + levels.Div + levels.Siv);
				max = max > current ? max : current;
				min = min < current ? min : current;
				avg += current;
			}
	        StatsBackgroundWorker.ReportProgress(100, new Tuple<double,double,double, int>(max, min, avg, _newPoke.Levels.Count));
        }

        private void StatsBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
	        if (e.ProgressPercentage == 100)
			{
				var tupleEnd = (Tuple<double, double, double, int>)e.UserState;
				MaxStat.Text = $@"{ tupleEnd.Item1 / 45:P0}";
				MinStat.Text = $@"{tupleEnd.Item2 / 45:P0}";
				AvgStat.Text = $@"{tupleEnd.Item3 / tupleEnd.Item4 / 45:P0}";
				return;
			}

			var tuple = (Tuple<double,int,int,int,int>)e.UserState;
	        PossibleStatsPanel.Controls.Add(new Label()
	        {
		        Text =
			        tuple.Item1.ToString(CultureInfo.InvariantCulture) +
			        tuple.Item2.ToString().PadLeft(14 - tuple.Item1.ToString(CultureInfo.InvariantCulture).Length) +
			        tuple.Item3.ToString().PadLeft(14 - tuple.Item2.ToString().Length) +
			        tuple.Item4.ToString().PadLeft(14 - tuple.Item3.ToString().Length) +
			        $"{(double) (tuple.Item3 + tuple.Item4 + tuple.Item2)/45:P}".PadLeft(18 - tuple.Item4.ToString().Length),
		        Location = new Point(10, tuple.Item5 * 27),
		        Font = new Font("Copperplate Gothic Bold", 12),
		        ForeColor = Color.White,
		        AutoSize = true
	        });
        }

        private void StatsBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
	        CalculateButton.Text = "Calculate";
        }
		#endregion

	
	}
}
