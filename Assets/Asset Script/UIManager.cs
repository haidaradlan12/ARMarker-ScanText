using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuGambarAtas, MenuGambarHello, MenuGambarBawah, MenuButtonMulai, MenuButton, MenuGuide, MenuAboutApp, MenuAboutMe, MenuOptionGambar, MenuOptionBack;
    // Start is called before the first frame update
    void Start()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuGuidebutton()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuAboutAppbutton()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuAboutMebutton()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuOptionbutton()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuUtamabutton()
    {
        MenuGambarAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarHello.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButtonMulai.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutApp.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuAboutMe.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuOptionGambar.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuOptionBack.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }

}
