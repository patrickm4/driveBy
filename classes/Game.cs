namespace Classes;
// using System.Windows.Forms;

public class Game {
  public void main() {
    // while (key == null); //wait for first key press
    //'█'
    char[] row = {' ',' ',' ',' ',' ','^',' ',' ',' ',' ',' '};

    bool gameRunning = true;

    while(gameRunning) {
      while (Console.KeyAvailable) {
        ConsoleKey key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.LeftArrow) {
          if (row[0] != '^') {
            for (var i = 0; i < row.Length; i++) {
                if (row[i] == '^') {
                    row[i - 1] = '^';
                    row[i] = ' ';
                    break;
                }
            }
          }
        }

        if (key == ConsoleKey.RightArrow) {
          if (row[row.Length - 1] != '^') {
            for (var i = 0; i < row.Length; i++) {
                if (row[i] == '^') {
                    row[i + 1] = '^';
                    row[i] = ' ';
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

      Console.WriteLine(row);
      Thread.Sleep(500);
      // Redraw the game with the updates
    }

  }
}