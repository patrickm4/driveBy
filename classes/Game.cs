namespace Classes;
// using System.Windows.Forms;

public class Game {
  // static ConsoleKeyInfo Pressed_Key;
  // ConsoleKey key = Console.ReadKey(true).Key;
  // static ConsoleKey Pressed_Key;
  // public void main() {

  //   Console.WriteLine("Welcome to DriveBy!");
  //   Console.WriteLine("Press Y to Start Playing.");

  //   if (Console.ReadKey().Key == ConsoleKey.Y){
  //     Console.CursorVisible = false;
  //     Console.Clear();
  //     Task.Run( () => updateAndDrawTheGame() );

  //     do {
  //       Pressed_Key = Console.ReadKey();
  //     } while (Pressed_Key.Key != ConsoleKey.Escape);
  //   }

  // }
  // public void main() {
  //   Console.WriteLine("Welcome to DriveBy!");
  //   Console.WriteLine("Press Y to Start Playing.");

  //   ConsoleKey key = Console.ReadKey().Key;

  //   if (key == ConsoleKey.Y){
  //     Console.CursorVisible = false;
  //     Console.Clear();
  //     Task.Run( () => updateAndDrawTheGame() );

  //     do {
  //       // Pressed_Key = Console.ReadKey();
  //       // key = Console.ReadKey();
  //     } while (key != ConsoleKey.Escape);
  //   }

  // }

  // public static void updateAndDrawTheGame() {
  public void main() {
    // while (key == null); //wait for first key press

      ConsoleKey key = Console.ReadKey(true).Key;
    // char[] row = {'-','-','-','-','-','^','-','-','-','-','-'};
    char[] row = {'-','-','^','-','-'};
    bool gameRunning = true;

    // while (key != ConsoleKey.Escape) {
    while (gameRunning) {
    // while (Console.KeyAvailable) {
      // Update the enemies, scenery, HUD etc.
      // Move the character if THE_is 'A'
      // Move the character differently if THE_is 'S'
      // etc.

      // while(Console.KeyAvailable) Console.ReadKey(false);

      if (key == ConsoleKey.LeftArrow) {
        // Console.WriteLine("LEFT ARROW");
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

      if (key == ConsoleKey.RightArrow) {
        // Console.WriteLine("RIGHT ARROW");
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
      if (key == ConsoleKey.W) {
        //move forward
      }
      if (key == ConsoleKey.S) {
        // move back
      }

      // = default(ConsoleKeyInfo);
      Console.WriteLine(row);
      Thread.Sleep(500);
      // Redraw the game with the updates
    }
  }
}

//   public static void updateAndDrawTheGame() {
//     while (Pressed_Key == null); //wait for first key press

//     // char[] row = {'-','-','-','-','-','^','-','-','-','-','-'};
//     char[] row = {'-','-','^','-','-'};

//     while (Pressed_Key.Key != ConsoleKey.Escape) {
//       // Update the enemies, scenery, HUD etc.
//       // Move the character if THE_PRESSED_KEY is 'A'
//       // Move the character differently if THE_PRESSED_KEY is 'S'
//       // etc.

//       // while(Console.KeyAvailable) Console.ReadKey(false);

//       if (Pressed_Key.Key == ConsoleKey.ReadKey(true).LeftArrow) {
//         // move left
//         if (row[0] != '^') {
//           for (var i = 0; i < row.Length; i++) {
//               if (row[i] == '^') {
//                   row[i - 1] = '^';
//                   row[i] = '-';
//                   break;
//               }
//           }
//         }
//       }

//       if (Pressed_Key.Key == ConsoleKey.ReadKey(true).RightArrow) {
//         if (row[row.Length - 1] != '^') {
//           for (var i = 0; i < row.Length; i++) {
//               if (row[i] == '^') {
//                   row[i + 1] = '^';
//                   row[i] = '-';
//                   break;
//               }
//           }
//         } 
//         // move right
//       }
//       if (Pressed_Key.Key == ConsoleKey.W) {
//         //move forward
//       }
//       if (Pressed_Key.Key == ConsoleKey.S) {
//         // move back
//       }

//       // Pressed_Key = default(ConsoleKeyInfo);
//       Console.WriteLine(row);
//       Thread.Sleep(500);
//       // Redraw the game with the updates
//     }
//   }
// }