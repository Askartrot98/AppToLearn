using System;
using System.Diagnostics;
namespace AppToLearn
{
    public partial class Form1 : Form
    {
        string name = "";
        Character player;
        Enemy enemy;
        int storyStep = 0;

        bool swordChosen = false;
        bool bowChosen = false;
        bool magicWandChosen = false;
        bool isGameStarted = false;
        bool playerTurn = false;
        bool enemyTurn = false;
        bool battleBegin = false;

        public Form1()
        {
            InitializeComponent();
            textBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSword.Visible = false;
            btnBow.Visible = false;
            btnMagicWand.Visible = false;
            btnStartBattle.Visible = false;
            btnMagic.Visible = false;
            btnRunAway.Visible = false;
            textBox.Visible = true;
            storyStep = 0;

            DialogueBox.Text = "Welcome to the Adventure Game! \nPlease enter your character's name:";


        }

        void StartGame()
        {

            if (swordChosen)
            {

                DialogueBox.Text = $"You are now ready to embark on your adventure as a the PROUD {player.Type} {name}! \nYour journey begins now!";
                isGameStarted = true;
                btnConfirm.Visible = true;

            }
            else if (bowChosen)
            {
                DialogueBox.Text = $"You are now ready to embark on your adventure as the BRAVE {player.Type} {name}! \nYour journey begins now!";
                isGameStarted = true;
                btnConfirm.Visible = true;


            }
            else if (magicWandChosen)
            {

                DialogueBox.Text = $"You are now ready to embark on your adventure as the MYSTICAL {player.Type} {name}! \nYour journey begins now!";
                isGameStarted = true;
                btnConfirm.Visible = true;


            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (storyStep == 0)
            {
                name = textBox.Text;
                textBox.Visible = false;
                btnConfirm.Visible = false;
                DialogueBox.Text = $"Welcome {name}! \nChoose your Weapon: \n  Sword \n  Bow \n  Magic Wand";
                btnSword.Visible = true;
                btnBow.Visible = true;
                btnMagicWand.Visible = true;
                btnSword.Text = "Sword";
                btnBow.Text = "Bow";
                btnMagicWand.Text = "Staff";
                storyStep = 1;

            }
            else if (storyStep == 2)
            {

                StartGame();
                storyStep = 3;





            }
            else if (storyStep == 3 && isGameStarted)
            {
                DialogueBox.Text = $"In the forgotten realm of Eldoria, a dark shadow has awakened after centuries of peace.\n" +
             $"The ancient forests whisper of lost creatures, and villages are abandoned in the dead of night.\n" +
             $"You, {name}, have been chosen by the Oracle to face your destiny.\n" +
             $"Your journey begins at dawn, in the heart of the Myrren Forest... ";
                SetImage("eldoriaforest.jpg");
                storyStep++;



            }
            else if (storyStep == 4)
            {
                DialogueBox.Text = ("You venture deeper into the woods, when a sudden rustle breaks the silence...\n" +
            "In front of you appears a crippling small figure, wielding a crude bone spear!");
                SetImage("eldoriaforest.jpg");
                storyStep++;
            }
            else if (storyStep == 5)
            {
                Encounter(new Enemy("Goblin", 50, 0, 5, 10, 100));
                SetImage("goblin.jpg");


            }
            else if (storyStep == 6)
            {
                DialogueBox.Text = ("You continue your journey deeper into the Myrren Forest, where the trees grow denser and the air thickens with mystery.\n" +
                       "Suddenly, you hear a rustling sound nearby...");
                SetImage("eldoriaforest.jpg");
                storyStep++;
            }
            else if (storyStep == 7)
            {
                Encounter(new Enemy("Forest Spirit", 70, 0, 7, 10, 200));
                SetImage("forestspirit.jpg");
            }
            else if (storyStep == 8)
            {

                DialogueBox.Text = ("After defeating the Forest Spirit, you find a hidden path leading to old ruin Temple.\n" +
                       "In the center of the Temple stands an ancient stone altar, glowing faintly with magical energy.\n" +
                       "You feel a strange pull towards it, as if it holds the key to your destiny.");
                SetImage("templeruin.jpg");


                storyStep++;
            }
            else if (storyStep == 9)
            {
                DialogueBox.Text = ("The air is heavy with magic, and you sense that something powerful lies ahead. But something stops your path...");
                storyStep++;
            }
            else if (storyStep == 10)
            {
                Encounter(new Enemy("Ancient Guardian", 100, 0, 10, 10, 100));
                SetImage("stoneguardian.jpg");
            }
            else if (storyStep == 11)
            {
                DialogueBox.Text = ("With the Ancient Guardian defeated, you approach the altar.\n" +
                       "As you touch the stone, a vision fills your mind: The Oracle talks to you.\n" +
                       "You realize that your journey has just begun, and that you must prepare yourself for the battles ahead.");
                SetImage("oracle.jpg");
                storyStep++;
            }
            else if (storyStep == 12) 
            {
                DialogueBox.Text = ("The Oracle reveals that a dark force is rising, threatening all of Eldoria.\n" +
                    "You must gather allies and prepare for the battles to come.");
                SetImage("oracle.jpg");
                storyStep++;
            }
            else if (storyStep == 13)
            {
                DialogueBox.Text = ("You leave the Temple, determined to gather allies and prepare for the battles ahead.\n" +
                    "Your journey continues, and you know that many challenges await you in the days to come.");
                SetImage("templeruin.jpg");
                storyStep++;
            }
            else
            {
                DialogueBox.Text = "You have reached the end of the current story. More adventures await in the future!";
                SetImage("templeruin.jpg");
            }

        }

        private void btnSword_Click(object sender, EventArgs e)
        {
            player = new Character("Warrior", 100, 100, 30, 20);
            DialogueBox.Text = $"You have chosen the Sword! You are a proud {player.Type}";
            btnConfirm.Visible = true;
            playerStats.Text = player.GetStats();
            btnSword.Visible = false;
            btnBow.Visible = false;
            btnMagicWand.Visible = false;
            storyStep++;
            Debug.WriteLine($"Story Step: {storyStep}");
            SetImage("warrior.jpg");
            swordChosen = true;

        }

        private void btnBow_Click(object sender, EventArgs e)
        {
            player = new Character("Archer", 80, 100, 10, 30);
            DialogueBox.Text = $"You have chosen the Bow! You are a brave {player.Type}";
            btnConfirm.Visible = true;
            playerStats.Text = player.GetStats();
            btnSword.Visible = false;
            btnBow.Visible = false;
            btnMagicWand.Visible = false;
            SetImage("Ranger.jpg");
            storyStep++;
            bowChosen = true;

        }

        private void btnMagicWand_Click(object sender, EventArgs e)
        {
            player = new Character("Mage", 60, 100, 0, 40);
            storyStep++;
            DialogueBox.Text = $"You have chosen the Magic Wand! You are a mystical {player.Type}";
            btnConfirm.Visible = true;
            playerStats.Text = player.GetStats();
            btnSword.Visible = false;
            btnBow.Visible = false;
            SetImage("mage.jpg");
            btnMagicWand.Visible = false;

            magicWandChosen = true;

        }


        void Encounter(Enemy encounterEnemy)
        {
            enemy = encounterEnemy;
            DialogueBox.Text = $"You encounter a {enemy.Type}!\n" +
                $"What do you want to do?";
            enemyStats.Text = enemy.GetEnemyStats();
            btnStartBattle.Visible = true;
            btnRunAway.Visible = true;
            btnConfirm.Visible = false;
            btnNegate.Visible = false;
            textBox.Visible = false;
            // Reset stato battaglia
            battleBegin = false;
            playerTurn = false;
            enemyTurn = false;

        }

        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            if (!battleBegin)
            {
                DialogueBox.Text = $"You have chosen to bravely fight the {enemy.Type}!\nPrepare for battle!";
                battleBegin = true;
               
                PickRandomTurn();
                return;
            }

            if (playerTurn)
            {
                int playerDamage = player.DoDamage(enemy);
                DialogueBox.Text = $"You attack the {enemy.Type} and deal {playerDamage} damage!\nEnemy HP: {enemy.Hp}";
                UpdateStatsUI();
                playerTurn = false;
                btnStartBattle.Text = "Avanti";
                btnMagic.Enabled = false;
                btnRunAway.Enabled = false;

                if (enemy.Hp <= 0)
                {
                    player.GainExperience(enemy.Experience);
                    DialogueBox.Text += $"\nYou have defeated the {enemy.Type}!\nYou gain {enemy.Experience} experience points!\nYour total exp is {player.Experience}";
                    btnStartBattle.Visible = false;
                    btnMagic.Visible = false;
                    btnRunAway.Visible = false;
                    btnConfirm.Visible = true;
                    textBox.Visible = false;
                    enemy = null;
                    battleBegin = false;
                    storyStep++;
                    btnStartBattle.Text = "Physical";
                    UpdateStatsUI();
                    return;
                }
            }
            else // Turno del nemico
            {
                EnemyTurn();
            }


        }
      
