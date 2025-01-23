using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Navigator : MonoBehaviour
{
    public Btn_money btn_money;
    public Button btn_clearPay;
    public Button btn_clearPerson;
    public Button btn_goBedroom;
    public Btn_cloth btn_clothes;
    public Button btn_clearCloth;
    public Btn_bag btn_bag;
    public Btn_personal btn_personal;

    public void GoBedInit()
    {
        btn_goBedroom.onClick.AddListener(() =>
        {
            GameMgr.I.HideAll();
            GameMgr.I.bedroom.ShowScene();
            UIMgr.I.HideUiAll();
            
            UIMgr.I.ui_Bedroom.ShowUi();
            ShowUi();
            print("123");
        });
    }


    public void Init()
    {
        //print("open oder");
        btn_money.Init();
        print("open oder");
        btn_clearPay.onClick.AddListener(() =>
        {
            btn_money.ClearAll();
        });
        //money

        GoBedInit();
        //go bedroom

        btn_personal.Init();
        btn_clearPerson.onClick.AddListener(() =>
        {
            btn_personal.ClearAll();
        });
        //person

        btn_clothes.Init();
        btn_clearCloth.onClick.AddListener(() =>
        {
            btn_clothes.ClearAll();
        });
        //clothes

        btn_bag.Init();
        btn_clearPay.onClick.AddListener(() =>
        {
            btn_bag.HidePic();
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

    public void ShowUi()
    {
        gameObject.SetActive(true);
    }

    public void HideUi()
    {
        gameObject.SetActive(false);
    }

    
}
