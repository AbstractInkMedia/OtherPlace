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

    // Visual Element of the UI Document
    private VisualElement rootVisualElement = null;

    // The current UI in-play
    private Game_UI_Abstract ui_current = null;

    // The UI of the main menu
    private Game_UI_MainMenu ui_mainMenu = null;




    private void Awake ( ) {
        uiDocument = this.GetComponent<UIDocument>( );
        rootVisualElement = uiDocument.rootVisualElement;
        ui_mainMenu = new Game_UI_MainMenu( rootVisualElement );
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ( ) {
        // FOr testing logic, the "current ui" will be set to the "ui main menu",
        // then the call made to current ui to BuildUI
        ui_current = ui_mainMenu;
        ui_current.BuildUI( );
    }

    // Update is called once per frame
    void Update ( ) {

    }
}
