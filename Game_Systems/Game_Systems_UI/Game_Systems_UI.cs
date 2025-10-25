/// <summary>
///
/// Used to handle the User Interface
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


    //----------------------------------------------------------------------------------------------------//
    // UI Methods //

    public void CreateLabel (   string text = "" ,
                                bool isRelative = true, // if false, the position is Absolute
                                float left = 0f,
                                float top = 0f,
                                float width = 10.0f,
                                float height = 10.0f,
                                Color ? color_background = null,
                                Color ? color_text = null ) {

        Label label = new Label();
        label.text = text;

        label.style.position = ( isRelative ) ? Position.Relative : Position.Absolute;

        label.style.left = new Length( left , LengthUnit.Percent );
        label.style.top = new Length( top , LengthUnit.Percent );
        label.style.translate = new Translate(  new Length( -50, LengthUnit.Percent ) ,
                                                new Length( -50, LengthUnit.Percent ) );

        label.style.width = width;
        label.style.height = height;

        label.style.justifyContent = Justify.Center;
        label.style.alignItems = Align.Center;
        label.style.unityTextAlign = TextAnchor.MiddleCenter;

        label.style.backgroundColor = color_background ?? Color.gray; // If color isn't null, use it; otherwise default to gray
        label.style.color = color_text ?? Color.black; // If color isn't null, use it; otherwise, use black

        rootVisualElement.Add( label );
    }

    public void CreateButton (  Action MethodTriggeredOnClick,
                                string text = "" ,
                                bool isRelative = true, // if false, the position is Absolute
                                float left = 0f,
                                float top = 0f,
                                float width = 10.0f,
                                float height = 10.0f,
                                Color ? color_background = null,
                                Color ? color_text = null ) {

        Button button = new Button();

        button.clicked += MethodTriggeredOnClick;
        button.text = text;

        button.style.position = ( isRelative ) ? Position.Relative : Position.Absolute;

        button.style.left = new Length( left , LengthUnit.Percent );
        button.style.top = new Length( top , LengthUnit.Percent );
        button.style.translate = new Translate( new Length( -50 , LengthUnit.Percent ) ,
                                                new Length( -50 , LengthUnit.Percent ) );

        button.style.width = width;
        button.style.height = height;

        button.style.justifyContent = Justify.Center;
        button.style.alignItems = Align.Center;
        button.style.unityTextAlign = TextAnchor.MiddleCenter;

        button.style.backgroundColor = color_background ?? Color.gray; // If color isn't null, use it; otherwise default to gray
        button.style.color = color_text ?? Color.black; // If color isn't null, use it; otherwise default to black


        button.text = text;
        button.clicked += MethodTriggeredOnClick;
        rootVisualElement.Add( button );
    }


    public void ClearUI ( ) {
        rootVisualElement.Clear( );
    }

    //----------------------------------------------------------------------------------------------------//
    // Prep //

    private void Awake ( ) {
        uiDocument = this.GetComponent<UIDocument>( );
        rootVisualElement = uiDocument.rootVisualElement;
    }
}
