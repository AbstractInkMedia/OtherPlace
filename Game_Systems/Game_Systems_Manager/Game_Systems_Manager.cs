/// <summary>
///
/// Used to handle each of the other systems used in the game in the proper order,
/// both for initial setup, play, and shut down
/// 
/// </summary>

using UnityEngine;

[DefaultExecutionOrder(-500)] // Game_Systems_Manager should run before all other scripts
public class Game_Systems_Manager : MonoBehaviour {

    // Each of the Systems called by Game_Systems_Manager //

    // Used to generate and destroy the map
    private Game_Systems_MapGenerator system_mapGenerator;

    // Used to handle the User Interface and interaction with it
    private Game_Systems_UI system_UI;

    // Used to handle player input and influence associated Player Character
    private Game_Systems_Player system_player;

    // Used to handle agents ( Non-player agents, smart objects, etc. ), which influence associated Agent Characters
    private Game_Systems_AgentHandler system_agentHandler;

    //----------------------------------------------------------------------------------------------------//
    // Delegates: UI //

 

    //----------------------------------------------------------------------------------------------------//
    // Delegates: Player //

    //----------------------------------------------------------------------------------------------------//
    // Delegates: Agent Handler //

    //----------------------------------------------------------------------------------------------------//
    // System Prep //

    // Get Systems attached to this object
    void GetSystems ( ) {
        system_mapGenerator = this.GetComponent<Game_Systems_MapGenerator>( );
        system_UI = this.GetComponent<Game_Systems_UI>( );
        system_player = this.GetComponent<Game_Systems_Player>( );
        system_agentHandler = this.GetComponent<Game_Systems_AgentHandler>( );
    }

    private void Awake ( ) {
        GetSystems( );
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( ) {
        // 
    }

    // Update is called once per frame
    void Update ( ) {

    }


    private void OnApplicationQuit ( ) {
        
    }
}
