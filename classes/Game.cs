namespace Classes;
// using System.Windows.Forms;

public class Game {
  static ConsoleKeyInfo Pressed_Key;
  // ConsoleKey key = Console.ReadKey(true).Key;
  // static ConsoleKey Pressed_Key;
  public void main() {

    Console.WriteLine("Welcome to DriveBy!");
    Console.WriteLine("Press Y to Start Playing.");

    if (Console.ReadKey().Key == ConsoleKey.Y){
      Console.Clear();
      // Task.Run( () => updateAndDrawTheGame() );

      char[] row = {'-','-','-','-','-','^','-','-','-','-','-'};

      do {
        // Pressed_Key = Console.ReadKey();

        if (Console.ReadKey(true).Key == ConsoleKey.A) {
          // move left
          if (row[0] != '^') {
            for (var i = 0; i < row.Length; i++) {
                if (row[i] == '^') {
                    row[i - 1] = '^';
                    row[i] = '-';
                    break;
                }
            }
          }
        }

        // if (Console.ReadKey(true).Key == ConsoleKey.D) {
        //   // move right
        //   if (row[row.Length - 1] != '^') {
        //     for (var i = 0; i < row.Length; i++) {
        //         if (row[i] == '^') {
        //             row[i + 1] = '^';
        //             row[i] = '-';
        //             break;
        //         }
        //     }
        //   } 
        //   continue;
        // }

        Console.WriteLine(row);
        // Thread.Sleep(500);
        // SendKeys.Send("{ENTER}");
      } while (Pressed_Key.Key != ConsoleKey.Escape);
    }

  }

  public static void updateAndDrawTheGame() {
    while (Pressed_Key == null); //wait for first key press

    char[] row = {'-','-','-','-','-','^','-','-','-','-','-'};

    while (Pressed_Key.Key != ConsoleKey.Escape) {
      // Update the enemies, scenery, HUD etc.
      // Move the character if THE_PRESSED_KEY is 'A'
      // Move the character differently if THE_PRESSED_KEY is 'S'
      // etc.

      // while(Console.KeyAvailable) Console.ReadKey(true);      
      if (Pressed_Key.Key == ConsoleKey.A) {
        // move left
        if (row[0] != '^') {
          for (var i = 0; i < row.Length; i++) {
              if (row[i] == '^') {
                  row[i - 1] = '^';
                  row[i] = '-';
                  break;
              }
          }
        }

        // ConsoleKeyInfo key = Console.ReadKey(intercept: true);
        // string newLine = Console.ReadLine();
        // ConsoleKeyInfo key = Console.ReadKey(true);

      }

      if (Pressed_Key.Key == ConsoleKey.D) {
        if (row[row.Length - 1] != '^') {
          for (var i = 0; i < row.Length; i++) {
              if (row[i] == '^') {
                  row[i + 1] = '^';
                  row[i] = '-';
                  break;
              }
          }
        } 
        // move right
      }
      if (Pressed_Key.Key == ConsoleKey.W) {
        //move forward
      }
      if (Pressed_Key.Key == ConsoleKey.S) {
        // move back
      }

      Pressed_Key = default(ConsoleKeyInfo);
      Console.WriteLine(row);
      Thread.Sleep(500);
      // Redraw the game with the updates
    }
  }
}