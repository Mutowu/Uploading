using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_openCompu : MonoBehaviour
{
    public Button btn_openCompu;

    public void Init()
    {
        btn_openCompu.onClick.AddListener(() =>
        {
            UIMgr.I.HideUiAll();
            UIMgr.I.ui_Computer.ShowUi();
            GameMgr.I.HideAll();
            GameMgr.I.computer.ShowScene();
        });
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
