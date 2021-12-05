using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Windows forms partial class to display the entities on Form1.cs. Contains methods to determine which checkboxes have been checked, which hero the user has selected,
/// and which actions and enemies have been selected by the user. Creates an instance of Game.cs to play the game and allow the enemies to attack the user's heroes.
/// </summary>
namespace FinalProject
{
    public partial class RPG : Form
    {
        //Create a static instance of the Game.cs class to play the game.
        Game game = new Game();

        //Static character to keep track of the action selected by the user on the form. a for attack, d for defend, s for special.
        private char selectedAction = ' ';

        //Hero instance to keep track of the hero the user has selected.
        Entity selectedHero;

        //Enemy instance to keep track of the enemy the user has selected.
        Entity selectedEnemy;

        Random random = new Random();

        /// <summary>
        /// Default constructor for the form to initialize the values and setup the winform.
        /// </summary>
        public RPG()
        {
            InitializeComponent();
            SetupHealthBars();
        }//end RPG.

        //Handlers for when the checkboxes for the warrior, mage, and cleric are checked on the form.
        #region Hero Checkbox Handlers

        /// <summary>
        /// Handler for when the box for warrior is selected on the form. Sets the selected hero to the warrior.
        /// Disables the boxes for the cleric and the mage so the user can't chose more than one hero for one action.
        /// </summary>
        private void WarriorBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the warrior box is checked.
            if (warriorBox.Checked)
            {
                //Set the selected hero to the warrior instance from the game class.
                selectedHero = game.warrior;

                //Disable the cleric and mage checkboxes so the user can't select multiple heros.
                clericBox.Enabled = false;
                mageBox.Enabled = false;
            }

            //If the box isn't checked or it was checked then unchecked.
            else
            {
                //Set the selected hero to a null value.
                selectedHero = null;

                //Re-enable the mage and cleric check boxes.
                mageBox.Enabled = true;
                clericBox.Enabled = true;
            }
        }//end WarriorBox_CheckedChanged.

        /// <summary>
        /// Handler for if the mage box is checked on the form.
        /// Sets the selected hero to the mage instance from Game.cs and disables the checkboxes for the other two heroes.
        /// </summary>
        private void MageBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the mage box is checked.
            if (mageBox.Checked)
            {
                //Set the selected hero to the mage instance from the game class.
                selectedHero = game.mage;

                //Disable the other two hero checkboxes.
                warriorBox.Enabled = false;
                clericBox.Enabled = false;
            }

