/// <summary>
///
/// Used to handle Game State, and call each of the other systems used in the game in the proper order
/// 
/// </summary>

using UnityEngine;

[DefaultExecutionOrder(-500)] // Game_Systems_Manager should run before all other scripts
public class Game_Systems_Manager : MonoBehaviour {

    // Each of the Systems called by Game_Systems_Manager //

    // Used to take in requests from other systems to change Game State
    // Game_Systems_Flags

    // Used to generate and destroy the map
    private Game_Systems_MapGenerator system_mapGenerator;

    // Used to handle the User Interface and interaction with it
    private Game_Systems_UI system_UI;

    // Used to handle agents ( Non-player agents, smart objects, etc. ), which influence associated Agent Characters
    private Game_Systems_AgentHandler system_agentHandler;

    // Used to handle player input and influence associated Player Character
    private Game_Systems_Player system_player;


    //----------------------------------------------------------------------------------------------------//
    // State Related //

    public enum GameState {
        GameState_Start, // When the game launches, prior to displaying the Main Menu
        GameState_Menu_Main, // When the Main Menu is displayed
        GameState_Menu_NewGame, // When the player has transitioned to starting a new game
        GameState_GeneratingMap, // When the Game_Systems_MapGenerator is generating the game map
        GameState_Play, // When the game is being played and is influenced by the Player
        GameState_Pause, // When the game is paused
        GameState_Quit, // When the game is quit and is returned to the Main Menu
        GameState_Win, // When the player has won the game
        GameState_Lose // When the player has lost the game
    }

    private GameState currentGameState = GameState.GameState_Start;

    //----------------------------------------------------------------------------------------------------//
    // System Prep //

    // Get Systems attached to this object
    void GetSystems ( ) {
        system_mapGenerator = this.GetComponent<Game_Systems_MapGenerator>( );
        system_UI = this.GetComponent<Game_Systems_UI>( );
        system_agentHandler = this.GetComponent<Game_Systems_AgentHandler>( );
        system_player = this.GetComponent<Game_Systems_Player>( );
    }

    //----------------------------------------------------------------------------------------------------//
    // Handle systems based on Game State //

    // At the beginning before the Main Menu is displayed
    private void Loop_Start ( ) {

    }

    // The Main Menu
    private void Loop_MainMenu ( ) {

    }

    // The New Game Menu
    private void Loop_NewGame ( ) {

    }

    // The Map is being generated
    private void Loop_GeneratingMap ( ) {

    }

    // The game is being played (unpaused)
    private void Loop_Play ( ) {

    }

    // The game is paused
    private void Loop_Pause ( ) {

    }

    // The game is quit
    private void Loop_Quit ( ) {

    }


    //----------------------------------------------------------------------------------------------------//
    // Switch Game State //

    private void SwitchState_Start ( ) { }

    private void SwitchState_Menu_Main ( ) {

    }

    private void SwitchState_Menu_NewGame ( ) {

    }


    private void SwitchState_GeneratingMap ( ) {

    }

    private void SwitchState_Play ( ) {

    }

    private void SwitchState_Pause ( ) {

    }

    private void SwitchState_Quit ( ) {

    }

    private void Awake ( ) {
        GetSystems( );
    }

    // Update is called once per frame
    void Update ( ) {

        // Handle systems based on current Game State

        switch( currentGameState ) {
            case GameState.GameState_Start:
                Loop_Start( );
                break;
            case GameState.GameState_Menu_Main:
                Loop_MainMenu( );
                break;
            case GameState.GameState_Menu_NewGame:
                Loop_NewGame( );
                break;
            case GameState.GameState_GeneratingMap:
                Loop_GeneratingMap( );
                break;
            case GameState.GameState_Play:
                Loop_Play( );
                break;
            case GameState.GameState_Pause:
                Loop_Pause( );
                break;
            case GameState.GameState_Quit:
                Loop_Quit( );
                break;
        }

        // A system needs the state to remain as is this frame
        if( Game_Systems_Flags.GetFlag_waitRequest( ) ) {
            return;
        }

        // Update Game State, switching state only if necessary

        switch( currentGameState ) {
            case GameState.GameState_Start:
                break;
            case GameState.GameState_Menu_Main:
                break;
            case GameState.GameState_Menu_NewGame:
                break;
            case GameState.GameState_GeneratingMap:
                break;
            case GameState.GameState_Play:
                break;
            case GameState.GameState_Pause:
                break;
            case GameState.GameState_Quit:
                break;
        }
    }
}
