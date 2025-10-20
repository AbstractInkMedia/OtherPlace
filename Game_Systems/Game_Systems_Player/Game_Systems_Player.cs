/// <summary>
/// 
/// Used for handling events related to player input i.e. pausing the game or attempting to move,
/// with the Player Character being a separate entity influenced by commands from this System.
/// 
/// </summary>


using UnityEngine;

public class Game_Systems_Player : MonoBehaviour {

    private Game_Systems_Manager systems_manager = null;

    void SetSystemManager ( ref Game_Systems_Manager ref_systems_manager ) {
        systems_manager = ref_systems_manager;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( ) {

    }

    // Update is called once per frame
    void Update ( ) {

    }
}
