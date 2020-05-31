using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDisplay : MonoBehaviour
{
    public void Found()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
