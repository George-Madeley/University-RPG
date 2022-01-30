using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRPG.Controls;

public class MainCharacter : MonoBehaviour
{

    // Propeties
    [SerializeField] float speed = 3;

    // cached components
    Animator animationController;
    Rigidbody2D rigidBody;
    BoxCollider2D boxCollider2D;
    SpriteRenderer spriteRenderer;
    Controls playerActionControls;

    // Start is called before the first frame update

    private void Awake()
    {
        playerActionControls = new Controls();
        rigidBody = GetComponent<Rigidbody2D>();
        animationController = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    void Start()
    {
        GetTransformPosition();
    }

    private void GetTransformPosition()
    {
        LevelSession levelSession = FindObjectOfType<LevelSession>();
        transform.position = levelSession.CharacterPosition;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVelocity();
        ChangeAnimationDirection(); // changes the animation depending on the direction of the character movement
    }

    private void ChangeAnimationDirection()
    {
        float characterVelocityX = rigidBody.velocity.x;
        float characterVelocityY = rigidBody.velocity.y;
        if (characterVelocityX == 0 && characterVelocityY == 0) // if the character is stationery
        {
            animationController.SetTrigger("Idle");
        }
        else // if the character is moving
        {
            if (Mathf.Abs(characterVelocityX) >= Mathf.Abs(characterVelocityY)) // If the character is moving more in the X axis or diagonally
            {
                if (characterVelocityX > 0) // Moving Right
                {
                    animationController.SetTrigger("Right");
                }
                else if (characterVelocityX < 0) // Moving Left
                {
                    animationController.SetTrigger("Left");
                }
            }
            else if (Mathf.Abs(characterVelocityX) < Mathf.Abs(characterVelocityY)) // If the character is moving in the Y axis
            {
                if (characterVelocityY > 0) // Moving Forward
                {
                    animationController.SetTrigger("Forward");
                }
                else if (characterVelocityY < 0) // Moving Backwards
                {
                    animationController.SetTrigger("Downward");
                }
            }
        }
    }

    private void UpdateVelocity()
    {
        // read the movement value
        float movementInputHorizontal = playerActionControls.Player.WalkHorizontal.ReadValue<float>();
        float movementInputVertical = playerActionControls.Player.WalkVertical.ReadValue<float>();

        // move the player
        Vector2 playerVelocity = new Vector2(movementInputHorizontal * speed, movementInputVertical * speed);
        rigidBody.velocity = playerVelocity;
    }

    public float GetYCoordinateOfCollider()
    {
        return transform.position.y + boxCollider2D.offset.y - boxCollider2D.size.y;
    }
}

