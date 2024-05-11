using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace progFinal
{

    public partial class gameWindow : Form
    {
        bool isLoggingIn = false;
        string validUsername = string.Empty;
        // these are for saving purposes
        DataRow saveDataRow;

        List<invSlot> invSlots = new List<invSlot>();
        // a list to store the inventory slot objects listed in order

        invSlot selectedSlot = null;

        double cash = 0;
        
        bool canSellAll = false;
        int oreMineAmount = 0;
        int luckAdder = 0;
        int extraSellMulti = 0;
        // stores what shop upgrades are purchased 

        int luckAdderCost = 250;
        int extraSellMultiCost = 500;
        int oreMineAmountCost = 1000;
        //Base costs of shop upgrades 

        int costScaling = 2;
        int luckScaling = 50;
        // controlls how much the shop upgrades increase by, and how much extra you get per upgrade

        // used to visually update the shop label's prices and upgrade levels
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
            // populating the inv slots list
        }
        
        // used for setting up the shop prices
        void initialSetup() {

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


        void saveGame() {

            // this sets up the string that'll be used to store the information about what items the user has for saving
            string invDataString = String.Empty;
            for (int i = 0; i < invSlots.Count; i++) {

                if (invSlots[i].getItem() != null) { // if there is an item in the slot, get its data string
                    invDataString += invSlots[i].getSaveData();
                }

            }
            
            // database stuffs
            SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\saveData.mdf;Integrated Security=True");
            database.Open();

            string queryString = "UPDATE accountSaveData SET cash = '" + cash + "', canSellAll = '" + canSellAll + "', oreMineAmount = '" + oreMineAmount + "', luckAdder = '" + luckAdder + "', extraSellMulti = '" + extraSellMulti + "', invData = '" + invDataString + "' WHERE username = '" + validUsername + "'";
            SqlCommand cmd = new SqlCommand(queryString, database);
            cmd.ExecuteNonQuery();

            database.Close();
        }

        // makes changing cash easier
        void editCash(double amount) {
            cash += amount;
            cash = Math.Round(cash, 1); // to keep the decimal short since we're adding decimals together
            cashLabel.Text = "$" + cash.ToString();
        }

        // this handles when a slot is clicked
        void switchItem(invSlot clickedSlot) {

            // if we have an item selected, and we clicked a slot with an item
            if (selectedSlot != null && clickedSlot.getItem() != null) {

                item temp = selectedSlot.getItem();
                selectedSlot.setItem(clickedSlot.getItem());
                clickedSlot.setItem(temp);

                clickedSlot.setText(clickedSlot.getItem().getItemName());
                selectedSlot.setText(selectedSlot.getItem().getItemName());

                clickedSlot.setColor(225, 225, 225);
                selectedSlot.setColor(225, 225, 225);
                selectedSlot = null;
            
            // if we have an item selected, and the slot we clicked is empty
            } else if (selectedSlot != null && clickedSlot.getItem() == null) {

                clickedSlot.setItem(selectedSlot.getItem());

                selectedSlot.setItem(null);
                selectedSlot.setColor(225, 225, 225);

                selectedSlot = null;

            // if we don't have an item selected, and click a slot with an item
            } else if (selectedSlot == null && clickedSlot.getItem() != null) {

                selectedSlot = clickedSlot;

                selectedSlot.setColor(250, 250, 250);

            }
        }

        // for removing an item from a slot
        void removeItem(invSlot slot) {
            if (slot.getItem() != null) { // making sure theres an item
                slot.setItem(null);
                slot.setColor(225, 225, 225);
            }
        }

        // basically bundles the functions for removing and adding cash
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

                    if (invSlots[i].getItem() == null) { // if there's no item, skip this slot
                        continue;
                    }

                    editCash(invSlots[i].getItem().getItemValue());
                    removeItem(invSlots[i]);
                }

                if (selectedSlot != null) { // after removing all the items, then the selected item would be sold, so we set selected to null
                    selectedSlot = null;
                }
            }
        }

        private void mineOreButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < oreMineAmount + 1; i++) { // mine x amount of ore based on how many extra ore upgrades purchased
                
                invSlot firstEmptySlot = null;
                for (int j = 0; j < invSlots.Count; j++) { // finding what the first empty slot is so we can add an ore to it
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

        // this is the shop button for mining extra ore/unlocking selling all button
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

        // this is the shop button for increasing ore luck
        private void increaseLuckButton_Click(object sender, EventArgs e) {
            if (cash >= luckAdderCost) {
                editCash(luckAdderCost * -1);
                luckAdder += luckScaling;

                updateShopLabels(1);
            }
        }


        private void loginButton_Click(object sender, EventArgs e) {
            loginGroupBox.Text = "Login";
            loginGroupBox.Visible = true;
            isLoggingIn = true; // I use the same menu for logging in/signing up so this keeps track of what was clicked
        }

        private void createAccountButton_Click(object sender, EventArgs e) {
            loginGroupBox.Text = "Create Account";
            loginGroupBox.Visible = true;
            isLoggingIn = false; 
        }

        // this is the shop button for increasing the sell multiplier 
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

        private void label2_Click(object sender, EventArgs e) {

        }

        private void usernameLoginTextbox_TextChanged(object sender, EventArgs e) {

        }

        private void submitLoginButton_Click(object sender, EventArgs e) {
            
            SqlConnection database = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\saveData.mdf;Integrated Security=True");
            database.Open();

            string username = usernameLoginTextbox.Text;
            string password = passwordLoginTextbox.Text;
            
            if (isLoggingIn) { // if the login button was clicked
                
                try {
                    string queryString = "SELECT * FROM accounts WHERE username = '" + username + "' AND password = '" + password + "'";

                    SqlDataAdapter data = new SqlDataAdapter(queryString, database);
                    DataTable dataTable = new DataTable();

                    data.Fill(dataTable);

                    if (dataTable.Rows.Count > 0) { // if there's an accoutn with the coorisponding name and password

                        validUsername = username;
                        gameTabNoLoginCover.Visible = false; // this hides the game tab when the user isn't logged in
                        tabControl1.SelectedIndex = 1;
                        tabControl1.TabPages.Remove(tabPage1);

                        queryString = "SELECT * FROM accountSaveData WHERE username = '" + username + "'";
                        data = new SqlDataAdapter(queryString, database);
                        dataTable = new DataTable();

                        data.Fill(dataTable);
                        DataColumn[] keyColumns = new DataColumn[1];
                        keyColumns[0] = dataTable.Columns["username"];
                        dataTable.PrimaryKey = keyColumns;


                        if (dataTable.Rows.Count > 0) { // if there's data saved to the account

                            saveDataRow = dataTable.Rows.Find(validUsername);

                            cash = (double)saveDataRow.ItemArray[1];
                            canSellAll = (bool)saveDataRow.ItemArray[2];
                            oreMineAmount = (int)saveDataRow.ItemArray[3];
                            luckAdder = (int)saveDataRow.ItemArray[4];
                            extraSellMulti = (int)saveDataRow.ItemArray[5];

                            string rawInvData = (string)saveDataRow.ItemArray[6];

                            if (rawInvData.Length > 0) { // if there's inventory items saved

                                string[] items = rawInvData.Split(new string[] { "&item" }, StringSplitOptions.RemoveEmptyEntries); // splitting each of the items into a list

                                for (int i = 0; i < items.Length; i++) {
                                    string thisItem = items[i];
                                    item newItem = new item(thisItem); // we use the saved data string to create a new item object
                                    invSlots[thisItem[thisItem.Length - 1] - '0'].setItem(newItem); // this is looking at the last character in the data string, which is a number coorisponding to the inventory slot the item was saved in
                                }

                            }

                        }

                        initialSetup();

                    } else { // account doesn't exist

                        badLoginDetailsLabel.Text = "* Username Or Password Incorrect";
                        badLoginDetailsLabel.Visible = true; 
                        passwordLoginTextbox.Text = String.Empty;
                        usernameLoginTextbox.Text = String.Empty;
                    }

                } catch(Exception error) {
                    MessageBox.Show("Error:" + error.Message);
                } finally {
                    database.Close();
                }

            } else { // if the signup button was clicked

                loginGroupBox.Text = "Signup";

                try {
                    string queryString = "INSERT INTO accounts (username, password) VALUES ('" + username + "','" + password + "')";

                    SqlCommand cmd = new SqlCommand(queryString, database);
                    cmd.ExecuteNonQuery();

                    queryString = "INSERT INTO accountSaveData (username, cash, canSellAll, oreMineAmount, luckAdder, extraSellMulti, invData) VALUES ('" + username + "','" + cash + "','" + canSellAll + "','" + oreMineAmount + "','" + luckAdder + "','" + extraSellMulti + "','" + "" + "')";
                    cmd = new SqlCommand(queryString, database);
                    cmd.ExecuteNonQuery();

                    validUsername = username;
                    gameTabNoLoginCover.Visible = false; // this hides the game tab when the user isn't logged in
                    tabControl1.SelectedIndex = 1;
                    tabControl1.TabPages.Remove(tabPage1);

                } catch (Exception error) {

                    if (error.Message.Contains("Violation of PRIMARY KEY")) { // how I check if the account with that username already exists instead of searching the database
                        badLoginDetailsLabel.Text = "* Username Already Exists!";
                        badLoginDetailsLabel.Visible = true;
                    } else {
                        MessageBox.Show("Error:" + error.GetType());
                    }


                } finally {
                    database.Close();
                    initialSetup();
                }

            }
        }

        // for clearing out the login textboxes and hiding the login menu
        private void cancelLoginButton_Click(object sender, EventArgs e) {
            
            badLoginDetailsLabel.Visible = false;
            passwordLoginTextbox.Text = string.Empty;
            usernameLoginTextbox.Text = string.Empty;
            loginGroupBox.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) {
            saveGame();
        }
    }
}
