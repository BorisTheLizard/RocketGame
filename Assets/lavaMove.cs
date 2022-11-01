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
        float offsetX = scrollSpeedX * Time.unscaledTime;
        float offsetY = scrollSpeedY * Time.unscaledTime;
        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
