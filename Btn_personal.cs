using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Btn_personal : MonoBehaviour
{
    public Button btn_personal;
    public GameObject personalPic;
    //public Button btn_clear;
    public Transform trans_btn_person;

    public void Init()
    {
        OpenWin();
        HidePic();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPic()
    {
        personalPic.SetActive(true);
    }

    public void HidePic()
    {
        DOTween.Sequence().Append(trans_btn_person.DOLocalMoveX(-1829, 0.5f));
    }

    public void OpenWin()
    {
        btn_personal.onClick.AddListener(() =>
        {
            UIMgr.I.HideCurtPnl();
            trans_btn_person.localPosition = new Vector3(-1829, 478, 0);
            ShowPic();
            DOTween.Sequence().Append(trans_btn_person.DOLocalMoveX(-1228, 0.5f));
            UIMgr.I.SetCurtPnl(personalPic);
           
        });
        HidePic();
    }

    public void ClearAll()
    {
        HidePic();
    }

}
