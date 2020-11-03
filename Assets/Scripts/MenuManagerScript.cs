using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{

    public GameObject Menu;
    private bool seeMenu = false;
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(seeMenu);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            seeMenu = !seeMenu;
            Menu.SetActive(seeMenu);
        }

        if(seeMenu == true){
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }

    public void onClickContinue(){
        seeMenu = !seeMenu;
        Menu.SetActive(seeMenu);
    }

    public void onClickRestart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
