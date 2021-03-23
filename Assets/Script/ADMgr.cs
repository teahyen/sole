using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class ADMgr : MonoBehaviour
{
    public Text coinText;
    private int coin = 0;
    public void ShowAD()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    //public void ShowReward()
    //{
    //    if (Advertisement.IsReady("rewardVideo"))
    //        ShowOptions options = new ShowOptions { resultCallback = ResultAds };
    //    Advertisement.Show("rewardVideo", oprions);
    //}
}
