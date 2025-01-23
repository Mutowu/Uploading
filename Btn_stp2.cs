using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_stp2 : MonoBehaviour
{
    public GameObject selectFunPic;
    public GameObject selectSpyPic;
    public GameObject selectEgtPic;
    public GameObject stp2Pic;
    public Button btn_fun;
    public Button btn_spy;
    public Button btn_egt;
    public Button btn_confirm;
    public Btn_upload btn_upload;


    public void Init()
    {
        SelectFun();
        SelectSpy();
        SelectEgt();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HidePic()
    {
        selectFunPic.SetActive(false);
        selectSpyPic.SetActive(false);
        selectEgtPic.SetActive(false);
        stp2Pic.SetActive(false);
    }

    public void SelectFun()
    {
        btn_fun.onClick.AddListener(() =>
        {
            UIMgr.I.HideCurtPnl();
            selectFunPic.SetActive(true);
            UIMgr.I.SetCurtPnl(selectFunPic);
            btn_confirm.onClick.AddListener(() =>
            {
                HidePic();
                btn_upload.stp3Pic.SetActive(true);
            });
        });
        HidePic();
    }

    public void SelectSpy()
    {
        btn_spy.onClick.AddListener(() =>
        {
            UIMgr.I.HideCurtPnl();
            selectSpyPic.SetActive(true);
            UIMgr.I.SetCurtPnl(selectSpyPic);
            btn_confirm.onClick.AddListener(() =>
            {
                HidePic();
                btn_upload.stp3Pic.SetActive(true);
            });
        });
        HidePic();
    }

    public void SelectEgt()
    {
        btn_egt.onClick.AddListener(() =>
        {
            UIMgr.I.HideCurtPnl();
            selectEgtPic.SetActive(true);
            UIMgr.I.SetCurtPnl(selectEgtPic);
            btn_confirm.onClick.AddListener(() =>
            {
                HidePic();
                btn_upload.stp3Pic.SetActive(true);
            });
        });
        HidePic();
    }

}
