using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class FRM_PlayGround : Form
    {
        public FRM_PlayGround()
        {
            InitializeComponent();
            // Default form settings:
            DefaultForm();
            // ****************** Combined Event (Click Button) Handler ***



            foreach (Button BTN in PlayGroundCells)
            {
                BTN.Click += new EventHandler(ApplyTurnChanges);
            }


        }
        // All Cell Buttons:
        public Button[] PlayGroundCells;
        // Initialize Buttons:
        public Button[] InitializePlayGroundButtons() 
        {
            Button[] CreatedPlayCoundCells = new Button[9];
            int Counter = 0;
            foreach (Button BTN in this.Controls.OfType<Button>())
            {
                if (BTN != BTN_Restart) // Check if the button is not BTN_Restart
                {

                    CreatedPlayCoundCells[Counter]= (BTN);
                    Counter++;
                }
            }

            return CreatedPlayCoundCells;
        }
        public Image[] AvailableImages = { Resources.X, Resources.O };
        private void FRM_PlayGround_Paint(object sender, PaintEventArgs e)
        {
            Pen GridDrawer = new Pen(Color.White, 6);

            GridDrawer.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            GridDrawer.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Using griaphics class :
            // H1
            e.Graphics.DrawLine(GridDrawer, 400, 300, 940, 300);
            //H2
            e.Graphics.DrawLine(GridDrawer, 400, 480, 940, 480);

            // V1

            e.Graphics.DrawLine(GridDrawer, 580, 120, 580, 660);

            // V2

            e.Graphics.DrawLine(GridDrawer, 760, 120, 760, 660);
        }


        // Winning Axesis:


        private static List<Button[]> WinningButtons = new List<Button[]>();

        public List<Button[]> WinButtons() 
        {
            

            // Winning rows:
            Button[] FirstRow = { BTN_Cell1, BTN_Cell2, BTN_Cell3 };
            Button[] SecondRow= { BTN_Cell4, BTN_Cell5, BTN_Cell6 };
            Button[] ThirdRow = { BTN_Cell7, BTN_Cell8, BTN_Cell9 };
            // Winning Columns:
            Button[] FirstColumn = { BTN_Cell1, BTN_Cell4, BTN_Cell7 };
            Button[] SecondColunm = { BTN_Cell2, BTN_Cell5, BTN_Cell8 };
            Button[] ThirdColumn = { BTN_Cell3, BTN_Cell6, BTN_Cell9 };
            // Winning Diagonals:
            Button[] FirstDiagonal = { BTN_Cell1, BTN_Cell5, BTN_Cell9 };
            Button[] SecondDiagonal = { BTN_Cell3, BTN_Cell5, BTN_Cell7 };

            WinningButtons.Add(FirstRow);
            WinningButtons.Add(SecondRow);
            WinningButtons.Add(ThirdRow);
            WinningButtons.Add(FirstColumn);
            WinningButtons.Add(SecondColunm);
            WinningButtons.Add(ThirdColumn);
            WinningButtons.Add(FirstDiagonal);
            WinningButtons.Add(SecondDiagonal);

            return WinningButtons;
        }


        private static Button[] WinnerCells;

        private void InitializeWinnerCells() 
        {
            WinnerCells = new Button[3];
            
            for(int Index= 0; Index < 3; Index++) 
            {
                WinnerCells[Index] = new Button();
            }
        }


        // Current Move Evaluation Result:
        private static bool EvaluationResult= false;
        // ******************* Player Creators **********

        // PlayerPrototype:

        public struct stPlayerPrototype
        {
            public string ID ;
            public int MovesCount ;          
            public Image Symbol;
        }

        private static stPlayerPrototype InitializePlayer() 
        {
            stPlayerPrototype Player = new stPlayerPrototype();
            Player.ID = "";
            Player.MovesCount = 0;
            Player.Symbol = null;

            return Player;

        }

        // Player Creator Class:

        public class clsPlayer
        {
            public stPlayerPrototype Player = InitializePlayer();

            public List<Button> ChoosenButtons = new List<Button>();
            

            public void SetPlayerID(string ID)
            {
                Player.ID = ID;
            }

            public void IncreaseMovesCount()
            {
                Player.MovesCount++;
            }

            public void ChoosePlayerSymbol(Image Choosensymbol)
            {
                Player.Symbol = Choosensymbol;
            }



            public void AddToChoosenButtons(object sender)
            {
                Button CurrentButton = (Button)sender;
                ChoosenButtons.Add(CurrentButton);
            }


            private bool PotionalCellIncludedInChoosen(Button PotionalWinCell) 
            {
                foreach(Button BTN in ChoosenButtons) 
                {
                    if(BTN == PotionalWinCell) 
                    {
                        return true;
                    }
                }
                
                return false;
            }

            private bool PotionalWinnerGroupIncludedInChoosen(Button[] PotionalWinnerGroup) 
            {
                foreach(Button BTN in PotionalWinnerGroup) 
                {
                    if (!PotionalCellIncludedInChoosen(BTN)) 
                    {
                        return false;
                    }
                }
                return true;
            }

            public bool CompareAllWinnerGroupsToChoosen() 
            {
                foreach (Button[] WinCellSGroup in WinningButtons)
                {
                    if (PotionalWinnerGroupIncludedInChoosen(WinCellSGroup))
                    {
                        WinnerCells = WinCellSGroup;
                        return true;
                    }
                }
                return false;
            }


            public int CurrentMovesCount()
            {
                return Player.MovesCount;
            }

            public Image CurrentPlayerImage()
            {
                return Player.Symbol;
            }

            public string PlayerID() { return Player.ID; }






            // CONSTRUCTOR:
            public clsPlayer(string CurrentPlayerId, Image CurrentSymbol)
            {
                Player.ID = CurrentPlayerId;
                Player.Symbol = CurrentSymbol;                
                Player.MovesCount = 0;
            }
            ~clsPlayer() { }

            // Static Constructor:
            public static clsPlayer AddPlayer(string CurrentPlayerId = "", Image CurrentSymbol = null)
            {
                string DefaultId = "First Player";

                if (string.IsNullOrEmpty(CurrentPlayerId))
                {
                    CurrentPlayerId = DefaultId;
                }

                if (CurrentSymbol == null)
                {
                    CurrentSymbol = Resources.X;
                }

                return new clsPlayer(CurrentPlayerId, CurrentSymbol);
            }


        };

        // Players:

        public clsPlayer[] Players = new clsPlayer[2];
        private static clsPlayer PlayerInCharge;

        // Setting Default values of players:
        public clsPlayer[] DefaultPlayers()
        {

            Players = new clsPlayer[2];
            Players[0] = new clsPlayer("FirstPlayer", Resources.X);
            Players[1] = new clsPlayer("SecondPlayer", Resources.O);
            PlayerInCharge = Players[0];
            return Players;
        }


        public void ResetButtonsBackgroundColors()
        {
            // Define the default background color (you can adjust this to your actual default color).
            //Color defaultBackgroundColor = SystemColors.Control;

            // Check if WinnerCells is not null and iterate through all of the buttons on the form.

            
            foreach (Button BTN in WinnerCells)
            {
                
                BTN.BackColor = Color.LightGray;
            }
            
        }

        public void DefaultPlayGound()
        {
            
            PlayGroundCells= InitializePlayGroundButtons(); 

            //PlayGroundCells = new List<Button>();
            foreach (Button BTN in PlayGroundCells)
            {
                // Buttons are available:
                BTN.Enabled = true;

                // Default Image:
                BTN.Image = Resources.question_mark_96;

                // Default Color:
                BTN.BackColor = Color.LightGray;
            }
           // ResetButtonsBackgroundColors();

        }

        // Default Control Panel:


        public void DefaultTurnValue() { LBL_TurnValue.Text = PlayerInCharge.PlayerID(); }
        public void DefaultWinnerValue() { LBL_WinnerValue.Text = "In progress"; }

        // Switch players :

        public void SwitchCurrentPlayer()
        {
            if (PlayerInCharge == Players[0])
            {
                PlayerInCharge = Players[1];
                LBL_TurnValue.Text = PlayerInCharge.PlayerID();

            }

            else if (PlayerInCharge == Players[1])
            {
                PlayerInCharge = Players[0];
                LBL_TurnValue.Text = PlayerInCharge.PlayerID();
            }

        }



        // Winning Case : Back Color Changes:

        private void ChangeWinnerCellsBackColor() 
        {
            foreach(Button BTN in WinnerCells) 
            {
                BTN.BackColor = Color.Green;
            }
        }


        // Winning Scenario Changes:
        public void WinningChanges()
        {
            // Control Panel Winning Changes:
            LBL_TurnValue.Text = "Game over";
            LBL_WinnerValue.Text = PlayerInCharge.PlayerID() + " wins.";

            // Play Ground Winning Changes:

            // A- Background Color:

            ChangeWinnerCellsBackColor();

            // B - Disable all buttons:

            foreach (Button BTN in PlayGroundCells)
            {
                if (BTN.Enabled) { BTN.Enabled = false; }

            }


        }

        public bool ISGameOver()
        {
            foreach (Button BTN in PlayGroundCells)
            {
                if (BTN.Enabled)
                {
                    return false;
                }
            }
            return true;
        }

        // Game keep going on scenario changes:
        public void GameOnChanges()
        {

            // Player in Charge Changes + // Control Panel Changes:
            SwitchCurrentPlayer();
            // **Only call the Invalidate() method on the buttons if the game is not over.**
            //foreach (Button button in PlayGroundCells)
            //{
            //    button.Invalidate();
            //}

        }
        // Game over Scenario changes:
        public void GameOverChanges()
        {
            // Control panel changes:
            LBL_TurnValue.Text = "Game Over";
            LBL_WinnerValue.Text = "Draw";

        }

        // PlayGround Changes:

        public void ChangeCurrentCellImage(Button currentButton)
        {
            // Check if PlayerInCharge is null.
            if (PlayerInCharge != null)
            {
                // Set the image of the current button to the current player's image.
                currentButton.Image = PlayerInCharge.CurrentPlayerImage();
            }

            // Call the Invalidate() method to force the button to redraw itself with the new image.
            currentButton.Invalidate();
        }

        public void DisableCurrentCell(Button CurrentButton) 
        {
            
            CurrentButton.Enabled = false;  
        }

        public void ApplyPlayGroundChanges(object sender, EventArgs e)
        {
            // Get the current button.
            Button currentButton = (Button)sender;

            // Change the image of the current button.
            ChangeCurrentCellImage(currentButton);

            // Disable the current button.
            DisableCurrentCell(currentButton);
        }


        // Player Move's Actions:

        public void ApplyTurnChanges(object sender, EventArgs e)
        {
            // 1- Apply PlayGround Changes:

            ApplyPlayGroundChanges(sender, e);

            // 2-  Add Button to chosen ones:

            PlayerInCharge.AddToChoosenButtons(sender);

            // 3- Increase Player's Moves count:

            PlayerInCharge.IncreaseMovesCount();



            // 4-  Check Winning Case:
            if (PlayerInCharge.CurrentMovesCount() >= 3 ) 
            {
                EvaluationResult = PlayerInCharge.CompareAllWinnerGroupsToChoosen();
            }
            

            if(EvaluationResult == true) 
            {  
                WinningChanges();

                // C - Reset Game:

                //DefaultForm();
                return;
            }
            else if (EvaluationResult== false)
            {
                    // 7- No Winning Case:
                    if (ISGameOver()) 
                    { 
                        GameOverChanges();
                        return;
                    }

                    else
                    GameOnChanges();
                    return;


            }
            

        }


        // ***************** Default Settings *********










        public void DefaultForm()
        {
            EvaluationResult = false;
            WinnerCells = null;
            PlayGroundCells = null;
            
            WinButtons();
            InitializeWinnerCells();
         


            // Default Control Panel Values:

            

            DefaultWinnerValue();

            // Default Play Ground values:

            DefaultPlayGound();

            
            // Default Player In Charge:
            this.Players = null;
            PlayerInCharge = null;
            this.Players = DefaultPlayers();

            DefaultTurnValue();


        }
        // ***************** Restart Button ********
        private void BTN_Restart_Click(object sender, EventArgs e)
        {
            DefaultForm();

        }




    }




}


