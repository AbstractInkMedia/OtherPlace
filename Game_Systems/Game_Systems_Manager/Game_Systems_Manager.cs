/// <summary>
///
/// Used to influence Game State, with the current Game State influencing available Game Systems
/// 
/// </summary>

using UnityEngine;

[DefaultExecutionOrder(-500)] // Game_Systems_Manager should run before all other scripts
public class Game_Systems_Manager : MonoBehaviour {

    // The current Game State
    private Game_State_Abstract currentGameState;

    private void EnterGameState () {
        currentGameState.Enter( );
    }

    private void ExitGameState ( ) {
        currentGameState.Exit( );
    }




    // Prepare the first Game State, in this case Main Menu
    private void Awake ( ) {
        currentGameState = this.GetComponentInChildren<Game_State_MainMenu>( );
    }

    // Update is called once per frame
    void Update ( ) {

        // Check to see if the game state should transition
        Game_State_Abstract nextState = currentGameState.GetNextState();

        if( nextState != null ) {

            // close out the current game state

            // set up the next game state

        }
    }
}