        void EnemyTurn()
        {
            if (enemy == null || player == null)
                return;

            int enemyDamage = enemy.DoDamage(player);
            DialogueBox.Text = $"The {enemy.Type} attacks you and deals {enemyDamage} damage!\nYour HP: {player.Hp}";
            UpdateStatsUI();

            if (player.Hp <= 0)
            {
                DialogueBox.Text += "\nYou have been defeated!";
                btnStartBattle.Enabled = false;
                btnMagic.Enabled = false;
                btnRunAway.Enabled = false;
                player = null;
                battleBegin = false;
                btnStartBattle.Text = "Physical";
                return;
            }

            playerTurn = true;
            btnStartBattle.Text = "Physical";
            btnStartBattle.Visible = true;
            btnStartBattle.Enabled = true;
            btnMagic.Visible = true;
            btnMagic.Enabled = true;
            btnRunAway.Visible = true;
            btnRunAway.Enabled = true;
        }
        private void btnRunAway_Click(object sender, EventArgs e)
        {
            RunAway();
        }


        private void btnMagic_Click(object sender, EventArgs e)
        {
            if (!playerTurn) return;

            if (player.Mana >= 20)
            {
                int spellDamage = 0;
                switch (player.Type)
                {
                    case "Mage":
                        player.Mana -= 30;
                        spellDamage = player.DoDamage(enemy) + 20;
                        DialogueBox.Text = $"You cast a powerful spell on the {enemy.Type} and deal {spellDamage} damage!\n" +
                                           $"Enemy HP: {enemy.Hp}\n" +
                                           $"Your remaining Mana: {player.Mana}";
                        UpdateStatsUI();
                        break;
                    case "Archer":
                        player.Mana -= 10;
                        spellDamage = player.DoDamage(enemy) + 10;
                        DialogueBox.Text = $"You shoot a magical arrow at the {enemy.Type} and deal {spellDamage} damage!\n" +
                                           $"Enemy HP: {enemy.Hp}\n" +
                                           $"Your remaining Mana: {player.Mana}";
                        UpdateStatsUI();
                        break;
                    case "Warrior":
                        player.Mana -= 20;
                        spellDamage = player.DoDamage(enemy) + 15;
                        DialogueBox.Text = $"You unleash a sword of light on the {enemy.Type} and deal {spellDamage} damage!\n" +
                                           $"Enemy HP: {enemy.Hp}\n" +
                                           $"Your remaining Mana: {player.Mana}";
                        UpdateStatsUI();
                        break;
                }

                playerTurn = false;
                btnStartBattle.Text = "Avanti";
                btnMagic.Enabled = false;
                btnRunAway.Enabled = false;
                textBox.Visible = false;

                if (enemy.Hp <= 0)
                {
                    player.GainExperience(enemy.Experience);
                    DialogueBox.Text += $"\nYou have defeated the {enemy.Type}!\nYou gain {enemy.Experience} experience points!\nYour total exp is {player.Experience}";
                    btnStartBattle.Visible = false;
                    btnMagic.Visible = false;
                    btnRunAway.Visible = false;
                    enemy = null;
                    battleBegin = false;
                    storyStep++;
                    btnStartBattle.Text = "Physical";
                    UpdateStatsUI();
                    btnConfirm.Visible = true;
                    
                    return;
                }
            }
            else
            {
                DialogueBox.Text = "You don't have enough mana to cast a spell!";
                // Non passare il turno al nemico, resta il turno del player
                return;
            }
        }


