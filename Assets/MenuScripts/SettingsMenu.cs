using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [Header("space between menu items")]
    [SerializeField] Vector2 spacing;

    Button MainButton;
    SettingsMenuItem[] menuItems;
    bool isExpanded = false;
    Vector2 mainButtonPosition;
    int itemsCount;
    void Start()
    {
        itemsCount = transform.childCount - 1;
        menuItems = new SettingsMenuItem[itemsCount];
        for (int i = 0; i<itemsCount;i++)
        {
            menuItems[i] = transform.GetChild(i + 1).GetComponent<SettingsMenuItem>();
        }
        MainButton = transform.GetChild(0).GetComponent<Button>();
        MainButton.onClick.AddListener(ToggleMenu);
        MainButton.transform.SetAsLastSibling();
        mainButtonPosition = MainButton.transform.position;

    }
    void Resetpositions()
    {
        for(int i=0;i<itemsCount;i++)
        {
            menuItems[i].trans.position = mainButtonPosition;

        }
    }
    void ToggleMenu()
    {
        isExpanded = !isExpanded;
        if (isExpanded)
        {
            for(int i = 0; i < itemsCount;i++)
            {
                menuItems[i].trans.position = mainButtonPosition + spacing*(i+1);
            }
        }
        else
        {
            for (int i = 0; i < itemsCount; i++)
            {
                menuItems[i].trans.position = mainButtonPosition;
            }
        }
    }
    void destroy()
    {
        MainButton.onClick.RemoveListener(ToggleMenu);
    }

}
