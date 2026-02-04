using TMPro;
using UnityEngine;

// Require that a TMP_Text component is on the same object as this script
//   Attributes like RequireComponent cause the Unity editor to make changes
//   In this case, the Unity editor will check and see if there is a TMP_Text component on the same game object.
//   If there is no component, it will actually add the component to the game object for us!

[RequireComponent(typeof(TMP_Text))]

public class TimerUIController : MonoBehaviour
{
    [Header("Timer Settings")]
    [Tooltip("1 will increase the timer by 1 every second, .5 is 50% speed, etc.")]
    public float speed = 1;

    [Tooltip("a string of text to show to the right of the number")]
    public string label;


    //private instance fields (variables)
    TMP_Text textUI; //TMP_Text is short for Text Mesh Pro Text Component
    float timeCurrent;
    void Start()
    {
        textUI = GetComponent<TMP_Text>();
        textUI.text = "Starting...";
        timeCurrent = 0;
    }

    // Update is called once per frame (every split second of play)

    void Update()
    {
        timeCurrent = timeCurrent + Time.deltaTime * speed;
        textUI.text = label + " " + timeCurrent.ToString("N0");
    }
}