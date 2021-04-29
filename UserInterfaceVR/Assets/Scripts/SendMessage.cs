using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessage : MonoBehaviour
{
    public void Pointer_Enter()
    {
        Debug.Log("<color=green><b> " + "ENTER" + "</b></color>");
    }

    public void Pointer_Exit()
    {
        Debug.Log("<color=red><b> " + "EXIT" + "</b></color>");
    }

    public void Pointer_Click()
    {
        Debug.Log("CLICK");
    }
}
