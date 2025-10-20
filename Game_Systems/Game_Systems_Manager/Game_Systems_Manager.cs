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

    // Get Systems attached to this object
    void GetSystems ( ) {
        system_mapGenerator = this.GetComponent<Game_Systems_MapGenerator>( );
    }

    private void Awake ( ) {
        GetSystems( );
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( ) {

    }

    // Update is called once per frame
    void Update ( ) {

    }


   // private void OnApplicationQuit ( ) {
        
  //  }
}
