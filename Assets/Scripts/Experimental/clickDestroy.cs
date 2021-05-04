using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDestroy : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
