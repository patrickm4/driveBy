public class game {
  static ConsoleKeyInfo Pressed_Key;
  public static void main() {
    Task.Run( () => updateAndDrawTheGame() );

    do {
      Pressed_Key = Console.ReadKey()
    } while (Pressed_Key.key != ConsoleLey.Escape);
  }

  public static void updateAndDrawTheGame() {
    while (Pressed_Key == null); //wait for first key press

    while (Pressed_Key.key != ConsoleKey.Escape) {
      // Update the enemies, scenery, HUD etc.

      // Move the character if THE_PRESSED_KEY is 'A'
      // Move the character differently if THE_PRESSED_KEY is 'S'
      // etc.
      if (Pressed_Key.key == 'A') {
        // Console.WriteLine("-^---")
        // move left
      }

      if (Pressed_Key.key == 'D') {
        // move right
      }
      if (Pressed_Key.key == 'W') {
        //move forward
      }
      if (Pressed_Key.key == 'S') {
        // move back
      }

      // Redraw the game with the updates
    }
  }
}