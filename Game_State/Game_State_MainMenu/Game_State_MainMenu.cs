/// <summary>
///
/// Display the Main Menu, with any logic particular to the Main Menu handled by this state.
/// 
/// </summary>

// Next states:
//   * Game_State_MapGeneration (If the New Game button is pressed)

using UnityEngine;

public class Game_State_MainMenu : Game_State_Abstract {

    // Triggered by UI Button for starting a New Game
    private void StartNewGame ( ) {
        system_UI.ClearUI( );
        this.SetNextState( transitionStates [ "MapGen" ] );
    }


    protected override void PrepareTransitionStates () {
        transitionStates.Add( "MapGen", this.GetComponent<Game_State_MapGeneration>( ) );
    }

    // Display the Main Menu UI, and setup button for transition to New Game
    protected override void PrepareState ( ) {

#if UNITY_EDITOR

        Debug.Log( "Entering Main Menu State" );

#endif

        // Create title
        system_UI.CreateLabel( "The Other Place" , isRelative: false, left: 50f , top: 20f , width: 200f , height: 50f );
        system_UI.CreateButton( StartNewGame , "New Game" , isRelative: false, left: 50f , top: 60f , width: 100f , height: 20f );
    }

    protected override void UpdateState_Private() {

    }

    // Get rid of any Main Menu UI elements
    protected override void EndState ( ) {

#if UNITY_EDITOR

        Debug.Log( "Exiting Main Menu State" );

#endif

    }

}
