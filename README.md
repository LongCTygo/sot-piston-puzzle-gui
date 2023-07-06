# Sands of Times Piston Puzzle Solver GUI
A C# program that can solve MCC's Sands Of Time's Piston Puzzle.
What is the puzzle? Check out this [detailed document](https://docs.google.com/document/d/1ZbfKo57hn-H5eb_VkiYvJ5Ib-VdNfRtCjPyNy1HkyK8) made by edihau.

Old java project can be found [here.](https://github.com/LongCTygo/sot-piston-puzzle)

## Documentation
**1. The Board**

Left Click to toggle cells between empty or occupied. Right Click to mark cell as the player's position. Middle Click to mark cell as the goal's position. Directional Buttons to push blocks.

**2. Seed**

**Create Seed**: Generate the seed of the current Board state.

**Load Seed**: Generate the board from the inputted seed. The seed value must be between 0 and 8388607

**Copy Seed**: Copy the seed to your clipboard

**Clear**: Clear the board.

**Solve**: Solve the current board state. If there are any solutions, the grid below will display a step-by-step solution to solve the board state, top-down.

**3. Debug**

Don't touch this. But if you can't help yourself:

**Max Depth**: How far will the solver go until it stops. i.e. if it's 15 then if the solution is not within 15 moves then it will stop. Default 20.

**Max Search**: How many board state it will check until it stops. At every board state it attempts every single 'useful' moves and then add them to the queue. If after that many board states it still couldn't find a solution then it will stop. Default 10,000,000.

**Ignore Potential 'Bad' Moves**: The solver will ignore any moves that it deems to be 'stupid'. TBH I don't know if ticking this on or off makes any differences. Default True.

**4. Practice**

**Minimum Moves**: The minimum amount of moves required to solve the generated puzzles.

**Maximum Moves**: The maximum amount of moves required to solve the generated puzzles.

If you want to generate a puzzle with a set number of moves required, input the same number for each. Recommendation: Min = 5 and Max = 7-9, that's the range of the usual SOT Puzzles.

**Allow Obstructed Puzzles**: Some puzzle layouts can have the goal occupied by a coal block. Most of them are still solvable, but it's unlikely that a puzzle like this will appear in a SoT, so I recommend turning it off.

## Authors

- LongCT_ (me)
- edihau (for the researches made to help developing the program)

## License
[LICENSE.txt](https://github.com/LongCTygo/sot-piston-puzzle-gui/blob/master/LICENSE.txt)
## TODO List

- Undo Button
- Time Attack Mode
- Actually have time to update this
