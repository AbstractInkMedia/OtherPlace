/// <summary>
///
/// Used to handle each of the other systems used in the game in the proper order
/// 
/// </summary>

using UnityEngine;

[DefaultExecutionOrder(-500)] // Game_Systems_Manager should run before all other scripts
public class Game_Systems_Manager : MonoBehaviour {

    // Each of the Systems called by Game_Systems_Manager //

    // Used to handle the Game State, called by all other systems to request changes to state,
    // with only Game Systems Manager telling the Game State to change
    // Game_Systems_State

    // Used to generate and destroy the map
    private Game_Systems_MapGenerator system_mapGenerator;

    // Used to handle the User Interface and interaction with it
    private Game_Systems_UI system_UI;

    // Used to handle agents ( Non-player agents, smart objects, etc. ), which influence associated Agent Characters
    private Game_Systems_AgentHandler system_agentHandler;

    // Used to handle player input and influence associated Player Character
    private Game_Systems_Player system_player;


    //----------------------------------------------------------------------------------------------------//
    // Event Handling: Game_Systems_UI //



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
    // Handle Start and Update based on Game State //

    // At the beginning before the Main Menu is displayed
    private void HandleStart ( ) {

    }

    // The first update after the Start, used to switch to Main Menu
    private void HandleUpdate_Start ( ) {

    }

    private void HandleUpdate_Menu_Main ( ) {

    }

    private void Awake ( ) {
        GetSystems( );
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( ) {
        HandleStart( );
    }

    // Update is called once per frame
    void Update ( ) {

        // Tell Game_Systems_State to update based on current requests
        Game_Systems_State.UpdateGameState( );

        int currentGameState = Game_Systems_State.GetGameState( );

        switch( currentGameState ) {
            case 0: // GameState.GameState_Start:
                break;
            case 1: // GameState.GameState_Menu_Main:
                break;
            case 2: // GameState.GameState_Menu_NewGame:
                break;
            case 3: // GameState.GameState_Play:
                break;
            case 4: // GameState.GameState_Pause:
                break;
            case 5: // GameState.GameState_Quit
                break;
        }
    }


    private void OnApplicationQuit ( ) {
        
    }
}
