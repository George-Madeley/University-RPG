using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    // Cached Components
    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider2D;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateOrderInLayer();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void UpdateOrderInLayer()
    {
        //float objectYCoordinateOfCollider = transform.position.y - spriteRenderer.bounds.size.y;
        float objectYCoordinateOfCollider = transform.position.y + boxCollider2D.offset.y - (boxCollider2D.size.y / 2);
        spriteRenderer.sortingOrder = -(int)(objectYCoordinateOfCollider * 100);
    }
}
