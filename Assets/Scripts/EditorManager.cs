using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorManager : MonoBehaviour
{
    PlayerAction inputAction;

    public Camera mainCam;
    public Camera editorCam;

    //public GameObject prefab1;
    //public GameObject prefab2;

    //GameObject item;

    public bool editorMode = false;

    bool instantiated = false;

    // Start is called before the first frame update
    void Start()
    {
        inputAction = PlayerController.instance.inputAction;

        inputAction.Editor.EnableEditor.performed += cntxt => SwitchCamera();

        //inputAction.Editor.AddItem1.performed += cntxt => AddItem();
        //inputAction.Editor.AddItem2.performed += cntxt => AddItem();
        inputAction.Editor.DropItem.performed += cntxt => DropItem();

        mainCam.enabled = true;
        editorCam.enabled = false;

        editorMode = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void SwitchCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCam.enabled = !editorCam.enabled;

        if (mainCam.enabled == false && editorCam.enabled == true)
        {
            editorMode = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            editorMode = false;
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    /*
    private void AddItem(int itemId)
    {
        if(editorMode)
        {
            switch(itemId)
            {
                case 1:
                    item = Instantiate(prefab1);
                    break;
                case 2:
                    item = Instantiate(prefab2);
                    break;
                default:
                    break;
            }
        }
    }
    */

    private void DropItem()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
