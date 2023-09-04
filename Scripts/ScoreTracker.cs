using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTracker : MonoBehaviour
{
    public static int Score = 0;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GUIStyle style = new GUIStyle();

    void OnGUI()
    {
       
        style.fontSize = 50;
       GUI.Box(new Rect(100, 100, 500, 500),"Score: " + Score.ToString(),style);
        
    }

}
