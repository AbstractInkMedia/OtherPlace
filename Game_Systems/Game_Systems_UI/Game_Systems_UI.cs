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


    //----------------------------------------------------------------------------------------------------//
    // UI Methods //

    public void UI_DisplayMainMenu ( ) {
        // Tell current UI (doesn't matter which) to switch off
        if( ui_current != null ) {
            ui_current.DeconstructUI( );
        }

        ui_current = ui_mainMenu;
        ui_current.BuildUI( );
    }

    //----------------------------------------------------------------------------------------------------//
    // Methods called by Game_Systems_Manager //

    public void DisplayMainMenu ( ) {
        UI_DisplayMainMenu( );
    }
 

    private void Awake ( ) {
        uiDocument = this.GetComponent<UIDocument>( );
        rootVisualElement = uiDocument.rootVisualElement;
        ui_mainMenu = new Game_UI_MainMenu( rootVisualElement );
    }
}
