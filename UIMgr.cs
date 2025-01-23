using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public UI_Start ui_Start;
    public UI_Livingroom ui_Livingroom;
    public UI_Bedroom ui_Bedroom;
    public UI_Map ui_Map;
    public UI_Park ui_Park;
    public UI_Navigator ui_navigator;
    public UI_Computer ui_Computer;
    public UI_Black ui_Black;

    //the pnl who was open
    GameObject currentPanel;

    public static UIMgr I;
    private void Awake()
    {
        I = this;
    }

    public void InitAll()
    {
        ui_Start.EnterGame();
        ui_Livingroom.Init();
        ui_navigator.Init();
        ui_Map.Init();
        ui_Park.Init();
        ui_Bedroom.Init();
        ui_Computer.Init();
        ui_Black.Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        HideUiAll();
        ui_Start.ShowUi();
        ui_Start.EnterGame();
        InitAll();
        //print("init all");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideUiAll()
    {
        ui_Start.HideUi();
        ui_Livingroom.HideUi();
        ui_Bedroom.HideUi();
        ui_Map.HideUi();
        ui_Park.HideUi();
        ui_Computer.HideUi();
        ui_navigator.HideUi();
    }

   

    public void SetCurtPnl(GameObject curtPnl)
    {
        currentPanel = curtPnl;
    }

    public void HideCurtPnl()
    {
        if (currentPanel is not null)
        {
            currentPanel.gameObject.SetActive(false);

        }
        else
        {
            print("No currentPnl is opening.");
        }

    }
}
