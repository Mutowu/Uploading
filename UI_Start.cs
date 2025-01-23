using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class UI_Start : MonoBehaviour
{
    public Button btn_start;
    public Transform title;
    public Transform trans_btn_newGame;
    public Transform trans_btn_load;
    public Transform trans_btn_set;
    public Transform trans_human;
    public Vector3 off_stagePosition;
    public Vector3 on_stagePosition;
    public Light2D lightBox;
    //public Transform trans_light_box;

    // Start is called before the first frame update
    void Start()
    {
        LightShining();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LightShining()
    {
        const float startValue = 1.7f;
        const float endValue = 2.7f;
        lightBox.pointLightOuterRadius = startValue;
        DOTween.To(() => lightBox.pointLightOuterRadius,
            x=>lightBox.pointLightOuterRadius=x,
            endValue,
            3.0f
            ).SetLoops(-1,LoopType.Yoyo);
    }

    public void ShowUi()
    {
        gameObject.SetActive(true);
    }

    public void HideUi()
    {
        gameObject.SetActive(false);
    }

    public void EnterGame()
    {
        //all pic out stage
        title.localPosition = off_stagePosition;
        trans_btn_newGame.localPosition = new Vector3(-1304, 28, 0);
        trans_btn_load.localPosition = new Vector3(-1453, -127, 0);
        trans_btn_set.localPosition = new Vector3(-1180, -289, 0);

        DOTween.Sequence()
            .Append(title.DOLocalMoveY(on_stagePosition.y, 2))
            .Append(trans_btn_newGame.DOLocalMoveX(-422 ,0.5f))
            .Join(trans_btn_load.DOLocalMoveX(-286 ,0.75f))
            .Join(trans_btn_set.DOLocalMoveX(-491, 1))
            ;

        btn_start.onClick.AddListener(() =>
        {
            GameMgr.I.HideAll();
            GameMgr.I.livingroom.ShowScene();
            UIMgr.I.HideUiAll();
            UIMgr.I.ui_Livingroom.ShowUi();
            UIMgr.I.ui_navigator.ShowUi();
            //UI_Black.I.ShowUi();
        });
    }

}
