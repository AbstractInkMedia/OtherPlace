/// <summary>
///
/// Present on-screen loading screen while generating the map
/// 
/// </summary>

// Next states:
//   * Game_State_Play (After the Map Generation is finished)

using UnityEngine;

public class Game_State_MapGeneration : Game_State_Abstract {

    protected override void PrepareTransitionSet ( ) {
        transitionSet.Add( this.GetComponent<Game_State_Play>( ) );
    }

    protected override void PrepareState ( ) {

    }

    protected override void UpdateState_Private ( ) {

    }

    protected override void EndState ( ) {


    }

}