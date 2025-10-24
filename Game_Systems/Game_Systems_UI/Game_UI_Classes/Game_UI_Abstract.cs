using UnityEngine.UIElements;

public abstract class Game_UI_Abstract {

    protected VisualElement rootVisualElement;

    protected Game_UI_Abstract( VisualElement rootVisEl ) {
        rootVisualElement = rootVisEl;
    }

    public abstract void BuildUI ( );

    public abstract void DeconstructUI ( );
}
