using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRPG.Controls;
using UnityEngine.InputSystem;

public class ShowHideUI : MonoBehaviour
{
    [SerializeField] GameObject uiContainer = null;

    UniRPG.Controls.Controls InventoryContols;

    // Start is called before the first frame update
    void Start()
    {
        InventoryContols = new UniRPG.Controls.Controls();
        uiContainer.SetActive(false);
    }


    public void OnToggleInventory(InputAction.CallbackContext context){
        uiContainer.SetActive(!uiContainer.activeSelf);
    }
}
