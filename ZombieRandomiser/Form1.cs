using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataManager;

namespace ZombieRandomiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> allMaps = new List<string>(FetchDatas.FetchAllMapNames());

            foreach(string map in allMaps)
            {
                cbbMap.Items.Add(map);
            }
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            if (cbbMap.SelectedItem != null)
            {

                int mapID = FetchDatas.ReturnMapID(cbbMap.SelectedItem.ToString());
                #region Perks
                List<string> perks = new List<string>(FetchDatas.FetchPerksForMap(mapID));
                Random rnd = new Random();

                List<int> listNumbersPerks = new List<int>();
                List<List<int>> listAllNumbersPerks = new List<List<int>>();

                int number;
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        do
                        {
                            number = rnd.Next(0, perks.Count);
                        } while (listNumbersPerks.Contains(number));
                        listNumbersPerks.Add(number);
                    }
                    listAllNumbersPerks.Add(listNumbersPerks.ToList());
                    listNumbersPerks.Clear();
                }
                bool muleKickWhite = false;
                bool muleKickBlue = false;
                bool muleKickYellow = false;
                bool muleKickGreen = false;

                txbPerk1_White.Text = perks[listAllNumbersPerks[0][0]];
                txbPerk2_White.Text = perks[listAllNumbersPerks[0][1]];
                txbPerk3_White.Text = perks[listAllNumbersPerks[0][2]];
                txbPerk4_White.Text = perks[listAllNumbersPerks[0][3]];
                if (txbPerk1_White.Text == "Mule Kick" || txbPerk2_White.Text == "Mule Kick" || txbPerk3_White.Text == "Mule Kick" || txbPerk4_White.Text == "Mule Kick")
                { muleKickWhite = true; }

                txbPerk1_Blue.Text = perks[listAllNumbersPerks[1][0]];
                txbPerk2_Blue.Text = perks[listAllNumbersPerks[1][1]];
                txbPerk3_Blue.Text = perks[listAllNumbersPerks[1][2]];
                txbPerk4_Blue.Text = perks[listAllNumbersPerks[1][3]];
                if (txbPerk1_Blue.Text == "Mule Kick" || txbPerk2_Blue.Text == "Mule Kick" || txbPerk3_Blue.Text == "Mule Kick" || txbPerk4_Blue.Text == "Mule Kick")
                { muleKickBlue = true; }

                txbPerk1_Yellow.Text = perks[listAllNumbersPerks[2][0]];
                txbPerk2_Yellow.Text = perks[listAllNumbersPerks[2][1]];
                txbPerk3_Yellow.Text = perks[listAllNumbersPerks[2][2]];
                txbPerk4_Yellow.Text = perks[listAllNumbersPerks[2][3]];
                if(txbPerk1_Yellow.Text == "Mule Kick" || txbPerk2_Yellow.Text == "Mule Kick" || txbPerk3_Yellow.Text == "Mule Kick" || txbPerk4_Yellow.Text == "Mule Kick")
                { muleKickYellow = true; }

                txbPerk1_Green.Text = perks[listAllNumbersPerks[3][0]];
                txbPerk2_Green.Text = perks[listAllNumbersPerks[3][1]];
                txbPerk3_Green.Text = perks[listAllNumbersPerks[3][2]];
                txbPerk4_Green.Text = perks[listAllNumbersPerks[3][3]];
                if (txbPerk1_Green.Text == "Mule Kick" || txbPerk2_Green.Text == "Mule Kick" || txbPerk3_Green.Text == "Mule Kick" || txbPerk4_Green.Text == "Mule Kick")
                { muleKickGreen = true; }
                #endregion

                List<string> guns = new List<string>(FetchDatas.FetchGunsForMap(mapID));

                List<int> listNumbersGuns = new List<int>();
                List<List<int>> listAllNumbersGuns = new List<List<int>>();

                int numberGuns;
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        do
                        {
                            numberGuns = rnd.Next(0, guns.Count);
                        } while (listNumbersGuns.Contains(numberGuns));
                        listNumbersGuns.Add(numberGuns);
                    }
                    listAllNumbersGuns.Add(listNumbersGuns.ToList());
                    listNumbersGuns.Clear();
                }

                txbGun3_White.Visible = muleKickWhite;
                txbGun1_White.Text = guns[listAllNumbersGuns[0][0]];
                txbGun2_White.Text = guns[listAllNumbersGuns[0][1]];
                txbGun3_White.Text = guns[listAllNumbersGuns[0][2]];

                txbGun3_Blue.Visible = muleKickBlue;
                txbGun1_Blue.Text = guns[listAllNumbersGuns[1][0]];
                txbGun2_Blue.Text = guns[listAllNumbersGuns[1][1]];
                txbGun3_Blue.Text = guns[listAllNumbersGuns[1][2]];

                txbGun3_Yellow.Visible = muleKickYellow;
                txbGun1_Yellow.Text = guns[listAllNumbersGuns[2][0]];
                txbGun2_Yellow.Text = guns[listAllNumbersGuns[2][1]];
                txbGun3_Yellow.Text = guns[listAllNumbersGuns[2][2]];

                txbGun3_Green.Visible = muleKickGreen;
                txbGun1_Green.Text = guns[listAllNumbersGuns[3][0]];
                txbGun2_Green.Text = guns[listAllNumbersGuns[3][1]];
                txbGun3_Green.Text = guns[listAllNumbersGuns[3][2]];
            }
        }

        private void BtnRandomMap_Click(object sender, EventArgs e)
        {
            List<string> maps = new List<string>(FetchDatas.FetchAllMapNames());

            Random randomIndex = new Random();
            int randomIndexCbb = randomIndex.Next(0, maps.Count);
            cbbMap.SelectedIndex = randomIndexCbb;
        }
    }
}
