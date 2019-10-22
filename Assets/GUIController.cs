using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public string Str { get; set; } = "";
    public GUIStyle style;
    private void OnGUI() {
        GUI.Label(new Rect(Screen.width/2-100, Screen.height/2-30, 200, 60), Str,style);
    }
}
