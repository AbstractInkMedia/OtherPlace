/// <summary>
///
/// Used to handle the User Interface and communicate with the Game_Systems_Manager when the user
/// interacts with UI elements
/// 
/// </summary>

using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Game_Systems_UI : MonoBehaviour {

    // UI Document attached to this Object
    private UIDocument uiDocument = null;

    public event Action action_buttonTest;

    void ButtonTest ( ) {
        action_buttonTest?.Invoke( );
    }

    private void Awake ( ) {
        uiDocument = this.GetComponent<UIDocument>( );
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( ) {

    }

    // Update is called once per frame
    void Update ( ) {

    }
}
