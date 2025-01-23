using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_fishPake : MonoBehaviour
{
    public Button btn_fishPic;
    public GameObject fishPic;
    public Button btn_openClick;
    public GameObject mouseChange;
    public FishAllPic fishAllPic;

    public void Init()
    {
        btn_fishPic.onClick.AddListener(() =>
        {
            ShowPic();
            print(UI_Black.I.name);
            UI_Black.I.ShowUi();
        });

        btn_openClick.onClick.AddListener(() =>
        {
            print("click mouse show");
            mouseChange.SetActive(true);
            
        });
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
        foreach (var item in fishAllPic.list_allFishPic)
        {
            item.SetActive(false);
        }
        int i = Random.Range(0, 3);
        print($"random int is: {i}");
        GameObject fishOnePic = fishAllPic.list_allFishPic[i];
        fishPic.SetActive(true);
        fishOnePic.SetActive(true);
    }

    public void HidePic()
    {
        fishPic.SetActive(false);
    }

}