            //If the box isn't checked or if it was checked then unchecked.
            else
            {
                //Set the selected hero to a null value.
                selectedHero = null;

                //Re-enable the warrior and cleric check boxes.
                warriorBox.Enabled = true;
                clericBox.Enabled = true;
            }
        }//end MageBox_CheckedChanged.

        /// <summary>
        /// Handler for when the cleric box is checked on the RPG form.
        /// Sets the selected hero to the cleric and disables the other two checkboxes if checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClericBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the cleric box was checked on the form.
            if (clericBox.Checked)
            {
                //Set the selected hero to the cleric instance from the Game class.
                selectedHero = game.cleric;

                //Disable the other checkboxes.
                warriorBox.Enabled = false;
                mageBox.Enabled = false;
            }

            //If the box is unchecked or was checked then unchecked.
            else
            {
                //Set the selected hero to a null value.
                selectedHero = null;

                //Re-enable the warrior and mage checkboxes on the form.
                warriorBox.Enabled = true;
                mageBox.Enabled = true;
            }
        }//end ClericBox_CheckedChanged.

        #endregion

        //Handlers for when the checkboxes for attack, defend, or special are selected on the form.
        #region Action Checkbox Handlers

        /// <summary>
        /// Handler for when the attack box is checked on the form.
        /// Disables the defend and special boxes so the user can't select multiple actions.
        /// </summary>
        private void AttackBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the attack box is checked on the form.
            if (attackBox.Checked)
            {
                //Set the selected action to a for attack.
                selectedAction = 'a';

                //Disable the other two boxes on the form.
                defendBox.Enabled = false;
                specialBox.Enabled = false;
            }

            //If the box is unchecked.
            else
            {
                //Set the selected action to an empty character.
                selectedAction = ' ';

                //Re-enable the other two boxes so the user can select them.
                defendBox.Enabled = true;
                specialBox.Enabled = true;
            }
        }//end AttackBox_CheckedChanged.

        /// <summary>
        /// Handler for when the defend box is checked on the RPG form.
        /// Disables the attack and special boxes if checked.
        /// </summary>
        private void DefendBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the defend box was checked on the form.
            if (defendBox.Checked)
            {
                //Set the selected action to d for defend.
                selectedAction = 'd';

                //Disable the other two boxes on the form so the user can't select multiple actions for one turn.
                attackBox.Enabled = false;
                specialBox.Enabled = false;
            }

            //If the box was checked then unchecked or is left unchecked.
            else
            {
                //Set the selected action to an empty character to reset it.
                selectedAction = ' ';

                //Re-enable the other two boxes so the user can select them if they so chose.
                attackBox.Enabled = true;
                specialBox.Enabled = true;
            }
        }//end DefendBox_CheckedChanged.

        /// <summary>
        /// Handler for the special box on the windows form. Disables the other two boxes if checked.
        /// </summary>
        private void SpecialBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the special box is checked.
            if (specialBox.Checked)
            {
                //Set the selected action to s for special.
                selectedAction = 's';

                //Disable the other two checkboxes on the form.
                attackBox.Enabled = false;
                defendBox.Enabled = false;

                //If the hero is a cleric, their special ability is to heal the other heroes so the user shouldn't need to select an enemy.
                //Check if the selected hero is null first because it will throw an error otherwise.
                if (!(selectedHero == null) && selectedHero.Type == 'c')
                {
                    IfClericSpecialAbilityChecked();
                }
            }

            //If the box isn't checked or was checked then unchecked.
            else
            {
                //Set the selected action to an empty character.
                selectedAction = ' ';

                //Re-enable the other two boxes on the form.
                attackBox.Enabled = true;
                defendBox.Enabled = true;

                //If the hero is a cleric and the selected hero is not null.
                if (!(selectedHero == null) && selectedHero.Type == 'c')
                {
                    IfClericSpecialAbilityUnChecked();
                }
            }
        }//end SpecialBox_CheckedChanged.

        //Methods for the cleric's special ability, because it doesn't do damage to enemies so disable the enemy checkboxes.
        #region Cleric Special Ability Methods

        /// <summary>
        /// Method for if the cleric's special ability is selected.
        /// The ability doesn't attack any enemies, so disables all other checkboxes on the form.
        /// </summary>
        private void IfClericSpecialAbilityChecked()
        {
            //There's a chance the user can chose the cleric to attack an enemy, then change their mind to the special.
            //This means the enemy will still be selected so set the checked values to false just to be sure they aren't checked.
            banditBox.Checked = false;
            banditTwoBox.Checked = false;
            banditThreeBox.Checked = false;
            trollBox.Checked = false;
            trollTwoBox.Checked = false;
            trollThreeBox.Checked = false;
            dragonBox.Checked = false;

            //Disable the checkboxes for the enemies because the cleric's special ability doesn't need them.
            banditBox.Enabled = false;
            banditTwoBox.Enabled = false;
            banditThreeBox.Enabled = false;
            trollBox.Enabled = false;
            trollTwoBox.Enabled = false;
            trollThreeBox.Enabled = false;
            dragonBox.Enabled = false;
        }//end IfClericSpecialAbilityChecked.

        /// <summary>
        /// Method for if the cleric's special ability is unchecked on the form.
        /// Re-enable the other check boxes on the form if the box is unchecked so the user can select them if they chose.
        /// </summary>
        private void IfClericSpecialAbilityUnChecked()
        {
            //Re-enable the check boxes for the enemies if the special box was checked, then unchecked.
            banditBox.Enabled = true;
            banditTwoBox.Enabled = true;
            banditThreeBox.Enabled = true;
            trollBox.Enabled = true;
            trollTwoBox.Enabled = true;
            trollThreeBox.Enabled = true;
            dragonBox.Enabled = true;
        }//end IfClericSpecialAbilityUnChecked.

        #endregion

        #endregion

        //Handlers for when the checkboxes for the bandit, troll, or dragon are selected on the form.
        #region Enemy Checkbox Handlers

        //Handlers for the three bandit checkboxes on the form.
        #region Bandit Checkbox Handlers

        /// <summary>
        /// Handler for if the bandit box is selected on the form. Sets the selected enemy to the bandit and disables the other boxes.
        /// </summary>
        private void BanditBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the box is checked.
            if (banditBox.Checked)
            {
                //Set the selected enemy to the bandit instance in Game.cs.
                selectedEnemy = game.bandit;

                //Disable the other checkboxes.
                banditTwoBox.Enabled = false;
                banditThreeBox.Enabled = false;
                trollBox.Enabled = false;
                trollTwoBox.Enabled = false;
                trollThreeBox.Enabled = false;
                dragonBox.Enabled = false;
            }

            //Otherwise the box is unchecked or was checked and unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other checkboxes.
                selectedEnemy = null;
                banditTwoBox.Enabled = true;
                banditThreeBox.Enabled = true;
                trollBox.Enabled = true;
                trollTwoBox.Enabled = true;
                trollThreeBox.Enabled = true;
                dragonBox.Enabled = true;
            }
        }//end BanditBox_CheckedChanged.

        private void BanditTwoBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the box is checked.
            if (banditTwoBox.Checked)
            {
                //Set the selected enemy to the bandit two instance in Game.cs.
                selectedEnemy = game.banditTwo;

                //Disable the other two checkboxes.
                banditBox.Enabled = false;
                banditThreeBox.Enabled = false;
                trollBox.Enabled = false;
                trollTwoBox.Enabled = false;
                trollThreeBox.Enabled = false;
                dragonBox.Enabled = false;
            }

            //Otherwise the box is unchecked or was checked and unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other two checkboxes.
                selectedEnemy = null;
                banditBox.Enabled = true;
                banditThreeBox.Enabled = true;
                trollBox.Enabled = true;
                trollTwoBox.Enabled = true;
                trollThreeBox.Enabled = true;
                dragonBox.Enabled = true;
            }
        }//end BanditTwoBox_CheckedChanged.

        private void BanditThreeBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the box is checked.
            if (banditThreeBox.Checked)
            {
                //Set the selected enemy to the bandit two instance in Game.cs.
                selectedEnemy = game.banditThree;

                //Disable the other two checkboxes.
                banditBox.Enabled = false;
                banditTwoBox.Enabled = false;
                trollBox.Enabled = false;
                trollTwoBox.Enabled = false;
                trollThreeBox.Enabled = false;
                dragonBox.Enabled = false;
            }

            //Otherwise the box is unchecked or was checked and unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other two checkboxes.
                selectedEnemy = null;
                banditBox.Enabled = true;
                banditTwoBox.Enabled = true;
                trollBox.Enabled = true;
                trollTwoBox.Enabled = true;
                trollThreeBox.Enabled = true;
                dragonBox.Enabled = true;
            }
        }//end BanditThreeBox_CheckedChanged.

        #endregion

        //Handlers for the three troll checkboxes on the form.
        #region Troll Checkbox Handlers

        /// <summary>
        /// Handler for if the troll box is checked on the form. Sets the selected enemy to the troll and disables the other two checkboxes.
        /// </summary>
        private void TrollBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the troll box is checked on the form.
            if (trollBox.Checked)
            {
                //Set the selected enemy to the troll instance from Game.cs.
                selectedEnemy = game.troll;

                //Disable the other two checkboxes so the user can't select multiple enemies to attack.
                banditBox.Enabled = false;
                banditTwoBox.Enabled = false;
                banditThreeBox.Enabled = false;
                dragonBox.Enabled = false;
                trollTwoBox.Enabled = false;
                trollThreeBox.Enabled = false;
            }

            //Otherwise the box is unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other two check boxes for the other enemies.
                selectedEnemy = null;
                banditBox.Enabled = true;
                banditTwoBox.Enabled = true;
                banditThreeBox.Enabled = true;
                dragonBox.Enabled = true;
                trollTwoBox.Enabled = true;
                trollThreeBox.Enabled = true;
            }
        }//end TrollBox_CheckedChanged.

        private void TrollTwoBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the troll box is checked on the form.
            if (trollTwoBox.Checked)
            {
                //Set the selected enemy to the troll instance from Game.cs.
                selectedEnemy = game.trollTwo;

                //Disable the other two checkboxes so the user can't select multiple enemies to attack.
                banditBox.Enabled = false;
                banditTwoBox.Enabled = false;
                banditThreeBox.Enabled = false;
                dragonBox.Enabled = false;
                trollBox.Enabled = false;
                trollThreeBox.Enabled = false;
            }

            //Otherwise the box is unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other two check boxes for the other enemies.
                selectedEnemy = null;
                banditBox.Enabled = true;
                banditTwoBox.Enabled = true;
                banditThreeBox.Enabled = true;
                dragonBox.Enabled = true;
                trollBox.Enabled = true;
                trollThreeBox.Enabled = true;
            }
        }//end TrollTwoBox_CheckedChanged.

        private void TrollThreeBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the troll box is checked on the form.
            if (trollThreeBox.Checked)
            {
                //Set the selected enemy to the troll instance from Game.cs.
                selectedEnemy = game.trollThree;

                //Disable the other two checkboxes so the user can't select multiple enemies to attack.
                banditBox.Enabled = false;
                banditTwoBox.Enabled = false;
                banditThreeBox.Enabled = false;
                dragonBox.Enabled = false;
                trollBox.Enabled = false;
                trollTwoBox.Enabled = false;
            }

            //Otherwise the box is unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other check boxes for the other enemies.
                selectedEnemy = null;
                banditBox.Enabled = true;
                banditTwoBox.Enabled = true;
                banditThreeBox.Enabled = true;
                dragonBox.Enabled = true;
                trollBox.Enabled = true;
                trollTwoBox.Enabled = true;
            }
        }//end TrollThreeBox_CheckedChanged.

        #endregion

        /// <summary>
        /// Handler for if the dragon checkbox is selected on the form. Sets the selected enemy and disables the other two checkboxes.
        /// </summary>
        private void DragonBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the dragon box is checked on the form.
            if (dragonBox.Checked)
            {
                //Set the selected enemy to the dragon.
                selectedEnemy = game.dragon;

                //Disable the boxes for the other enemies so the user can't select multiple.
                banditBox.Enabled = false;
                trollBox.Enabled = false;
                trollTwoBox.Enabled = false;
                trollThreeBox.Enabled = false;
                banditTwoBox.Enabled = false;
                banditThreeBox.Enabled = false;
            }

            //Otherwise the box is unchecked.
            else
            {
                //Set the selected enemy to null and re-enable the other checkboxes.
                selectedEnemy = null;
                banditBox.Enabled = true;
                trollBox.Enabled = true;
                trollTwoBox.Enabled = true;
                trollThreeBox.Enabled = true;
                banditTwoBox.Enabled = true;
                banditThreeBox.Enabled = true;
            }
        }//end DragonBox_CheckedChanged.

        #endregion

        //Methods to setup the health bars for the heroes and enemies by setting the maximum, minimum, and default values.
        #region Health Bar Setup

        /// <summary>
        /// Setup the health bars on the form by calling methods to setup the max, min, and default health for the heroes and enemies on the form.
        /// </summary>
        private void SetupHealthBars()
        {
            SetupMaximumHealth();
            SetupMinimumHealth();
            SetupDefaultHealth();
        }//end SetupHealthBars.

        /// <summary>
        /// Set the maximum value for the health bars of the heros and enemies on the form.
        /// </summary>
        private void SetupMaximumHealth()
        {
            //Set the maximum health of the heroes each to 100.
            warriorHealth.Maximum = 100;
            mageHealth.Maximum = 100;
            clericHealth.Maximum = 100;

            //Set the max health of the bandits.
            banditHealth.Maximum = 100;
            banditTwoHealth.Maximum = 100;
            banditThreeHealth.Maximum = 100;

            //Set the max health of the trolls.
            trollHealth.Maximum = 100;
            trollTwoHealth.Maximum = 100;
            trollThreeHealth.Maximum = 100;

            //Set the max health of the dragon.
            dragonHealth.Maximum = 250;
        }//end SetupMaximumHealth.

        /// <summary>
        /// Setup the minimum health for the health bars on the heros and enemies on the form.
        /// </summary>
        private void SetupMinimumHealth()
        {
            //Set the maximum health of the heroes each to 100.
            warriorHealth.Minimum = 0;
            mageHealth.Minimum = 0;
            clericHealth.Minimum = 0;

            //Set the max health of the bandits.
            banditHealth.Minimum = 0;
            banditTwoHealth.Minimum = 0;
            banditThreeHealth.Minimum = 0;

            //Set the max health of the trolls.
            trollHealth.Minimum = 0;
            trollTwoHealth.Minimum = 0;
            trollThreeHealth.Minimum = 0;

            //Set the max health of the dragon.
            dragonHealth.Minimum = 0;
        }//end SetupMinimumHealth.

        /// <summary>
        /// Set the value of the health bars on the form to a default of the max health.
        /// </summary>
        private void SetupDefaultHealth()
        {
            //Set the maximum health of the heroes each to 100.
            warriorHealth.Value = 100;
            mageHealth.Value = 100;
            clericHealth.Value = 100;

            //Set the max health of the bandits.
            banditHealth.Value = 100;
            banditTwoHealth.Value = 100;
            banditThreeHealth.Value = 100;

            //Set the max health of the trolls.
            trollHealth.Value = 100;
            trollTwoHealth.Value = 100;
            trollThreeHealth.Value = 100;

            //Set the max health of the dragon.
            dragonHealth.Value = 250;
        }//end SetHealthValue.

        /// <summary>
        /// Method to update the health bars on the form with the new health of the entity in case they took damage or were healed.
        /// </summary>
        private void UpdateHealthBars()
        {
            //Update the hero health bars.
            CheckWarriorHealth();
            CheckMageHealth();
            CheckClericHealth();

            CheckHealthBars(banditHealth, game.bandit);
            CheckHealthBars(banditTwoHealth, game.banditTwo);
            CheckHealthBars(banditThreeHealth, game.banditThree);
            CheckHealthBars(trollHealth, game.troll);
            CheckHealthBars(trollTwoHealth, game.trollTwo);
            CheckHealthBars(trollThreeHealth, game.trollThree);
            CheckHealthBars(dragonHealth, game.dragon);
  
            //Update the bandit enemy health bars.
            banditHealth.Value = game.bandit.Health;
            banditTwoHealth.Value = game.banditTwo.Health;
            banditThreeHealth.Value = game.banditThree.Health;

            //Update the troll enemy health bars.
            trollHealth.Value = game.troll.Health;
            trollTwoHealth.Value = game.trollTwo.Health;
            trollThreeHealth.Value = game.trollThree.Health;

            //Update the dragon enemy health bars.
            dragonHealth.Value = game.dragon.Health;
        }//end UpdateHealthBars.

        /// <summary>
        /// Checks to see if the value of the health bars are less than 0. If they are, then set the health of the entity to 0.
        /// </summary>
        private void CheckHealthBars(ProgressBar healthBar, Entity entity)
        {
            if (entity.Health <= 0)
            {
                healthBar.Value = 0;
            }
        }//end CheckHealthBars.

        /// <summary>
        /// Check the health of the warrior in the game. If it's zero or less, set it to zero, update the outputbox, and remove the warrior from the form.
        /// Otherwise, set it to the health from Game.cs.
        /// </summary>
        private void CheckWarriorHealth()
        {
            int count = 0;

            if (game.warrior.Health <= 0)
            {
                //Remove the warrior from the game by setting it's visibility to false and health to 0.
                game.warrior.Health = 0;
                warriorBox.Visible = false;
                warriorPicture.Visible = false;
                warriorBox.Checked = false;
                warriorBox.Enabled = false;
                warriorHealth.Visible = false;
                
                //If the count variable is zero, print that the warrior has been defeated and remove them from the list in Game.cs.
                //Increment count to make sure the output isn't printed multiple times.
                if(count == 0)
                {
                    outputBox.AppendText("The warrior has been defeated!\n");
                    game.heroList.Remove('w');
                    count++;
                }
            }

            //Otherwise, set the warrior's health to the health from Game.cs.
            else
            {
                warriorHealth.Value = game.warrior.Health;
            }
        }//end CheckWarriorHealth.

        /// <summary>
        /// Check the health of the mage. If it's zero or less, set it to zero, remove the mage from the form, and update the output box.
        /// Otherwise set it to the health from the game class.
        /// </summary>
        private void CheckMageHealth()
        {
            int count = 0;

            if (game.mage.Health <= 0)
            {
                //Remove the mage from the board by setting all it's visibility properties to false and health to 0.
                game.mage.Health = 0;
                mageBox.Visible = false;
                magePicture.Visible = false;
                mageBox.Checked = false;
                mageBox.Enabled = false;
                mageHealth.Visible = false;

                //Check to see if the count variable is zero so the game only displays that the mage has been defeated once.
                //Remove the mage from the heroList in Game.cs so they are no longer able to be selected by the enemies.
                if(count == 0)
                {
                    outputBox.AppendText("The mage has been defeated!\n");
                    game.heroList.Remove('m');
                    count++;
                }
            }

            //Otherwise set the mage's healthbar value to the value from Game.cs.
            else
            {
                mageHealth.Value = game.mage.Health;
            }
        }//end CheckMageHealth.

        /// <summary>
        /// Checks to make sure the health of the mage is greater than zero.
        /// If it's not, disable the cleric from the form, set its health to zero, and update the output box.
        /// </summary>
        private void CheckClericHealth()
        {
            int count = 0;

            if (game.cleric.Health <= 0)
            {
                //Remove the cleric from the game by setting the visibility features to false and health to 0.
                game.cleric.Health = 0;
                clericBox.Visible = false;
                clericPicture.Visible = false;
                clericBox.Visible = false;
                clericBox.Checked = false;
                clericHealth.Visible = false;

                //Check to see if the count variable is zero so the game only displays that the mage has been defeated once.
                //Remove the mage from the heroList in Game.cs so they are no longer able to be selected by the enemies.
                if (count == 0)
                {
                    outputBox.AppendText("The cleric has been defeated!\n");
                    game.heroList.Remove('c');
                    count++;
                }
            }

            //Update the cleric's health bar value to it's value from Game.cs.
            else
            {
                clericHealth.Value = game.cleric.Health;
            }
        }//end CheckClericHealth.

        #endregion

        //Methods to make sure boxes for a hero, action, and enemy have been selected on the form.
        #region Check Boxes Clicked

        /// <summary>
        /// Checks if the boxes for the heroes have been clicked. Displays a message box if none of the hero boxes are selected.
        /// </summary>
        private bool CheckHeroBoxesClicked()
        {
            //If none of the boxes to select the hero are checked.
            if (!(warriorBox.Checked) && !(clericBox.Checked) && !(mageBox.Checked))
            {
                MessageBox.Show("Please chose a hero before continuing");
            }

            return false;
        }//end CheckHeroBoxesClicked.

        /// <summary>
        /// Check if the boxes for the actions have been clicked. Displays a message box if none of the actions are selected.
        /// </summary>
        private bool CheckActionBoxesClicked()
        {
            //If none of the boxes to select the action are checked.
            if (!(attackBox.Checked) && !(defendBox.Checked) && !(specialBox.Checked))
            {
                MessageBox.Show("Please chose an action before continuing");
            }

            return false;
        }//end CheckActionBoxesClicked.

        /// <summary>
        /// Check if the boxes for the enemies have been clicked. Display a message box if none of the actions are selected.
        /// </summary>
        private bool CheckEnemyBoxesClicked()
        {
            //If the enemy boxes haven't been checked, and the cleric and special box are not checked.
            //If the cleric and special boxes aren't checked, it's okay because the cleric's special ability doesn't need enemies because it heals the other heroes.
            if (!(banditBox.Checked) && !(banditTwoBox.Checked) && !(banditThreeBox.Checked) && !(trollBox.Checked) &&
                !(trollTwoBox.Checked) && !(trollThreeBox.Checked) && !(dragonBox.Checked) && !(clericBox.Checked && specialBox.Checked))
            {
                MessageBox.Show("Please chose an enemy before contiuning");
            }

            return false;
        }//CheckedEnemyBoxesClicked.

        #endregion

        //Methods to disable an entity's checkbox, picturebox, and health bar after they have been defeated.
        #region Disable Entities After Defeat

        /// <summary>
        /// Method to check if an enemy has been defeated by checking the value of their health in Game.cs.
        /// If the value is 0, grey out their image on the form and disable their button so the player can't use them any more.
        /// </summary>
        private void CheckIfDefeated(Entity entity)
        {
            CheckBanditDefeated(entity);
            CheckSecondBanditDefeated(entity);
            CheckThirdBanditDefeated(entity);
            CheckDragonDefeated(entity);
        }//end CheckIfDefeated.

        /// <summary>
        /// Method to be called if the bandit is defeated in the game. Disables and unchecks the bandit's checkbox, and disables their picture and health bar.
        /// </summary>
        private void CheckBanditDefeated(Entity entity)
        {
            //If the entity is not null, is the bandit, and it's health is 0, disable it's features on the forms so the user can't use it anymore.
            if(entity != null && entity.Name.Equals("bandit") && entity.Health == 0)
            {
                banditBox.Checked = false;
                banditBox.Visible = false;
                banditPicture.Enabled = false;
                banditHealth.Enabled = false;

                banditPicture.Visible = false;
                banditHealth.Visible = false;

                //Reset the bandit's health back to 100 for the next wave.
                game.bandit.Health = 100;

                //Remove the bandit from the list in Game.cs.
                game.waveTwo.Remove('b');

                //Update the wave number from Game.cs if the bandit is defeated.
                if (game.waves == 1)
                {
                    game.waves = 2;
                }

                //Update the text to the output box notifying the user that the bandit was defeated.
                outputBox.AppendText("The bandit has been defeated!\n");
            }
        }//end BanditDefeated.

        /// <summary>
        /// Method to be called if the second bandit is defeated. Uncheck and disable checkbox, picture, and healthbar.
        /// </summary>
        private void CheckSecondBanditDefeated(Entity entity)
        {
            if(entity != null && entity.Name.Equals("second bandit") && entity.Health == 0)
            {
                banditTwoBox.Checked = false;
                banditTwoBox.Visible = false;
                banditTwoPicture.Enabled = false;
                banditTwoHealth.Enabled = false;

                banditTwoPicture.Visible = false;
                banditTwoHealth.Visible = false;

                //Remove the second bandit from the list in Game.cs.
                game.waveTwo.Remove('2');

                outputBox.AppendText("The second bandit has been defeated!\n");
            }
        }//end SecondBanditDefeated.

        /// <summary>
        /// Method to be called if the third bandit is defeated. Uncheck and disable third bandit checkbox, picture, and healthbar.
        /// </summary>
        private void CheckThirdBanditDefeated(Entity entity)
        {
            if(entity != null && entity.Name.Equals("third bandit") && entity.Health == 0)
            {
                banditThreeBox.Checked = false;
                banditThreeBox.Visible = false;
                banditThreePicture.Enabled = false;
                banditThreeHealth.Enabled = false;

                banditThreePicture.Visible = false;
                banditThreeHealth.Visible = false;

                //Remove the third bandit from the list in Game.cs.
                game.waveTwo.Remove('3');

                outputBox.AppendText("The third bandit has been defeated\n");
            }
        }//end ThirdBanditDefeated.

        /// <summary>
        /// Method to check if the dragon has been defeated by checking to see if it's health is zero or below. Uncheck and disable it's checkbox, picture, and healthbar on the form.
        /// </summary>
        private void CheckDragonDefeated(Entity entity)
        {
            if(entity != null && entity.Name.Equals("dragon") && entity.Health <= 0)
            {
                dragonBox.Checked = false;
                dragonBox.Visible = false;
                dragonPicture.Enabled = false;
                dragonHealth.Enabled = false;

                dragonPicture.Visible = false;
                dragonHealth.Visible = false;

                outputBox.AppendText("The dragon has been defeated! Congratulations!\n");
            }
        }//end CheckDragonDefeated.

        #endregion

        /// <summary>
        /// Button click handler for the action box. Makes sure one of each checkbox has been checked onthe form, then performs the selected action based on a switch.
        /// Updates the health bars by calling UpdateHealthBars(), and checks if the selected enemy was defeated.
        /// </summary>
        private void ActionButton_Click(object sender, EventArgs e)
        {
            //Call methods to check if the boxes have been selected to chose a hero, action, and enemy.
            CheckHeroBoxesClicked();
            CheckActionBoxesClicked();
            CheckEnemyBoxesClicked();

            DetermineAction();

            //Call RunGame from Game.cs to get the enemies to attack the player's heroes.
            game.RunGame();

            //Check if the enemies have been defeated.
            CheckIfDefeated(game.bandit);
            CheckIfDefeated(game.banditTwo);
            CheckIfDefeated(game.banditThree);
            CheckIfDefeated(game.dragon);


            //Update the health bars on the forms to reflect the new health if the players took damage or were healed.
            UpdateHealthBars();
            
            //Check to see if the wave needs to be updated by calling UpdateWaves.
            UpdateWaves();

        }//end actionButton_Click.

        /// <summary>
        /// Determine which method to call based on which action is selected by the user on the form. Uses a switch to determine if it's a, d, or s.
        /// </summary>
        private void DetermineAction()
        {
            switch(selectedAction)
            {
                //If the selected action is attack, call the method to attack the selected enemy.
                case 'a':
                    AttackSelected();
                    break;

                //If the selected action is defend, call the method to defend from the selected enemy.
                case 'd':
                    DefendSelected(selectedHero);
                    break;

                //If the selection action is special, call the method to perform the hero's special action.
                case 's':
                    
                    break;

                //Default switch case.
                default:
                    break;
            }//end switch

            NonSelectedDefend();
        }//end DetermineAction.

        /// <summary>
        /// Method to perform actions for the heroes on the board that weren't selected by the user.
        /// For loop to loop through the list of heroes in Game.cs, compares the index in the list with selectedHero.
        /// If they don't match, the hero on the list at the selected index will defend from the selected enemy.
        /// </summary>
        private void NonSelectedDefend()
        {
            //Loop through the list of heroes in Game.cs and determine if they are not the hero that is currently selected by the enemy.
            for (int i = 0; i < game.heroList.Count; i++)
            {
                if (selectedHero != null && game.heroList[i] != selectedHero.Type)
                {
                    //If the selected hero isn't the hero in the list, the hero will defend from the enemy the player has selected.
                    switch(game.heroList[i])
                    {
                        case 'w':
                            DefendSelected(game.warrior);
                            break;

                        case 'm':
                            DefendSelected(game.mage);
                            break;

                        case 'c':
                            DefendSelected(game.cleric);
                            break;
                    }//end switch.
                }
            }
        }//end NonSelectedDefend.

        /// <summary>
        /// Method to attack an enemy if the selected action is 'a' for attack. Calls the damage method from Game.cs and passes the selected enemy and selected hero.
        /// Need to find a better way to calculate the damage dealt to the enemies using the hero's properties.
        /// </summary>
        private void AttackSelected()
        {
            //Check to make sure the enemy and hero aren't null before doing damage.
            if(selectedEnemy != null && selectedHero != null)
            {
                game.Damage(selectedEnemy, 10,  selectedHero);
                outputBox.AppendText(game.UpdateOutputBox(selectedHero.Name, selectedEnemy.Name, game.Damage(selectedEnemy, 10, selectedHero), 0, 'a', selectedHero.Type));
            }
        }//end AttackSelected.

        /// <summary>
        /// Method to defend from the selected enemy on the form. Will be called from the action button click handler if 'd' is the selected action, meaning the defend box was checked.
        /// </summary>
        private void DefendSelected(Entity hero)
        {
            game.Defend(hero, 10, selectedEnemy);
        }//end DefendSelected.

        /// <summary>
        /// Update the enemies on the form based on the wave the user is on from Game.cs.
        /// </summary>
        private void UpdateWaves()
        {
            if(game.waves == 1)
            {
                outputBox.AppendText(game.WaveOne());
            }

            //If the user is on the second wave, call WaveTwoDisplay to update the form for the second wave of enemies.
            if(game.waves == 2)
            {
                WaveTwoDisplay();
            }

            if(game.waves > 2 && game.waves < 3)
            {
                outputBox.AppendText(game.WaveTwo());
            }

            //If all 3 bandits have been defeated and their checkboxes are invisible, update the waves in the game to 3 and display wave 3.
            if(banditBox.Visible == false && banditTwoBox.Visible == false && banditThreeBox.Visible == false)
            {
                game.waves = 3;
                WaveThreeDisplay();
            }

            if (trollBox.Visible == false && trollTwoBox.Visible == false && trollThreeBox.Visible == false && banditBox.Visible == false && banditTwoBox.Visible == false && banditThreeBox.Visible == false)
            {
                game.waves = 4;
                WaveFourDisplay();
            }
        }//end UpdateWaves.

        /// <summary>
        /// Method to show the 3 bandits on the form for the second wave of the game. Re-enables each bandit's picture, checkbox, and healthbar.
        /// Resets the bandit's health bar to 100 because it is still at 0 from when they were defeated in wave 1.
        /// </summary>
        private void WaveTwoDisplay()
        {
            //Need to update the waves to something in between 2 and 3, because if the wave stays at 2 it will keep re-enabling the bandits everytime the user clicks the button.
            game.waves = 2.5;

            outputBox.AppendText("Congratulations! You have reached wave 2.\n3 wild bandits appear!\n'Hand over your valuables or I'll gut you like a fish' they say\nWhat will you do?\n");

            //Updates for the bandit.
            banditBox.Checked = false;
            banditBox.Visible = true;
            banditPicture.Visible = true;
            banditHealth.Visible = true;
            banditHealth.Value = 100;

            //Updates for banditTwo.
            banditTwoBox.Checked = false;
            banditTwoBox.Visible = true;
            banditTwoPicture.Visible = true;
            banditTwoHealth.Visible = true;

            //Updates for banditThree
            banditThreeBox.Checked = false;
            banditThreeBox.Visible = true;
            banditThreePicture.Visible = true;
            banditThreeHealth.Visible = true;
        }//end WaveTwoDisplay.

        /// <summary>
        /// Display the enemies for the third wave of the game. Will display the three trolls on the form.
        /// </summary>
        private void WaveThreeDisplay()
        {
            //Set waves to something in between 3 and 4 so it doesn't keep re-enabling the trolls when the user clicks the button.
            game.waves = 3.5;

            outputBox.AppendText("Congratulations! You have reached wave 3.\nThree wild trolls appear! What will you do?\n");

            trollBox.Visible = true;
            trollHealth.Visible = true;
            trollBox.Checked = false;
            trollPicture.Visible = true;

            trollTwoBox.Checked = false;
            trollTwoBox.Visible = true;
            trollTwoPicture.Visible = true;
            trollTwoHealth.Visible = true;

            trollThreeBox.Checked = false;
            trollThreeBox.Visible = true;
            trollThreePicture.Visible = true;
            trollThreeHealth.Visible = true;
        }//end WaveThreeDisplay.

        /// <summary>
        /// Display the dragon for the fourth and final wave of the game.
        /// </summary>
        private void WaveFourDisplay()
        {
            game.waves = 4.5;

            outputBox.AppendText("Congralutations! You have reached the final wave.\nAre you ready to face the dragon?\n");

            dragonBox.Checked = false;
            dragonBox.Visible = true;
            dragonPicture.Visible = true;
            dragonHealth.Visible = true;
        }//end WaveFourDisplay().

    }//end RPG partial class.
}