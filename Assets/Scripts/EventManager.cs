using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    public delegate void PressAction();
    public static event PressAction OnPressed;


    //private void OnGUI()
    //{
    //    if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
    //    {
    //        if (OnClicked != null)
    //        {
    //            OnClicked();
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);

        if(other.tag == "Player" && this.tag == "Respawn")
        {
            if (OnClicked != null)
            {
                OnClicked();
            }
        }
        else if(other.tag == "Player" && this.tag == "Finish")
        {
            if (OnPressed != null)
            {
                OnPressed();
            }
        }
    }
}
