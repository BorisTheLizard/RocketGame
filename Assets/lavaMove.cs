using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaMove : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offsetX = Time.time * scrollSpeed;
        float offsetY = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
