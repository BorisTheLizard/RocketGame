using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundAnim : MonoBehaviour
{
    [SerializeField] float scrollSpeedX = 0.5f;
    [SerializeField] float scrollSpeedY = 0.5f;
    [SerializeField]Material rend;

    void Start()
    {
        rend = GetComponent<Material>();
    }

    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;
        float offsetY = Time.time * scrollSpeedY;
        rend.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
