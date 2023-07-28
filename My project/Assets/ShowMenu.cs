using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    public KeyCode MenuKey = KeyCode.Escape;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(MenuKey)){
        if(menu.gameObject.activeSelf == false){
          menu.gameObject.SetActive(true);
        }
        else{
          menu.gameObject.SetActive(false);
        }
      }

    }
}
