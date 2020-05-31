using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadMover : MonoBehaviour
{

    [SerializeField] float moveSpeed;

    Material myMaterial;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    public void MoveQuad(float moveAmount)
    {
        var xPos = moveAmount;
        myMaterial.mainTextureOffset =- new Vector2(xPos * Time.deltaTime, myMaterial.mainTextureOffset.y);
    }
}
