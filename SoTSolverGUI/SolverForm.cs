using System.ComponentModel;
using SoTSolverClassLibrary.Constants;
using SoTSolverClassLibrary.DataAccess;
using SoTSolverClassLibrary.Puzzle;
using SoTSolverClassLibrary.Solver;
using SoTSolverClassLibrary.Utils;

namespace SoTSolverGUI
{
    public partial class SolverForm : Form
    {
        private Button goalButton = null;
        private Button playerButton = null;
        private Button[,] buttonBoard;
        private string goalButtonText = null;
        public SolverForm()
        {
            InitializeComponent();
            seedBox.Maximum = Board.MAX_SEED;
            seedBox.Minimum = Board.MIN_SEED;
            buttonBoard = new[,]
            {
                {buttonA4, buttonB4, buttonC4, buttonD4},
                {buttonA3, buttonB3, buttonC3, buttonD3},
                {buttonA2, buttonB2, buttonC2, buttonD2},
                {buttonA1, buttonB1, buttonC1, buttonD1}
            }
            ;
            foreach (Button button in buttonBoard)
            {
                SetAsEmpty(button);
            }
            Random rand = new Random();
            int randSeed = rand.Next(Board.MIN_SEED, Board.MAX_SEED);
            seedBox.Value = randSeed;
            LoadBoard(new Board(randSeed));
        }

        private void ButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button target = (Button)sender;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ToggleCoal(target);
                    break;
                case MouseButtons.Right:
                    TogglePlayer(target);
                    break;
                case MouseButtons.Middle:
                    ToggleGoal(target);
                    break;
            }
        }

        private void ToggleGoal(Button target)
        {
            if (goalButton == target) return;
            if (goalButton != null)
            {
                goalButton.Text = goalButtonText;
            }
            goalButtonText = target.Text;
            target.Text = "\ud83d\udea9";
            goalButton = target;
        }


        private void ToggleCoal(Button target)
        {
            if (target.BackColor == ColorConstants.CoalBG)
            {
                SetAsEmpty(target);
            }
            else
            {
                if (target == playerButton)
                {
                    playerButton = null;
                }
                SetAsCoal(target);
            }
        }

        private void SetAsCoal(Button target)
        {
            target.BackColor = ColorConstants.CoalBG;
            target.ForeColor = ColorConstants.CoalText;
        }

        private void SetAsEmpty(Button target)
        {
            target.BackColor = ColorConstants.EmptyBG;
            target.ForeColor = ColorConstants.EmptyText;
        }

        private void TogglePlayer(Button target)
        {
            if (target == playerButton) return;
            if (playerButton != null) SetAsEmpty(playerButton);
            target.BackColor = ColorConstants.PlayerBG;
            target.ForeColor = ColorConstants.PlayerText;
            playerButton = target;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            LoadBoard(new Board(0));
            solutionGrid.DataSource = null;
        }

        private void Clear()
        {
            foreach (Button button in buttonBoard)
            {
                SetAsEmpty(button);
            }

            if (goalButton != null)
            {
                goalButton.Text = goalButtonText;
                goalButton = null;
                goalButtonText = null;
            }

            playerButton = null;
            
        }

        private void copySeedButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(seedBox.Text);
        }

        private void createSeedButton_Click(object sender, EventArgs e)
        {
            Board? board = ParseBoard();
            if (board == null)
            {
                return;
            } 
            int seed = board.GetSeed();
            seedBox.Value = seed;
        }

        private Board? ParseBoard()
        {
            if (goalButton == null)
            {
                MessageBox.Show("You have not set the goal of the puzzle. Middle Click on a Cell to mark it as a goal.",
                    "Create Seed Failed.");
                return null;
            }
            else if (playerButton == null)
            {
                MessageBox.Show("You have not set the player position. Right Click on a Cell to mark it as the player.",
                    "Create Seed Failed.");
                return null;
            }
            Vector2Int goal = null;
            int[,] boardArray = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button b = buttonBoard[i, j];
                    if (goalButton == b)
                    {
                        goal = new Vector2Int(i, j);
                    }
                    if (playerButton == b)
                    {
                        boardArray[i, j] = 2;
                    }
                    else if (b.BackColor == ColorConstants.CoalBG)
                    {
                        boardArray[i, j] = 1;
                    }
                    else
                    {
                        boardArray[i, j] = 0;
                    }
                }
            }
            Board? board = new Board(boardArray, goal);
            return board;
        }

        private void loadSeedButton_Click(object sender, EventArgs e)
        {
            int seed = (int)seedBox.Value;
            Board board = new Board(seed);
            LoadBoard(board);
            solutionGrid.DataSource = null;
        }

        private void LoadBoard(Board board)
        {
            Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int b = board.BoardArray[i, j];
                    if (b == 1)
                    {
                        ToggleCoal(buttonBoard[i, j]);
                    }
                    else if (b == 2)
                    {
                        TogglePlayer(buttonBoard[i, j]);
                    }
                }
            }
            ToggleGoal(buttonBoard[board.Goal.X, board.Goal.Y]);
            //Is Solved?
            if (goalButton == playerButton)
            {
                isSolvedLabel.Text = "Solved!";
                isSolvedLabel.ForeColor = ColorConstants.SuccessColor;
            }
            else
            {
                isSolvedLabel.Text = "Not Solved";
                isSolvedLabel.ForeColor = ColorConstants.FailedColor;
            }
        }
        private void buttonDownA_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveDown(0);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonDownB_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveDown(1);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonDownC_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveDown(2);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonDownD_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveDown(3);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonUpA_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveUp(0);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonUpB_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveUp(1);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonUpC_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveUp(2);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonUpD_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveUp(3);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonRight4_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveRight(0);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonRight3_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveRight(1);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonRight2_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveRight(2);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonRight1_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveRight(3);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonLeft4_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveLeft(0);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonLeft3_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveLeft(1);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonLeft2_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveLeft(2);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void buttonLeft1_Click(object sender, EventArgs e)
        {
            Board board = ParseBoard();
            if (board == null) return;
            Board newBoard = board.MoveLeft(3);
            if (newBoard == null) return;
            LoadBoard(newBoard);
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            Board? board = ParseBoard();
            if (board == null)
            {
                return;
            }
            SolutionTree tree = new SolutionTree(new BoardNode(board));
            BoardNode? node = tree.SolveBreadthFirst((int)maxDepthBox.Value, (int)maxSearchBox.Value, ignoreBadMovesBox.Checked);
            if (node == null)
            {
                MessageBox.Show("No Solutions :(");
            }
            else
            {
                solutionGrid.DataSource = node.GetSolutions();
            }
        }

        private void unlockCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ignoreBadMovesBox.Enabled = checkBox.Checked;
            maxDepthBox.Enabled = checkBox.Checked;
            maxSearchBox.Enabled = checkBox.Checked;
        }

        private void getSeedButton_Click(object sender, EventArgs e)
        {
            try
            {
                int minMoves = (int)minMovesBox.Value;
                int maxMoves = (int)maxMovesBox.Value;
                bool allowObstructed = obstructedCheckBox.Checked;
                SeedDAO dao = new SeedDAO();
                Seed? randomSeed = dao.GetRandomSeed(minMoves, maxMoves, allowObstructed);
                if (randomSeed == null)
                {
                    MessageBox.Show("No Seeds Found D:", "Error");
                }
                else
                {
                    LoadBoard(new Board(randomSeed.SeedValue));

                    seedBox.Value = randomSeed.SeedValue;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured.", "Error");
                solutionGrid.DataSource = null;
            }
        }
    }
}