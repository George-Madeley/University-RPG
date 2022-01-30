using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStates : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool startStateClosed = true;
    [SerializeField] bool doorLocked = false;

    //cached components
    Animator animator;
    BoxCollider2D boxCollider2D;

    void Awake()
    {
        animator = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        animator.SetBool("Closed", startStateClosed);
        animator.SetBool("Locked", doorLocked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Closed", false);
        boxCollider2D.enabled = doorLocked;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Closed", true);
        boxCollider2D.enabled = true;
    }
}
