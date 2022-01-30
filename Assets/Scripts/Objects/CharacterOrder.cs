using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOrder : MonoBehaviour
{

    // Cached Components
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateOrderInLayer();
    }

    private void UpdateOrderInLayer()
    {
        float objectYCoordinateOfCollider = transform.position.y - spriteRenderer.bounds.size.y;
        spriteRenderer.sortingOrder = -(int)(objectYCoordinateOfCollider*100);
    }
}
