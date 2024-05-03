using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace progFinal
{

    public partial class gameWindow : Form
    {
        List<invSlot> invSlots = new List<invSlot>();

        invSlot selectedSlot = null;

        double cash = 0;
        bool canSellAll = false;
        int oreMineAmount = 0;
        int luckAdder = 0;
        int extraSellMulti = 0;

        int luckAdderCost = 250;
        int extraSellMultiCost = 500;
        int oreMineAmountCost = 1000;

        int costScaling = 2;
        int luckScaling = 50;

        void updateShopLabels(int updateButtonCost = 0) {

            if (updateButtonCost == 1) {
                luckAdderCost *= costScaling;
            }

            if (updateButtonCost == 2) {
                extraSellMultiCost *= costScaling;
            }

            if (updateButtonCost == 3) {
                oreMineAmountCost *= costScaling;
            }

            increaseLuckButton.Text = "(" + (luckAdder / luckScaling) + ") Get Rarer Ores - $" + luckAdderCost;
            increaseSellMulti.Text = "(" + extraSellMulti + ") Increase Sell Values - $" + extraSellMultiCost;

            if (oreMineAmount == 1 && !canSellAll) {
                mineMoreOresUpgradeButton.Text = "Unlock Sell All Button $" + oreMineAmountCost;
            } else {
                mineMoreOresUpgradeButton.Text = "(" + oreMineAmount + ") Mine More Ores - $" + oreMineAmountCost;
            }

            if (canSellAll) {
                sellAllButton.Text = "Sell All Ores";
            }

            cashLabel.Text = "$" + cash;
        }

        public gameWindow() {
            InitializeComponent();

            invSlots.Add(new invSlot(0, invSlot0));
            invSlots.Add(new invSlot(1, invSlot1));
            invSlots.Add(new invSlot(2, invSlot2));
            invSlots.Add(new invSlot(3, invSlot3));
            invSlots.Add(new invSlot(4, invSlot4));
            invSlots.Add(new invSlot(5, invSlot5));
            invSlots.Add(new invSlot(6, invSlot6));
            invSlots.Add(new invSlot(7, invSlot7));
            invSlots.Add(new invSlot(8, invSlot8));

            for (int i = 0; i < (luckAdder / luckScaling); i++) {
                luckAdderCost *= costScaling;
            }

            for (int i = 0; i < (extraSellMulti); i++) {
                extraSellMultiCost *= costScaling;
            }

            for (int i = 0; i < (oreMineAmount); i++) {
                oreMineAmountCost *= costScaling;
            }

            updateShopLabels();

        }

        void editCash(double amount) {
            cash += amount;
            cash = Math.Round(cash, 1);
            cashLabel.Text = "$" + cash.ToString();
        }

        void switchItem(invSlot clickedSlot) {

            if (selectedSlot != null && clickedSlot.getItem() != null) {

                item temp = selectedSlot.getItem();
                selectedSlot.setItem(clickedSlot.getItem());
                clickedSlot.setItem(temp);

                clickedSlot.setText(clickedSlot.getItem().getItemName());
                selectedSlot.setText(selectedSlot.getItem().getItemName());

                clickedSlot.setColor(225, 225, 225);
                selectedSlot.setColor(225, 225, 225);
                selectedSlot = null;

            } else if (selectedSlot != null && clickedSlot.getItem() == null) {

                clickedSlot.setItem(selectedSlot.getItem());

                selectedSlot.setItem(null);
                selectedSlot.setColor(225, 225, 225);

                selectedSlot = null;

            } else if (selectedSlot == null && clickedSlot.getItem() != null) {

                selectedSlot = clickedSlot;

                selectedSlot.setColor(250, 250, 250);

            }
        }

        void removeItem(invSlot slot) {
            if (slot.getItem() != null) {
                slot.setItem(null);
                slot.setColor(225, 225, 225);
            }
        }

        void sellItem() {
            if (selectedSlot != null) {
                editCash(selectedSlot.getItem().getItemValue());
                removeItem(selectedSlot);
                selectedSlot = null;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            switchItem(invSlots[8]);
        }

        private void invSlot0_Click(object sender, EventArgs e) {
            switchItem(invSlots[0]);
        }

        private void quitGameButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void cashLabel_Click(object sender, EventArgs e) {

        }

        private void invSlot1_Click(object sender, EventArgs e) {
            switchItem(invSlots[1]);
        }

        private void invSlot2_Click(object sender, EventArgs e) {
            switchItem(invSlots[2]);
        }

        private void invSlot3_Click(object sender, EventArgs e) {
            switchItem(invSlots[3]);
        }

        private void invSlot4_Click(object sender, EventArgs e) {
            switchItem(invSlots[4]);
        }

        private void invSlot5_Click(object sender, EventArgs e) {
            switchItem(invSlots[5]);
        }

        private void invSlot6_Click(object sender, EventArgs e) {
            switchItem(invSlots[6]);
        }

        private void invSlot7_Click(object sender, EventArgs e) {
            switchItem(invSlots[7]);
        }

        private void sellSelectedButton_Click(object sender, EventArgs e) {
            sellItem();
        }

        private void sellAllButton_Click(object sender, EventArgs e) {
            if (canSellAll) {
                for (int i = 0; i < invSlots.Count; i++) {

                    if (invSlots[i].getItem() == null) {
                        continue;
                    }

                    editCash(invSlots[i].getItem().getItemValue());
                    removeItem(invSlots[i]);
                }

                if (selectedSlot != null) {
                    selectedSlot = null;
                }
            }
        }

        private void mineOreButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < oreMineAmount + 1; i++) {
                
                invSlot firstEmptySlot = null;
                for (int j = 0; j < invSlots.Count; j++) {
                    if (invSlots[j].getItem() == null) {
                        firstEmptySlot = invSlots[j];
                        break;
                    }
                }

                if (firstEmptySlot != null) {
                    firstEmptySlot.setItem(new item(luckAdder,extraSellMulti));
                }

            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (cash >= oreMineAmountCost) {

                if (oreMineAmount == 1 && !canSellAll) {
                    canSellAll = true;
                } else {
                    oreMineAmount++;
                }

                editCash(oreMineAmountCost * -1);
                updateShopLabels(3);
            }
        }

        private void increaseLuckButton_Click(object sender, EventArgs e) {
            if (cash >= luckAdderCost) {
                editCash(luckAdderCost * -1);
                luckAdder += luckScaling;

                updateShopLabels(1);
            }
        }

        private void loginButton_Click(object sender, EventArgs e) {
            tabControl1.SelectedIndex = 1;
        }

        private void createAccountButton_Click(object sender, EventArgs e) {

        }

        private void increaseSellMulti_Click(object sender, EventArgs e) {
            if (cash >= extraSellMultiCost) {
                editCash(extraSellMultiCost * -1);
                extraSellMulti++;

                updateShopLabels(2);
            }
        }

        private void invGB_Enter(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
