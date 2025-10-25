/// <summary>
///
/// Present on-screen loading screen while generating the map
/// 
/// </summary>

// Next state:
//   * Game_State_Play (After the Map Generation is finished)

using UnityEngine;

public class Game_State_MapGeneration : Game_State_Abstract {

    // Map Generation calls //

    // Note:    The Game_Systems_MapGenerator is responsible for the actual Map Generation
    //          Game_State_MapGeneration is responsible for influencing MapGenerator
    //          and otherwise influencing Game_Systems_UI to 


    //----------------------------------------------------------------------------------------------------//
    // Game State Methods //

    protected override void PrepareTransitionStates ( ) {
        transitionStates.Add( "Play" , this.GetComponent<Game_State_Play>( ) );
    }

    protected override void PrepareState ( ) {

#if UNITY_EDITOR

        Debug.Log( "Entering Map Generation State" );

#endif

    }

    protected override void UpdateState_Private ( ) {

    }

    protected override void EndState ( ) {

#if UNITY_EDITOR

        Debug.Log( "Exiting Map Generation State" );

#endif

    }

}