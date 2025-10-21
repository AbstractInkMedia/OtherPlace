/// <summary>
///
/// Takes in requests to change Game State, and is handled by Game Systems Manager to
/// update Game State accordingly
/// 
/// </summary>

public static class Game_Systems_Flags {

    // Flags //

    private static bool flag_requestMade = false;   // A system has made a request

    private static bool flag_pauseRequested = false; // A system has requested that the Game State switch to GameState_Pause

    private static bool flag_playRequested = false; // A system has requested that the Game State switch to playing

    private static bool flag_waitRequested = false; // A system needs Game_Systems_Manager to wait until it is
                                                    // finished with its task.
                                                    // This has to be renewed every frame, or the
                                                    // Game_Systems_Manager will continue to the next state

    //----------------------------------------------------------------------------------------------------//
    // Private Methods //

    private static void HandleClearFlags ( ) {
        flag_requestMade = false;
        flag_pauseRequested = false;
        flag_playRequested = false;
        flag_waitRequested = false;
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

    // A system is occupied and needs the Game_Systems_Manager to remain in its current state
    private static void HandleWaitRequest ( ) {
        if( flag_requestMade ) { return; }

        flag_requestMade = true;
        flag_waitRequested = true;
    }

    //----------------------------------------------------------------------------------------------------//
    // Methods called by any Game System //

    public static void RequestPause ( ) {
        HandlePauseRequest( );
    }

    public static void RequestPlay ( ) {
        HandlePlayRequest( );
    }

    // A system is occupied and needs the Game_Systems_Manager to remain in its current state
    public static void RequestWait ( ) {
        HandleWaitRequest( );
    }

    //----------------------------------------------------------------------------------------------------//
    // Methods called by Game_System_Manager //

    public static void ClearFlags ( ) {
        HandleClearFlags( );
    }

    public static bool GetFlag_pauseRequest ( ) {
        return flag_pauseRequested;
    }

    public static bool GetFlag_playRequest ( ) {
        return flag_playRequested;
    }

    public static bool GetFlag_waitRequest ( ) {
        return flag_waitRequested;
    }
}