        void RunAway()
        {
            // Logic for running away, e.g., resetting the encounter
            enemy = null;
            btnStartBattle.Visible = false;
            btnRunAway.Visible = false;
            DialogueBox.Text = "You have successfully escaped the encounter.";
            storyStep++;
        }

        void PickRandomTurn()
        {
            Random random = new Random();
            int turn = random.Next(0, 2); // 0 for player, 1 for enemy
            if (turn == 0)
            {
                playerTurn = true;
                enemyTurn = false;
                DialogueBox.Text = "You have the first turn!";
                btnStartBattle.Text = "Physical";
                btnStartBattle.Visible = true;
                btnStartBattle.Enabled = true;
                btnMagic.Visible = true;
                btnMagic.Enabled = true;
                btnRunAway.Visible = true;
                btnRunAway.Enabled = true;




            }
            else
            {
                playerTurn = false;
                enemyTurn = true;
                DialogueBox.Text = "The enemy has the first turn!";
                btnStartBattle.Visible = false;
                btnMagic.Visible = false;
                btnRunAway.Visible = false;
                EnemyTurn();



            }
        }
        void UpdateStatsUI()
        {
            if (player != null)
                playerStats.Text = player.GetStats();
            else
                playerStats.Text = "";

            if (enemy != null)
                enemyStats.Text = enemy.GetEnemyStats();
            else
                enemyStats.Text = "";
        }

        void SetImage(string image)
        {
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Images", image);
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
