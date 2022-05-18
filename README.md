# minesweeper

questions to consider:
1. is there a bomb here? - boolean (Y/N?)
2. has the cell been uncovered? - boolean (Y/N?)
3. has the cell had a flag planted in it? - boolean (Y/N?)
4. how many neighbours with bombs does it have? (int)
5. where is it located on the screen? 

creating an array of cells that are 10 x 10 to create a grid:
- leaving one box border around the cell?
- so board size will be  + 2? (one extra cell on each side x and y axis)
<img width="423" alt="grid" src="https://user-images.githubusercontent.com/102941968/169069452-d5e2b76a-041e-4ede-b67d-54bd1f333a5f.png">

creating an array of 100 booleans to get an asortment of random number generated to place the. bomb somewhere ont the grid.
note that they will be randomly generated to ensure everytime it is a different assortment.

use loops of true and false to create the random assortment
