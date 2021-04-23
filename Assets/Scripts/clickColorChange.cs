using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickColorChange : MonoBehaviour
{
    public Material m;
    private void OnMouseDown() {
        if (m.color == Color.red){
            m.color = Color.white;
        } else {
            m.color = Color.red;
        }
        print(m.color);
    }
}
