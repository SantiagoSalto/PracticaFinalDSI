using UnityEngine;
using UnityEngine.UIElements;

public class FullGame : MonoBehaviour
{
    VisualElement _root;
    VisualElement _mainScreen;
    VisualElement _setupScreen;
    VisualElement _playScreen;

    Button _playButton;
    Button _setupButton;
    Button _backPlayButton;
    Button _backSetupButton;
    void Start()
    {
        _root = GetComponent<UIDocument>().rootVisualElement;

        _playButton = _root.Q<Button>("PlayButton"); // boton de play
        _setupButton = _root.Q<Button>("SetupButton"); // boton de opciones 
        _backPlayButton = _root.Q<Button>("ReturnPlay"); // return de menu de play
        _backSetupButton = _root.Q<Button>("ReturnSetup"); // return de menu de setup

        _mainScreen = _root.Q("MainMenu_UXML");
        _setupScreen = _root.Q("OptionsMenu_UXML");
        _playScreen = _root.Q("PlayMenu_UXML");


        _playButton.RegisterCallback<ClickEvent>(OnPlay);
        _setupButton.RegisterCallback<ClickEvent>(OnSetup);
        _backPlayButton.RegisterCallback<ClickEvent>(OnBackPlay);
        _backSetupButton.RegisterCallback<ClickEvent>(OnBackSetup);
    }

    // click a play
    void OnPlay(ClickEvent ev)
    {
        _playScreen.style.opacity = 100;
        _playScreen.style.display = DisplayStyle.Flex;
        print("Holi");
    }

    void OnSetup(ClickEvent ev)
    {
        _setupScreen.style.opacity = 100;
        _setupScreen.style.display = DisplayStyle.Flex;
        print("Holi");
    }

    void OnBackPlay(ClickEvent ev)
    {
        _playScreen.style.opacity = 0;
        _playScreen.style.display = DisplayStyle.None;
        print("Holi");
    }

    void OnBackSetup(ClickEvent ev)
    {
        _setupScreen.style.opacity = 0;
        _setupScreen.style.display = DisplayStyle.None;
        print("Holi");
    }
}
