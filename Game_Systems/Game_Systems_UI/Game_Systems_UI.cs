/// <summary>
///
/// Used to handle the User Interface and communicate with the Game_Systems_Manager when the user
/// interacts with UI elements
/// 
/// </summary>

using UnityEngine;

public class Game_Systems_UI : MonoBehaviour {

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
