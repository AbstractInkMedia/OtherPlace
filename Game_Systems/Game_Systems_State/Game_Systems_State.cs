/// <summary>
///
/// Takes in requests to change Game State, and is ordered Game Systems Manager to
/// update accordingly. State is then taken in by Game Systems Manager.
/// 
/// </summary>

public static class Game_Systems_State {

    // Game States //

    public enum GameState {
        GameState_Start,
        GameState_Menu_Main,
        GameState_Menu_NewGame,
        GameState_Play,
        GameState_Pause,
        GameState_Quit
    }

    private static GameState currentGameState = GameState.GameState_Start;


    //----------------------------------------------------------------------------------------------------//
    // Flags //

    private static bool flag_requestMade = false;   // A system has made a request, or the Game_Systems_Manager is locking the game state

    private static bool flag_pauseRequested = false; // A system has requested that the Game State switch to GameState_Pause

    private static bool flag_playRequested = false; // A system has requested that the Game State switch:
                                                    //  * From GameState_Pause to GameState_Play
                                                    //  * From GameState_Menu_Main to GameState_Menu_NewGame
                                                    //  * From GameState_Menu_NewGame to GameState_Play

    //----------------------------------------------------------------------------------------------------//
    // Private Methods //

    // The Game_Systems_Manager wants the Game State to remain as is this frame
    private static void Lock ( ) {
        flag_requestMade = true;
    }

    private static void HandlePauseRequest ( ) {
        // If a request has already been made i.e. to play or pause, no additional flags should be raised
        if( flag_requestMade ) { return; }

        flag_requestMade = true;
        flag_pauseRequested = true;
    }

    private static void HandlePlayRequest ( ) {
        // If a request has already been made i.e. to play or pause, no additional flags should be raised
        if( flag_requestMade ) { return; }

        flag_requestMade = true;
        flag_playRequested = true;
    }

    private static void HandleUpdate ( ) {

        if( flag_requestMade ) {

            if( flag_pauseRequested ) {
                if( currentGameState == GameState.GameState_Play ) {
                    currentGameState = GameState.GameState_Pause;
                }
            } else if( flag_playRequested ) {
                if( currentGameState == GameState.GameState_Menu_Main ) {
                    currentGameState = GameState.GameState_Play;

                } else if( currentGameState == GameState.GameState_Pause ) {
                    currentGameState = GameState.GameState_Play;
                }
            }


            // Reset all flags
            flag_requestMade = false;
            flag_pauseRequested = false;
            flag_playRequested = false;
        }
    }

    //----------------------------------------------------------------------------------------------------//
    // Methods called by any Game System //

    public static void RequestPause ( ) {
        HandlePauseRequest( );
    }

    public static void RequestPlay ( ) {
        HandlePlayRequest( );
    }

    //----------------------------------------------------------------------------------------------------//
    // Methods called by Game_System_Manager //

    // The Game_Systems_Manager wants the Game State to remain as is this frame
    public static void LockGameState ( ) {
        Lock( );
    }


    public static void UpdateGameState ( ) {
        HandleUpdate( );
    }

    public static int GetGameState ( ) {
        return (int)currentGameState;
    }
}
