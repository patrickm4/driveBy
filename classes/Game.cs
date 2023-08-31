namespace Classes;
// using System.Windows.Forms;

public class Game {
  public void main() {
    // while (key == null); //wait for first key press
    //'█'
    char[] row1 = {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '};
    char[] row2 = {' ',' ',' ',' ',' ','^',' ',' ',' ',' ',' '};
    char[] row3 = {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '};

    bool gameRunning = true;

    while(gameRunning) {
      while (Console.KeyAvailable) {
        ConsoleKey key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.LeftArrow) {
          if (row2[0] != '^') {
            for (var i = 0; i < row2.Length; i++) {
                if (row2[i] == '^') {
                    row2[i - 1] = '^';
                    row2[i] = ' ';
                    break;
                }
            }
          }
        }

        if (key == ConsoleKey.RightArrow) {
          if (row2[row2.Length - 1] != '^') {
            for (var i = 0; i < row2.Length; i++) {
                if (row2[i] == '^') {
                    row2[i + 1] = '^';
                    row2[i] = ' ';
                    break;
                }
            }
          } 
        }
        if (key == ConsoleKey.W) {
          //move forward
        }
        if (key == ConsoleKey.S) {
          // move back
        }
        if (key == ConsoleKey.Escape) {
          // exit
          gameRunning = false;
        }
      }

      Console.WriteLine(row1);
      Console.WriteLine(row2);
      Console.WriteLine(row3);
      // Thread.Sleep(500);
      Thread.Sleep(100);
      // Redraw the game with the updates
    }

  }
}