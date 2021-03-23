using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobBannerScript : MonoBehaviour
{
    static bool isAdsBannerLoaded = false;
    
    void Start()
    {
        if (!isAdsBannerLoaded)
            RequestBanner();
    }

    //광고 요청 Method
    private void RequestBanner()
    {
        //테스트 광고  ID : ca-app-pub-3940256099942544/6300978111
        //내 베너 광고 ID :ca-app-pub-6284986859581864/3483152116
        //여러분들의 광고 ID가 들어갈 곳입니다.
        string BannerID = "ca-app-pub-6284986859581864/3483152116";
        BannerView bannerview = new BannerView(BannerID, AdSize.SmartBanner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();
        bannerview.LoadAd(request);
        isAdsBannerLoaded = true;
    }
}
