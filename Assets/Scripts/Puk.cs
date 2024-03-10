using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puk : MonoBehaviour
{
    void Update()
    {
        var viewportPos = Camera.main.WorldToViewportPoint(transform.position);
    }
}
