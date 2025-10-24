/// <summary>
///
/// Display the Main Menu, with any logic particular to the Main Menu handled by this state.
/// 
/// </summary>

// Next states:
//   * Game_State_MapGeneration (If the New Game button is pressed)

using UnityEngine;

public class Game_State_MainMenu : Game_State_Abstract {

    protected override void PrepareTransitionSet () {
        transitionSet.Add( this.GetComponent<Game_State_MapGeneration>( ) );
    }

    // Display the Main Menu UI, and setup button for transition to New Game
    protected  override void PrepareState ( ) {

    }

    protected override void UpdateState_Private() {

    }

    // Get rid of any Main Menu UI elements
    protected override void EndState ( ) {

    }

}
