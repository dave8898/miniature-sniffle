using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{

    [SerializeField] private string gemColor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (gemColor == "Blue")
            {
                GameObject.Find("Blue").GetComponent<GemDisplay>().Found();
            }
            if (gemColor == "Red")
            {
                GameObject.Find("Red").GetComponent<GemDisplay>().Found();
            }
            if (gemColor == "Green")
            {
                GameObject.Find("Green").GetComponent<GemDisplay>().Found();
            }
            if (gemColor == "Yellow")
            {
                GameObject.Find("Yellow").GetComponent<GemDisplay>().Found();
            }
            Destroy(gameObject);
        }
        FindObjectOfType<GameSession>().AddGem();
    }
}
