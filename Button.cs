using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
 