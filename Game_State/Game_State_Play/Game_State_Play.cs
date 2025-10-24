/// <summary>
///
/// Used for the main Play state
/// 
/// </summary>

// Next states:
//   * Main_Menu (When the player quits the game)

using UnityEngine;

public class Game_State_Play : Game_State_Abstract {

    protected override void PrepareTransitionSet ( ) {
        transitionSet.Add( this.GetComponent<Game_State_MainMenu>( ) );
    }

    protected override void PrepareState ( ) {

    }

    protected override void UpdateState_Private ( ) {

    }

    protected override void EndState ( ) {


    }

}
