namespace Classes;

public class Game {
  static ConsoleKeyInfo Pressed_Key;
  public void main() {

    Console.WriteLine("Welcome to DriveBy!");
    Console.WriteLine("Press Y to Start Playing.");

    if (Console.ReadKey().Key == ConsoleKey.Y){
      Task.Run( () => updateAndDrawTheGame() );

      do {
        Pressed_Key = Console.ReadKey();
      } while (Pressed_Key.Key != ConsoleKey.Escape);
    }

  }

  public static void updateAndDrawTheGame() {
    while (Pressed_Key == null); //wait for first key press

    while (Pressed_Key.Key != ConsoleKey.Escape) {
      // Update the enemies, scenery, HUD etc.
      // Move the character if THE_PRESSED_KEY is 'A'
      // Move the character differently if THE_PRESSED_KEY is 'S'
      // etc.

      char[] row = {'-','-','^','-','-'};

      if (Pressed_Key.Key == ConsoleKey.A) {
        for (var i = 0; i < row.Length; i++) {
            if (row[i] == '^') {
                row[i - 1] = '^';
                row[i] = '-';
                break;
            }
        }
        // Console.WriteLine("-^---")
        // move left
      }

      if (Pressed_Key.Key == ConsoleKey.D) {
        // move right
      }
      if (Pressed_Key.Key == ConsoleKey.W) {
        //move forward
      }
      if (Pressed_Key.Key == ConsoleKey.S) {
        // move back
      }

      Console.WriteLine(row);
      // Redraw the game with the updates
    }
  }
}