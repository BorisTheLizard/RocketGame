using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaMove : MonoBehaviour
{
    [SerializeField] float scrollSpeedX = 0.5f;
    [SerializeField] float scrollSpeedY = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;
        float offsetY = Time.time * scrollSpeedY;
        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
