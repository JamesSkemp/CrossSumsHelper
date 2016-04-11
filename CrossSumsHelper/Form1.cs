using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace CrossSumsHelper {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			MainLogo.Text = "Cross Sums Helper";
			AboutText.Text = "Copyright 2005 - " + System.DateTime.Now.Year + " James Skemp";
			AboutLink.Text = "Comments welcomed and appreciated.";
			AboutLink.Links.Clear();
			AboutLink.Links.Add(0, AboutLink.Text.Length, "http://jamesrskemp.com/apps/CrossSumsHelper/");

			// Populate the two drop-downs
			CreateBlanksList();
			CreateSumList(BlanksCombo.SelectedItem.ToString());
			GetCombinations(BlanksCombo.SelectedItem.ToString(), (int)SumsCombo.SelectedItem);
		}

		private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			if (e.Link.LinkData != null) {
				System.Diagnostics.Process.Start(e.Link.LinkData as string);
			}
		}
		private void CreateBlanksList() {
			BlanksCombo.Items.Clear();
			for (int i = 2; i <= 9; i++) {
				BlanksCombo.Items.Add(i + " blanks");
			}
			BlanksCombo.SelectedIndex = 0;
		}
		private void CreateSumList(string blanks) {
			int StartNum;
			int EndNum;
			switch (blanks) {
				case "2 blanks":
					StartNum = 3;
					EndNum = 17;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "3 blanks":
					StartNum = 6;
					EndNum = 24;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "4 blanks":
					StartNum = 10;
					EndNum = 30;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "5 blanks":
					StartNum = 15;
					EndNum = 35;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "6 blanks":
					StartNum = 21;
					EndNum = 39;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "7 blanks":
					StartNum = 28;
					EndNum = 42;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "8 blanks":
					StartNum = 36;
					EndNum = 44;
					SumsCombo.Items.Clear();
					for (int i = StartNum; i <= EndNum; i++) {
						SumsCombo.Items.Add(i);

					}
					SumLabel.Text = "Sum number (" + StartNum + " to " + EndNum + ")";
					break;
				case "9 blanks":
					SumsCombo.Items.Clear();
					SumsCombo.Items.Add(45);
					break;
				default:
					break;
			}
			SumsCombo.SelectedIndex = 0;
		}

		private void BlanksCombo_SelectedIndexChanged(object sender, EventArgs e) {
			CreateSumList(BlanksCombo.SelectedItem.ToString());
			GenerateData();
			//GetCombinations(BlanksCombo.SelectedItem.ToString(), (int)SumsCombo.SelectedItem);
		}
		private void SumsCombo_SelectedIndexChanged(object sender, EventArgs e) {
			GenerateData();
			//GetCombinations(BlanksCombo.SelectedItem.ToString(), (int)SumsCombo.SelectedItem);
		}

		private void GetCombinations(string blanks, int sum) {
			ResultsGroup.Text = "Combinations for #" + sum.ToString() + ", with " + blanks;
			ResultsText.Text = "";
			switch (blanks) {
				case "2 blanks":
					switch (sum) {
						case 3:
							ResultsText.Text = "1 2";
							break;
						case 4:
							ResultsText.Text = "1 3";
							break;
						case 5:
							ResultsText.Text = "1 4" + "\r\n" + "2 3";
							break;
						case 6:
							ResultsText.Text = "1 5" + "\r\n" + "2 4";
							break;
						case 7:
							ResultsText.Text = "1 6" + "\r\n" + "2 5" + "\r\n" + "3 4";
							break;
						case 8:
							ResultsText.Text = "1 7" + "\r\n" + "2 6" + "\r\n" + "3 5";
							break;
						case 9:
							ResultsText.Text = "1 8" + "\r\n" + "2 7" + "\r\n" + "3 6" + "\r\n" + "4 5";
							break;
						case 10:
							ResultsText.Text = "1 9" + "\r\n" + "2 8" + "\r\n" + "3 7" + "\r\n" + "4 6";
							break;
						case 11:
							ResultsText.Text = "2 9" + "\r\n" + "3 8" + "\r\n" + "4 7" + "\r\n" + "5 6";
							break;
						case 12:
							ResultsText.Text = "3 9" + "\r\n" + "4 8" + "\r\n" + "5 7";
							break;
						case 13:
							ResultsText.Text = "4 9" + "\r\n" + "5 8" + "\r\n" + "6 7";
							break;
						case 14:
							ResultsText.Text = "5 9" + "\r\n" + "6 8";
							break;
						case 15:
							ResultsText.Text = "6 9" + "\r\n" + "7 8";
							break;
						case 16:
							ResultsText.Text = "7 9";
							break;
						case 17:
							ResultsText.Text = "8 9";
							break;
						default:
							break;
					}
					break;
				case "3 blanks":
					switch (sum) {
						case 6:
							ResultsText.Text = "1 2 3 ";
							break;
						case 7:
							ResultsText.Text = "1 2 4 ";
							break;
						case 8:
							ResultsText.Text = "1 2 5" + "\r\n" + "1 3 4";
							break;
						case 9:
							ResultsText.Text = "1 2 6" + "\r\n" + "1 3 5" + "\r\n" + "2 3 4";
							break;
						case 10:
							ResultsText.Text = "1 2 7" + "\r\n" + "1 3 6" + "\r\n" + "1 4 5" + "\r\n" + "2 3 5";
							break;
						case 11:
							ResultsText.Text = "1 2 8" + "\r\n" + "1 3 7" + "\r\n" + "1 4 6" + "\r\n" + "2 3 6" + "\r\n" + "2 4 5";
							break;
						case 12:
							ResultsText.Text = "1 2 9" + "\r\n" + "1 3 8" + "\r\n" + "1 4 7" + "\r\n" + "1 5 6" + "\r\n" + "2 3 7" + "\r\n" + "2 4 6" + "\r\n" + "3 4 5";
							break;
						case 13:
							ResultsText.Text = "1 3 9" + "\r\n" + "1 4 8" + "\r\n" + "1 5 7" + "\r\n" + "2 3 8" + "\r\n" + "2 4 7" + "\r\n" + "2 5 6" + "\r\n" + "3 4 6";
							break;
						case 14:
							ResultsText.Text = "1 4 9" + "\r\n" + "1 5 8" + "\r\n" + "1 6 7" + "\r\n" + "2 3 9" + "\r\n" + "2 4 8" + "\r\n" + "2 5 7" + "\r\n" + "3 4 7" + "\r\n" + "3 5 6";
							break;
						case 15:
							ResultsText.Text = "1 5 9" + "\r\n" + "1 6 8" + "\r\n" + "2 4 9" + "\r\n" + "2 5 8" + "\r\n" + "2 6 7" + "\r\n" + "3 4 8" + "\r\n" + "3 5 7" + "\r\n" + "4 5 6";
							break;
						case 16:
							ResultsText.Text = "1 6 9" + "\r\n" + "1 7 8" + "\r\n" + "2 5 9" + "\r\n" + "2 6 8" + "\r\n" + "3 4 9" + "\r\n" + "3 5 8" + "\r\n" + "3 6 7" + "\r\n" + "4 5 7";
							break;
						case 17:
							ResultsText.Text = "1 7 9" + "\r\n" + "2 6 9" + "\r\n" + "2 7 8" + "\r\n" + "3 5 9" + "\r\n" + "3 6 8" + "\r\n" + "4 5 8" + "\r\n" + "4 6 7";
							break;
						case 18:
							ResultsText.Text = "1 8 9" + "\r\n" + "2 7 9" + "\r\n" + "3 6 9" + "\r\n" + "3 7 8" + "\r\n" + "4 5 9" + "\r\n" + "4 6 8" + "\r\n" + "5 6 7";
							break;
						case 19:
							ResultsText.Text = "2 8 9" + "\r\n" + "3 7 9" + "\r\n" + "4 6 9" + "\r\n" + "4 7 8" + "\r\n" + "5 6 8";
							break;
						case 20:
							ResultsText.Text = "3 8 9" + "\r\n" + "4 7 9" + "\r\n" + "5 6 9" + "\r\n" + "5 7 8";
							break;
						case 21:
							ResultsText.Text = "4 8 9" + "\r\n" + "5 7 9" + "\r\n" + "6 7 8";
							break;
						case 22:
							ResultsText.Text = "5 8 9" + "\r\n" + "6 7 9";
							break;
						case 23:
							ResultsText.Text = "6 8 9";
							break;
						case 24:
							ResultsText.Text = "7 8 9";
							break;
						default:
							break;
					}
					break;
				case "4 blanks":
					switch (sum) {
						case 10:
							ResultsText.Text = "1 2 3 4";
							break;
						case 11:
							ResultsText.Text = "1 2 3 5";
							break;
						case 12:
							ResultsText.Text = "1 2 3 6" + "\r\n" + "1 2 4 5";
							break;
						case 13:
							ResultsText.Text = "1 2 3 7" + "\r\n" + "1 2 4 6" + "\r\n" + "1 3 4 5";
							break;
						case 14:
							ResultsText.Text = "1 2 3 8" + "\r\n" + "1 2 4 7" + "\r\n" + "1 2 5 6" + "\r\n" + "1 3 4 6" + "\r\n" + "2 3 4 5";
							break;
						case 15:
							ResultsText.Text = "1 2 3 9" + "\r\n" + "1 2 4 8" + "\r\n" + "1 2 5 7" + "\r\n" + "1 3 4 7" + "\r\n" + "1 3 5 6" + "\r\n" + "2 3 4 6";
							break;
						case 16:
							ResultsText.Text = "1 2 4 9" + "\r\n" + "1 2 5 8" + "\r\n" + "1 2 6 7" + "\r\n" + "1 3 4 8" + "\r\n" + "1 3 5 7" + "\r\n" + "1 4 5 6" + "\r\n" + "2 3 4 7" + "\r\n" + "2 3 5 6";
							break;
						case 17:
							ResultsText.Text = "1 2 5 9" + "\r\n" + "1 2 6 8" + "\r\n" + "1 3 4 9" + "\r\n" + "1 3 5 8" + "\r\n" + "1 3 6 7" + "\r\n" + "1 4 5 7" + "\r\n" + "2 3 4 8" + "\r\n" + "2 3 5 7" + "\r\n" + "2 4 5 6";
							break;
						case 18:
							ResultsText.Text = "1 2 6 9" + "\r\n" + "1 2 7 8" + "\r\n" + "1 3 5 9" + "\r\n" + "1 3 6 8" + "\r\n" + "1 4 5 8" + "\r\n" + "1 4 6 7" + "\r\n" + "2 3 4 9" + "\r\n" + "2 3 5 8" + "\r\n" + "2 3 6 7" + "\r\n" + "2 4 5 7" + "\r\n" + "3 4 5 6";
							break;
						case 19:
							ResultsText.Text = "1 2 7 9" + "\r\n" + "1 3 6 9" + "\r\n" + "1 3 7 8" + "\r\n" + "1 4 5 9" + "\r\n" + "1 4 6 8" + "\r\n" + "1 5 6 7" + "\r\n" + "2 3 5 9" + "\r\n" + "2 3 6 8" + "\r\n" + "2 4 5 8" + "\r\n" + "2 4 6 7" + "\r\n" + "3 4 5 7";
							break;
						case 20:
							ResultsText.Text = "1 2 8 9" + "\r\n" + "1 3 7 9" + "\r\n" + "1 4 6 9" + "\r\n" + "1 4 7 8" + "\r\n" + "1 5 6 8" + "\r\n" + "2 3 6 9" + "\r\n" + "2 3 7 8" + "\r\n" + "2 4 5 9" + "\r\n" + "2 4 6 8" + "\r\n" + "2 5 6 7" + "\r\n" + "3 4 5 8" + "\r\n" + "3 4 6 7";
							break;
						case 21:
							ResultsText.Text = "1 3 8 9" + "\r\n" + "1 4 7 9" + "\r\n" + "1 5 6 9" + "\r\n" + "1 5 7 8" + "\r\n" + "2 3 7 9" + "\r\n" + "2 4 6 9" + "\r\n" + "2 4 7 8" + "\r\n" + "2 5 6 8" + "\r\n" + "3 4 5 9" + "\r\n" + "3 4 6 8" + "\r\n" + "3 5 6 7";
							break;
						case 22:
							ResultsText.Text = "1 4 8 9" + "\r\n" + "1 5 7 9" + "\r\n" + "1 6 7 8" + "\r\n" + "2 3 8 9" + "\r\n" + "2 4 7 9" + "\r\n" + "2 5 6 9" + "\r\n" + "2 5 7 8" + "\r\n" + "3 4 6 9" + "\r\n" + "3 4 7 8" + "\r\n" + "3 5 6 8" + "\r\n" + "4 5 6 7";
							break;
						case 23:
							ResultsText.Text = "1 5 8 9" + "\r\n" + "1 6 7 9" + "\r\n" + "2 4 8 9" + "\r\n" + "2 5 7 9" + "\r\n" + "2 6 7 8" + "\r\n" + "3 4 7 9" + "\r\n" + "3 5 6 9" + "\r\n" + "3 5 7 8" + "\r\n" + "4 5 6 8";
							break;
						case 24:
							ResultsText.Text = "1 6 8 9" + "\r\n" + "2 5 8 9" + "\r\n" + "2 6 7 9" + "\r\n" + "3 4 8 9" + "\r\n" + "3 5 7 9" + "\r\n" + "3 6 7 8" + "\r\n" + "4 5 6 9" + "\r\n" + "4 5 7 8";
							break;
						case 25:
							ResultsText.Text = "1 7 8 9" + "\r\n" + "2 6 8 9" + "\r\n" + "3 5 8 9" + "\r\n" + "3 6 7 9" + "\r\n" + "4 5 7 9" + "\r\n" + "4 6 7 8";
							break;
						case 26:
							ResultsText.Text = "2 7 8 9" + "\r\n" + "3 6 8 9" + "\r\n" + "4 5 8 9" + "\r\n" + "4 6 7 9" + "\r\n" + "5 6 7 8";
							break;
						case 27:
							ResultsText.Text = "3 7 8 9" + "\r\n" + "4 6 8 9" + "\r\n" + "5 6 7 9";
							break;
						case 28:
							ResultsText.Text = "4 7 8 9" + "\r\n" + "5 6 8 9";
							break;
						case 29:
							ResultsText.Text = "5 7 8 9";
							break;
						case 30:
							ResultsText.Text = "6 7 8 9";
							break;
						default:
							break;
					}
					break;
				case "5 blanks":
					switch (sum) {
						case 15:
							ResultsText.Text = "1 2 3 4 5";
							break;
						case 16:
							ResultsText.Text = "1 2 3 4 6";
							break;
						case 17:
							ResultsText.Text = "1 2 3 4 7" + "\r\n" + "1 2 3 5 6";
							break;
						case 18:
							ResultsText.Text = "1 2 3 4 8" + "\r\n" + "1 2 3 5 7" + "\r\n" + "1 2 4 5 6";
							break;
						case 19:
							ResultsText.Text = "1 2 3 4 9" + "\r\n" + "1 2 3 5 8" + "\r\n" + "1 2 3 6 7" + "\r\n" + "1 2 4 5 7" + "\r\n" + "1 3 4 5 6";
							break;
						case 20:
							ResultsText.Text = "1 2 3 5 9" + "\r\n" + "1 2 3 6 8" + "\r\n" + "1 2 4 5 8" + "\r\n" + "1 2 4 6 7" + "\r\n" + "1 3 4 5 7" + "\r\n" + "2 3 4 5 6";
							break;
						case 21:
							ResultsText.Text = "1 2 3 6 9" + "\r\n" + "1 2 3 7 8" + "\r\n" + "1 2 4 5 9" + "\r\n" + "1 2 4 6 8" + "\r\n" + "1 2 5 6 7" + "\r\n" + "1 3 4 5 8" + "\r\n" + "1 3 4 6 7" + "\r\n" + "2 3 4 5 7";
							break;
						case 22:
							ResultsText.Text = "1 2 3 7 9" + "\r\n" + "1 2 4 6 9" + "\r\n" + "1 2 4 7 8" + "\r\n" + "1 2 5 6 8" + "\r\n" + "1 3 4 5 9" + "\r\n" + "1 3 4 6 8" + "\r\n" + "1 3 5 6 7" + "\r\n" + "2 3 4 5 8" + "\r\n" + "2 3 4 6 7";
							break;
						case 23:
							ResultsText.Text = "1 2 3 8 9" + "\r\n" + "1 2 4 7 9" + "\r\n" + "1 2 5 6 9" + "\r\n" + "1 2 5 7 8" + "\r\n" + "1 3 4 6 9" + "\r\n" + "1 3 4 7 8" + "\r\n" + "1 3 5 6 8" + "\r\n" + "1 4 5 6 7" + "\r\n" + "2 3 4 5 9" + "\r\n" + "2 3 4 6 8" + "\r\n" + "2 3 5 6 7";
							break;
						case 24:
							ResultsText.Text = "1 2 4 8 9" + "\r\n" + "1 2 5 7 9" + "\r\n" + "1 2 6 7 8" + "\r\n" + "1 3 4 7 9" + "\r\n" + "1 3 5 6 9" + "\r\n" + "1 3 5 7 8" + "\r\n" + "1 4 5 6 8" + "\r\n" + "2 3 4 6 9" + "\r\n" + "2 3 4 7 8" + "\r\n" + "2 3 5 6 8" + "\r\n" + "2 4 5 6 7";
							break;
						case 25:
							ResultsText.Text = "1 2 5 8 9" + "\r\n" + "1 2 6 7 9" + "\r\n" + "1 3 4 8 9" + "\r\n" + "1 3 5 7 9" + "\r\n" + "1 3 6 7 8" + "\r\n" + "1 4 5 6 9" + "\r\n" + "1 4 5 7 8" + "\r\n" + "2 3 4 7 9" + "\r\n" + "2 3 5 6 9" + "\r\n" + "2 3 5 7 8" + "\r\n" + "2 4 5 6 8" + "\r\n" + "3 4 5 6 7";
							break;
						case 26:
							ResultsText.Text = "1 2 6 8 9" + "\r\n" + "1 3 5 8 9" + "\r\n" + "1 3 6 7 9" + "\r\n" + "1 4 5 7 9" + "\r\n" + "1 4 6 7 8" + "\r\n" + "2 3 4 8 9" + "\r\n" + "2 3 5 7 9" + "\r\n" + "2 3 6 7 8" + "\r\n" + "2 4 5 6 9" + "\r\n" + "2 4 5 7 8" + "\r\n" + "3 4 5 6 8";
							break;
						case 27:
							ResultsText.Text = "1 2 7 8 9" + "\r\n" + "1 3 6 8 9" + "\r\n" + "1 4 5 8 9" + "\r\n" + "1 4 6 7 9" + "\r\n" + "1 5 6 7 8" + "\r\n" + "2 3 5 8 9" + "\r\n" + "2 3 6 7 9" + "\r\n" + "2 4 5 7 9" + "\r\n" + "2 4 6 7 8" + "\r\n" + "3 4 5 6 9" + "\r\n" + "3 4 5 7 8";
							break;
						case 28:
							ResultsText.Text = "1 3 7 8 9" + "\r\n" + "1 4 6 8 9" + "\r\n" + "1 5 6 7 9" + "\r\n" + "2 3 6 8 9" + "\r\n" + "2 4 5 8 9" + "\r\n" + "2 4 6 7 9" + "\r\n" + "2 5 6 7 8" + "\r\n" + "3 4 5 7 9" + "\r\n" + "3 4 6 7 8";
							break;
						case 29:
							ResultsText.Text = "1 4 7 8 9" + "\r\n" + "1 5 6 8 9" + "\r\n" + "2 3 7 8 9" + "\r\n" + "2 4 6 8 9" + "\r\n" + "2 5 6 7 9" + "\r\n" + "3 4 5 8 9" + "\r\n" + "3 4 6 7 9" + "\r\n" + "3 5 6 7 8";
							break;
						case 30:
							ResultsText.Text = "1 5 7 8 9" + "\r\n" + "2 4 7 8 9" + "\r\n" + "2 5 6 8 9" + "\r\n" + "3 4 6 8 9" + "\r\n" + "3 5 6 7 9" + "\r\n" + "4 5 6 7 8";
							break;
						case 31:
							ResultsText.Text = "1 6 7 8 9" + "\r\n" + "2 5 7 8 9" + "\r\n" + "3 4 7 8 9" + "\r\n" + "3 5 6 8 9" + "\r\n" + "4 5 6 7 9";
							break;
						case 32:
							ResultsText.Text = "2 6 7 8 9" + "\r\n" + "3 5 7 8 9" + "\r\n" + "4 5 6 8 9";
							break;
						case 33:
							ResultsText.Text = "3 6 7 8 9" + "\r\n" + "4 5 7 8 9";
							break;
						case 34:
							ResultsText.Text = "4 6 7 8 9";
							break;
						case 35:
							ResultsText.Text = "5 6 7 8 9";
							break;
						default:
							break;
					}
					break;
				case "6 blanks":
					switch (sum) {
						case 21:
							ResultsText.Text = "1 2 3 4 5 6";
							break;
						case 22:
							ResultsText.Text = "1 2 3 4 5 7";
							break;
						case 23:
							ResultsText.Text = "1 2 3 4 5 8" + "\r\n" + "1 2 3 4 6 7";
							break;
						case 24:
							ResultsText.Text = "1 2 3 4 5 9" + "\r\n" + "1 2 3 4 6 8" + "\r\n" + "1 2 3 5 6 7";
							break;
						case 25:
							ResultsText.Text = "1 2 3 4 6 9" + "\r\n" + "1 2 3 4 7 8" + "\r\n" + "1 2 3 5 6 8" + "\r\n" + "1 2 4 5 6 7";
							break;
						case 26:
							ResultsText.Text = "1 2 3 4 7 9" + "\r\n" + "1 2 3 5 6 9" + "\r\n" + "1 2 3 5 7 8" + "\r\n" + "1 2 4 5 6 8" + "\r\n" + "1 3 4 5 6 7";
							break;
						case 27:
							ResultsText.Text = "1 2 3 4 8 9" + "\r\n" + "1 2 3 5 7 9" + "\r\n" + "1 2 3 6 7 8" + "\r\n" + "1 2 4 5 6 9" + "\r\n" + "1 2 4 5 7 8" + "\r\n" + "1 3 4 5 6 8" + "\r\n" + "2 3 4 5 6 7";
							break;
						case 28:
							ResultsText.Text = "1 2 3 5 8 9" + "\r\n" + "1 2 3 6 7 9" + "\r\n" + "1 2 4 5 7 9" + "\r\n" + "1 2 4 6 7 8" + "\r\n" + "1 3 4 5 6 9" + "\r\n" + "1 3 4 5 7 8" + "\r\n" + "2 3 4 5 6 8";
							break;
						case 29:
							ResultsText.Text = "1 2 3 6 8 9" + "\r\n" + "1 2 4 5 8 9" + "\r\n" + "1 2 4 6 7 9" + "\r\n" + "1 2 5 6 7 8" + "\r\n" + "1 3 4 5 7 9" + "\r\n" + "1 3 4 6 7 8" + "\r\n" + "2 3 4 5 6 9" + "\r\n" + "2 3 4 5 7 8";
							break;
						case 30:
							ResultsText.Text = "1 2 3 7 8 9" + "\r\n" + "1 2 4 6 8 9" + "\r\n" + "1 2 5 6 7 9" + "\r\n" + "1 3 4 5 8 9" + "\r\n" + "1 3 4 6 7 9" + "\r\n" + "1 3 5 6 7 8" + "\r\n" + "2 3 4 5 7 9" + "\r\n" + "2 3 4 6 7 8";
							break;
						case 31:
							ResultsText.Text = "1 2 4 7 8 9" + "\r\n" + "1 2 5 6 8 9" + "\r\n" + "1 3 4 6 8 9" + "\r\n" + "1 3 5 6 7 9" + "\r\n" + "1 4 5 6 7 8" + "\r\n" + "2 3 4 5 8 9" + "\r\n" + "2 3 4 6 7 9" + "\r\n" + "2 3 5 6 7 8";
							break;
						case 32:
							ResultsText.Text = "1 2 5 7 8 9" + "\r\n" + "1 3 4 7 8 9" + "\r\n" + "1 3 5 6 8 9" + "\r\n" + "1 4 5 6 7 9" + "\r\n" + "2 3 4 6 8 9" + "\r\n" + "2 3 5 6 7 9" + "\r\n" + "2 4 5 6 7 8";
							break;
						case 33:
							ResultsText.Text = "1 2 6 7 8 9" + "\r\n" + "1 3 5 7 8 9" + "\r\n" + "1 4 5 6 8 9" + "\r\n" + "2 3 4 7 8 9" + "\r\n" + "2 3 5 6 8 9" + "\r\n" + "2 4 5 6 7 9" + "\r\n" + "3 4 5 6 7 8";
							break;
						case 34:
							ResultsText.Text = "1 3 6 7 8 9" + "\r\n" + "1 4 5 7 8 9" + "\r\n" + "2 3 5 7 8 9" + "\r\n" + "2 4 5 6 8 9" + "\r\n" + "3 4 5 6 7 9";
							break;
						case 35:
							ResultsText.Text = "1 4 6 7 8 9" + "\r\n" + "2 3 6 7 8 9" + "\r\n" + "2 4 5 7 8 9" + "\r\n" + "3 4 5 6 8 9";
							break;
						case 36:
							ResultsText.Text = "1 5 6 7 8 9" + "\r\n" + "2 4 6 7 8 9" + "\r\n" + "3 4 5 7 8 9";
							break;
						case 37:
							ResultsText.Text = "2 5 6 7 8 9" + "\r\n" + "3 4 6 7 8 9";
							break;
						case 38:
							ResultsText.Text = "3 5 6 7 8 9";
							break;
						case 39:
							ResultsText.Text = "4 5 6 7 8 9";
							break;
						default:
							break;
					}
					break;
				case "7 blanks":
					switch (sum) {
						case 28:
							ResultsText.Text = "1 2 3 4 5 6 7";
							break;
						case 29:
							ResultsText.Text = "1 2 3 4 5 6 8";
							break;
						case 30:
							ResultsText.Text = "1 2 3 4 5 6 9" + "\r\n" + "1 2 3 4 5 7 8";
							break;
						case 31:
							ResultsText.Text = "1 2 3 4 5 7 9" + "\r\n" + "1 2 3 4 6 7 8";
							break;
						case 32:
							ResultsText.Text = "1 2 3 4 5 8 9" + "\r\n" + "1 2 3 4 6 7 9" + "\r\n" + "1 2 3 5 6 7 8";
							break;
						case 33:
							ResultsText.Text = "1 2 3 4 6 8 9" + "\r\n" + "1 2 3 5 6 7 9" + "\r\n" + "1 2 4 5 6 7 8";
							break;
						case 34:
							ResultsText.Text = "1 2 3 4 7 8 9" + "\r\n" + "1 2 3 5 6 8 9" + "\r\n" + "1 2 4 5 6 7 9" + "\r\n" + "1 3 4 5 6 7 8";
							break;
						case 35:
							ResultsText.Text = "1 2 3 5 7 8 9" + "\r\n" + "1 2 4 5 6 8 9" + "\r\n" + "1 3 4 5 6 7 9" + "\r\n" + "2 3 4 5 6 7 8";
							break;
						case 36:
							ResultsText.Text = "1 2 3 6 7 8 9" + "\r\n" + "1 2 4 5 7 8 9" + "\r\n" + "1 3 4 5 6 8 9" + "\r\n" + "2 3 4 5 6 7 9";
							break;
						case 37:
							ResultsText.Text = "1 2 4 6 7 8 9" + "\r\n" + "1 3 4 5 7 8 9" + "\r\n" + "2 3 4 5 6 8 9";
							break;
						case 38:
							ResultsText.Text = "1 2 5 6 7 8 9" + "\r\n" + "1 3 4 6 7 8 9" + "\r\n" + "2 3 4 5 7 8 9";
							break;
						case 39:
							ResultsText.Text = "1 3 5 6 7 8 9" + "\r\n" + "2 3 4 6 7 8 9";
							break;
						case 40:
							ResultsText.Text = "1 4 5 6 7 8 9" + "\r\n" + "2 3 5 6 7 8 9";
							break;
						case 41:
							ResultsText.Text = "2 4 5 6 7 8 9";
							break;
						case 42:
							ResultsText.Text = "3 4 5 6 7 8 9";
							break;
						default:
							break;
					}
					break;
				case "8 blanks":
					switch (sum) {
						case 36:
							ResultsText.Text = "1 2 3 4 5 6 7 8";
							break;
						case 37:
							ResultsText.Text = "1 2 3 4 5 6 7 9";
							break;
						case 38:
							ResultsText.Text = "1 2 3 4 5 6 8 9";
							break;
						case 39:
							ResultsText.Text = "1 2 3 4 5 7 8 9";
							break;
						case 40:
							ResultsText.Text = "1 2 3 4 6 7 8 9";
							break;
						case 41:
							ResultsText.Text = "1 2 3 5 6 7 8 9";
							break;
						case 42:
							ResultsText.Text = "1 2 4 5 6 7 8 9";
							break;
						case 43:
							ResultsText.Text = "1 3 4 5 6 7 8 9";
							break;
						case 44:
							ResultsText.Text = "2 3 4 5 6 7 8 9";
							break;
						default:
							break;
					}
					break;
				case "9 blanks":
					switch (sum) {
						case 45:
							ResultsText.Text = "1 2 3 4 5 6 7 8 9";
							break;
						default:
							break;
					}
					break;
				default:
					break;
			}
			ResultsGroup.Text += " (" + ResultsText.Lines.Length.ToString() + ")";
		}

		private void ExclusionsEnabled() {
			// Loop through the digits and remove any lines in the results that have the digit.
			string[] tempArray;
			tempArray = Regex.Split(ExcludeText.Text, " ");
			foreach (string value in tempArray) {
				int LoopCount = 0;
				foreach (string item in ResultsText.Lines) {
					if (!item.Contains(value) && value != "") {
						TempTextBox.Text += "\r\n" + item;
					}
					LoopCount++;
				}
				ResultsText.Text = TempTextBox.Text.Trim();
				TempTextBox.Text = "";
			}
		}
		private void ExclusionsDisabled() {
			//Do nothing.
		}

		private void InclusionsEnabled() {
			// Loop through the digits and remove any lines in the results that don't have the digit.
			string[] tempArray;
			tempArray = Regex.Split(IncludeText.Text, " ");
			foreach (string value in tempArray) {
				int LoopCount = 0;
				foreach (string item in ResultsText.Lines) {
					if (item.Contains(value) && value != "") {
						TempTextBox.Text += "\r\n" + item;
					}
					LoopCount++;
				}
				ResultsText.Text = TempTextBox.Text.Trim();
				TempTextBox.Text = "";
			}
		}
		private void InclusionsDisabled() {
			//Do nothing.
		}

		private void AboutButton_Click(object sender, EventArgs e) {
			new AboutBox1().Show();
		}

		private void CheckInclusions(object sender, EventArgs e) {
			GenerateData();
		}

		private void CheckExclusions(object sender, EventArgs e) {
			GenerateData();
		}
		private void GenerateData() {
			GetCombinations(BlanksCombo.SelectedItem.ToString(), (int)SumsCombo.SelectedItem);
			//Remove anything that isn't a digit or a space, and replace it with a space. Then trim the text.
			ExcludeText.Text = Regex.Replace(ExcludeText.Text, @"[^\d ]+", " ").Trim();
			//Change more than one space to one space.
			ExcludeText.Text = Regex.Replace(ExcludeText.Text, @" +", " ");
			if (ExcludeCheck.Checked && ExcludeText.Text != "") {
				ExclusionsEnabled();
			} else {
				ExclusionsDisabled();
			}
			//Remove anything that isn't a digit or a space, and replace it with a space. Then trim the text.
			IncludeText.Text = Regex.Replace(IncludeText.Text, @"[^\d ]+", " ").Trim();
			//Change more than one space to one space.
			IncludeText.Text = Regex.Replace(IncludeText.Text, @" +", " ");
			if (IncludeCheck.Checked && IncludeText.Text != "") {
				InclusionsEnabled();
			} else {
				InclusionsDisabled();
			}
		}

	}
}
