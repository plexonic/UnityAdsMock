using System;
using UnityEngine;
using UnityEngine.UI;

public class VideoUIManager : MonoBehaviour
{
    public static event Action<string> VideoAdClosedEvent = delegate { };
    
    public Button btnWatch;
    public Button btnClose;
    public Image ImgVideo;
    public Text TxtTitle;
    
    void Awake()
    {
        AddListeners();
        Hide();
    }
    
    private void AddListeners()
    {
        btnWatch.onClick.AddListener(OnBtnWatch);
        btnClose.onClick.AddListener(OnBtnClose);
    }
    
    public void Show()
    {
        btnWatch.gameObject.SetActive(true);
        btnClose.gameObject.SetActive(true);
        ImgVideo.gameObject.SetActive(true);
        TxtTitle.gameObject.SetActive(true);
    }
    
    public void Hide()
    {
        btnWatch.gameObject.SetActive(false);
        btnClose.gameObject.SetActive(false);
        ImgVideo.gameObject.SetActive(false);
        TxtTitle.gameObject.SetActive(false);
    }

    private void OnBtnWatch()
    {
        VideoAdClosedEvent("Success");
    }
    
    private void OnBtnClose()
    {
        VideoAdClosedEvent("Cancel");
    }
}